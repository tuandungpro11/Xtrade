using Microsoft.AspNetCore.Http;

namespace TVSI.XTRADE.BO.API.Services.Impls.Core;

public class FileService : BaseService<FileService>, IFileService
{
    public FileService(ILogger<FileService> logger, IConfiguration config)
        : base(logger, config)
    {
    }
    
    public string UploadFile(List<IFormFile> files, string rootPath, string? subDirectory = "", string extentFilename = "")
    {
        subDirectory ??= string.Empty;
        var target = Path.Combine(rootPath, subDirectory).ToLower();

        if (!Directory.Exists(target))
            Directory.CreateDirectory(target);
        var imgUrls = string.Empty;
        files.ForEach(file =>
        {
            if (file.Length <= 0) return;
            var filename = $"{extentFilename}{file.FileName}";
            var filePath = Path.Combine(target, filename.ToLower());
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            var filePathUri = new Uri(filePath).AbsoluteUri;
            var rootPathUri = new Uri(rootPath.ToLower()).AbsoluteUri;

            imgUrls = imgUrls + "|" + filePathUri.Replace(rootPathUri, string.Empty);
        });

        return imgUrls;
    }
    
    public async Task<MemoryStream> DownloadFileAsync(string rootPath, string fileDownloadPath, string fileName)
    {
        var folderDownloadPath = Path.Combine(rootPath, fileDownloadPath);
        if (!Directory.Exists(folderDownloadPath)) Directory.CreateDirectory(folderDownloadPath);
        var filePath = Path.Combine(folderDownloadPath, fileName);

        var memoryStream = new MemoryStream();

        using (var stream = new FileStream(filePath, FileMode.Open))
        {
            await stream.CopyToAsync(memoryStream);
        }

        memoryStream.Position = 0;

        return memoryStream;
    }

    public void ExportDataToFileTemplate(string fileExportPath, string templateFilePath, DataSet data,
        string[] deliminator, FileType fileType = FileType.Excel)
    {
        switch (fileType)
        {
            case FileType.Excel:
                ExportDataToExcelTemplate(fileExportPath, templateFilePath, data, deliminator);
                break;
            case FileType.Doc:
            case FileType.Docx:
                ExportDataToDocTemplate(fileExportPath, templateFilePath, data, deliminator);
                break;
            case FileType.PDF:
            case FileType.Xml:
            case FileType.Html:
            case FileType.Text:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
        }
    }

    public void ExportDataToFileTemplate<T>(string fileExportPath, string templateFilePath, T data,
        string[] deliminator, FileType fileType = FileType.Excel)
    {
        switch (fileType)
        {
            case FileType.Excel:
                var ds = JsonConvert.SerializeObject(data).ToDataSet();
                ExportDataToExcelTemplate(fileExportPath, templateFilePath, ds, deliminator);
                break;
            case FileType.Doc:
            case FileType.Docx:
            case FileType.PDF:
            case FileType.Xml:
            case FileType.Html:
            case FileType.Text:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
        }
    }

    public void ExportDataToFileTemplate<T>(string fileExportPath, string templateFilePath, List<T> data,
        string[] deliminator, FileType fileType = FileType.Docx)
    {
        switch (fileType)
        {
            case FileType.Excel:
                var ds = JsonConvert.SerializeObject(data).ToDataSet();
                ExportDataToExcelTemplate(fileExportPath, templateFilePath, ds, deliminator);
                break;
            case FileType.Doc:
            case FileType.Docx:
                ExportDataToDocTemplate(fileExportPath, templateFilePath, data, deliminator);
                break;
            case FileType.PDF:
            case FileType.Xml:
            case FileType.Html:
            case FileType.Text:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
        }
    }

    public void ExportErrorMessageToFile(string fileExportPath, object message, FileType fileType = FileType.Excel)
    {
        try
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excel = new ExcelPackage();

            var workSheet = excel.Workbook.Worksheets.Add("Error Message");

            workSheet.TabColor = Color.Red;

            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            workSheet.Row(1).Style.Font.Bold = true;

            workSheet.Cells[1, 1].Value = JsonConvert.SerializeObject(message);

            if (File.Exists(fileExportPath))
                File.Delete(fileExportPath);

            var objFileStream = File.Create(fileExportPath);
            objFileStream.Close();

            File.WriteAllBytes(fileExportPath, excel.GetAsByteArray());
            excel.Dispose();
        }
        catch (Exception ex)
        {
            _logger.LogInformation($"{ex.Message} - {ex.InnerException} - {ex.StackTrace}");
        }
    }

    public List<T?>? GetList<T>(ExcelWorksheet sheet, ref string msg)
    {
        var lastRow = 0;
        var lastCol = 0;
        msg = string.Empty;
        try
        {
            var list = new List<T?>();
            //first row is for knowing the properties of object
            var columnInfo = Enumerable.Range(1, sheet.Dimension.Columns).ToList().Select(n =>
                new
                {
                    Index = n,
                    ColumnName = sheet.Cells[1, n].Value != null ? sheet.Cells[1, n].Value.ToString() : string.Empty
                }
            );

            for (var row = 2; row <= sheet.Dimension.Rows; row++)
            {
                var isAdd = true;
                var obj = (T)Activator.CreateInstance(typeof(T))!; //generic object
                foreach (var prop in typeof(T).GetProperties())
                {
                    var colExist = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name);
                    if (colExist == null)
                        continue;
                    var col = colExist.Index;
                    var val = sheet.Cells[row, col].Value;
                    if (val == null)
                    {
                        isAdd = false;
                        break;
                    }

                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(val, propType));
                    lastRow = row;
                    lastCol = col;
                }

                if (isAdd)
                    list.Add(obj);
            }

            return list;
        }
        catch (Exception ex)
        {
            msg = $"{lastRow}:{lastCol} {ex.Message}";
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {lastRow}:{lastCol} {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return default;
        }
    }

    #region Helper methods

    public void DeleteFile(string directoryPath, string wildcard, bool keepWildcard = true, bool deleteAll = false)
    {
        var dir = new DirectoryInfo(directoryPath);
        if (deleteAll)
        {
            foreach (var file in dir.GetFiles()) file.Delete();
        }
        else
        {
            var files = dir.EnumerateFiles(wildcard);
            if (keepWildcard) //giữ lại wildcard và xóa những file khác
            {
                var includeFiles = GetFiles(directoryPath, files);
                foreach (var file in includeFiles) file.Delete();
            }
            else
            {
                foreach (var file in files) file.Delete();
            }
        }
    }

    //Get all files excluded some files
    public static IEnumerable<FileInfo> GetFiles(string directoryPath, IEnumerable<FileInfo> excludedFiles, IEnumerable<string> excludedExtensions = null)
    {
        var dir = new DirectoryInfo(directoryPath);
        var files = dir.EnumerateFiles("*.*");

        foreach (var file in files)
        {
            if (excludedFiles != null && excludedFiles.Contains(file))
            {
                continue;
            }

            if (excludedExtensions != null && excludedExtensions.Contains(Path.GetExtension(file.Extension)))
            {
                continue;
            }

            yield return file;
        }
    }

    #endregion Helper methods

    #region Export File Html

    public void ExportHtmlFromTemplate(string filename, string templateFilename, DataSet data, string[] deliminator)
    {
    }

    #endregion Export File Html

    #region Export File Excel

    private void ExportDataToExcelTemplate(string filename, string templateFilename, DataSet data, string[] deliminator)
    {
        if (File.Exists(filename))
            File.Delete(filename);

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (var file = new FileStream(filename, FileMode.CreateNew))
        {
            using (var temp = new FileStream(templateFilename, FileMode.Open, FileAccess.Read))
            {
                using (var xls = new ExcelPackage(file, temp))
                {
                    foreach (var n in xls.Workbook.Names)
                        FillDataToWorksheetWithExcelNameRange(data, n.Worksheet, n, deliminator);

                    foreach (var ws in xls.Workbook.Worksheets)
                    foreach (var n in ws.Names)
                        FillDataToWorksheetWithExcelNameRange(data, ws, n, deliminator);

                    foreach (var ws in xls.Workbook.Worksheets) FillDataToWorksheet(data, ws, deliminator);

                    xls.Save();
                }
            }
        }
    }

    private void FillDataToWorksheet(DataSet data, ExcelWorksheet ws, string[] deliminator)
    {
        try
        {
            foreach (var c in ws.Cells)
            {
                var s = "" + c.Value;
                if (s.StartsWith(deliminator[0]) == false &&
                    s.EndsWith(deliminator[1]) == false)
                    continue;
                s = s.Replace(deliminator[0], "").Replace(deliminator[1], "");
                var ss = s.Split('.');
                try
                {
                    if (data.Tables[ss[0]] != null) c.Value = data.Tables[ss[0]]?.Rows[0][ss[1]];
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
        }
    }

    private void FillDataToWorksheetWithExcelNameRange(DataSet data, ExcelWorksheet ws, ExcelNamedRange n,
        string[] deliminator)
    {
        try
        {
            if (data.Tables.Contains(n.Name) == false)
                return;

            var dt = data.Tables[n.Name];

            var row = n.Start.Row;
            if (dt == null) return;

            ws.InsertRow(row + 1, dt.Rows.Count - 1, row);

            var colName = new string?[n.Columns];
            var colStyle = new int[n.Columns];
            for (var i = 0; i < n.Columns; i++)
            {
                var val = (n.Value as object[,])?[0, i] ?? string.Empty;

                colName[i] = val.ToString()?.Replace(deliminator[0], "").Replace(deliminator[1], "");
                if (colName[i]!.Contains("."))
                    colName[i] = colName[i]?.Split('.')[1];
                colStyle[i] = ws.Cells[row, n.Start.Column + i].StyleID;
            }

            if (dt.Rows.Count > 0)
                foreach (DataRow r in dt.Rows)
                {
                    for (var col = 0; col < n.Columns; col++)
                    {
                        if (dt.Columns.Contains(colName[col]!))
                            ws.Cells[row, n.Start.Column + col].Value = r[colName[col]!];
                        ws.Cells[row, n.Start.Column + col].StyleID = colStyle[col];
                    }

                    row++;
                }
            else
                for (var col = 0; col < n.Columns; col++)
                {
                    if (dt.Columns.Contains(colName[col]!))
                        ws.Cells[row, n.Start.Column + col].Value = "";
                    ws.Cells[row, n.Start.Column + col].StyleID = colStyle[col];
                }

            // extend table formatting range to all rows
            foreach (var t in ws.Tables)
            {
                var a = t.Address;
                if (n.Start.Row.Between(a.Start.Row, a.End.Row) &&
                    n.Start.Column.Between(a.Start.Column, a.End.Column))
                    ExtendRows(t, dt.Rows.Count - 1);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
        }
    }

    private static void ExtendRows(ExcelTable excelTable, int count)
    {
        var ad = new ExcelAddress(excelTable.Address.Start.Row,
            excelTable.Address.Start.Column,
            excelTable.Address.End.Row + count,
            excelTable.Address.End.Column);
    }

    #endregion Export File Excel

    #region Export File Doc

    private static void ExportDataToDocTemplate(string fileExportPath, string templateFilePath, DataSet data,
        string[] deliminator)
    {
        #region Using OpenXml

        var xData = data.Tables[1].ToJsonObject();
        var arrJson = JArray.Parse(xData);
        var dict = new Dictionary<string, object>();
        foreach (var item in arrJson)
        {
            dict = item.ToString().JObjectToDictionary();
            break;
        }

        var byteArray = File.ReadAllBytes(templateFilePath);
        using var stream = new MemoryStream();
        stream.Write(byteArray, 0, byteArray.Length);
        using (var wordDoc = WordprocessingDocument.Open(stream, true))
        {
            // Modify the document as necessary.
            var doc = wordDoc.MainDocumentPart?.Document;
            var body = doc?.Body;
            var paras = body?.Elements<Paragraph>();

            if (paras != null)
                foreach (var para in paras)
                foreach (var run in para.Elements<Run>())
                foreach (var text in run.Elements<Text>())
                foreach (var (key, value) in dict)
                    if (text.Text.Contains($"{deliminator[0]}{key}{deliminator[1]}"))
                        text.Text = text.Text.Replace($"{deliminator[0]}{key}{deliminator[1]}", value.ToString());

            var tables = doc?.Descendants<Table>().ToList();
            if (tables != null)
                foreach (var text in from t in tables
                         select t.Elements<TableRow>()
                         into rows
                         from row in rows
                         select row.Elements<TableCell>()
                         into cells
                         from cell in cells
                         from para in cell.Elements<Paragraph>()
                         from run in para.Elements<Run>()
                         from text in run.Elements<Text>()
                         select text)
                foreach (var (key, value) in dict)
                    if (text.Text.Contains($"{deliminator[0]}{key}{deliminator[1]}"))
                        text.Text = text.Text.Replace($"{deliminator[0]}{key}{deliminator[1]}", value.ToString());

            //Make changes to the document and save it.
            wordDoc.MainDocumentPart?.Document.Save();
            wordDoc.Close();
        }

        // Save the file with the new name
        stream.Position = 0;
        File.WriteAllBytes(fileExportPath, stream.ToArray());

        #endregion Using OpenXml
    }

    private static void ExportDataToDocTemplate(string fileExportPath, string templateFilePath, DataTable data,
        string[] deliminator)
    {
        #region Using OpenXml

        var xData = data.ToJsonObject();
        var arrJson = JArray.Parse(xData);
        var dict = new Dictionary<string, object>();
        foreach (var item in arrJson)
        {
            dict = item.ToString().JObjectToDictionary();
            break;
        }

        var byteArray = File.ReadAllBytes(templateFilePath);
        using var stream = new MemoryStream();
        stream.Write(byteArray, 0, byteArray.Length);
        using (var wordDoc = WordprocessingDocument.Open(stream, true))
        {
            // Modify the document as necessary.
            var doc = wordDoc.MainDocumentPart?.Document;
            var body = doc?.Body;
            var paras = body?.Elements<Paragraph>();

            if (paras != null)
                foreach (var para in paras)
                foreach (var run in para.Elements<Run>())
                foreach (var text in run.Elements<Text>())
                foreach (var (key, value) in dict)
                    if (text.Text.Contains($"{deliminator[0]}{key}{deliminator[1]}"))
                        text.Text = text.Text.Replace($"{deliminator[0]}{key}{deliminator[1]}", value.ToString());

            var tables = doc?.Descendants<Table>().ToList();
            if (tables != null)
                foreach (var text in from t in tables
                         select t.Elements<TableRow>()
                         into rows
                         from row in rows
                         select row.Elements<TableCell>()
                         into cells
                         from cell in cells
                         from para in cell.Elements<Paragraph>()
                         from run in para.Elements<Run>()
                         from text in run.Elements<Text>()
                         select text)
                foreach (var (key, value) in dict)
                    if (text.Text.Contains($"{deliminator[0]}{key}{deliminator[1]}"))
                        text.Text = text.Text.Replace($"{deliminator[0]}{key}{deliminator[1]}", value.ToString());

            //Make changes to the document and save it.
            wordDoc.MainDocumentPart?.Document.Save();
            wordDoc.Close();
        }

        // Save the file with the new name
        stream.Position = 0;
        File.WriteAllBytes(fileExportPath, stream.ToArray());

        #endregion Using OpenXml
    }

    private static void ExportDataToDocTemplate<T>(string fileExportPath, string templateFilePath, List<T> data,
        string[] deliminator)
    {
        #region Using OpenXml

        var xData = JsonConvert.SerializeObject(data);
        var arrJson = JArray.Parse(xData);
        var dict = new Dictionary<string, object>();
        foreach (var item in arrJson)
        {
            dict = item.ToString().JObjectToDictionary();
            break;
        }

        var byteArray = File.ReadAllBytes(templateFilePath);
        using var stream = new MemoryStream();
        stream.Write(byteArray, 0, byteArray.Length);
        using (var wordDoc = WordprocessingDocument.Open(stream, true))
        {
            // Modify the document as necessary.
            var doc = wordDoc.MainDocumentPart?.Document;
            var body = doc?.Body;
            var paras = body?.Elements<Paragraph>();

            if (paras != null)
                foreach (var para in paras)
                foreach (var run in para.Elements<Run>())
                foreach (var text in run.Elements<Text>())
                foreach (var (key, value) in dict)
                    if (text.Text.Contains($"{deliminator[0]}{key}{deliminator[1]}"))
                        text.Text = text.Text.Replace($"{deliminator[0]}{key}{deliminator[1]}", value.ToString());

            var tables = doc?.Descendants<Table>().ToList();
            if (tables != null)
                foreach (var text in from t in tables
                         select t.Elements<TableRow>()
                         into rows
                         from row in rows
                         select row.Elements<TableCell>()
                         into cells
                         from cell in cells
                         from para in cell.Elements<Paragraph>()
                         from run in para.Elements<Run>()
                         from text in run.Elements<Text>()
                         select text)
                foreach (var (key, value) in dict)
                    if (text.Text.Contains($"{deliminator[0]}{key}{deliminator[1]}"))
                        text.Text = text.Text.Replace($"{deliminator[0]}{key}{deliminator[1]}", value.ToString());

            //Make changes to the document and save it.
            wordDoc.MainDocumentPart?.Document.Save();
            wordDoc.Close();
        }

        // Save the file with the new name
        stream.Position = 0;
        File.WriteAllBytes(fileExportPath, stream.ToArray());

        #endregion Using OpenXml
    }

    #endregion Export File Doc
}

public static class IntBetween
{
    public static bool Between(this int v, int a, int b)
    {
        return v >= a && v <= b;
    }
}