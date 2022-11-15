using Microsoft.AspNetCore.Http;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Core
{
    public interface IFileService
    {
        /// <summary>
        /// Upload files
        /// </summary>
        /// <param name="files"></param>
        /// <param name="rootPath"></param>
        /// <param name="subDirectory"></param>
        string UploadFile(List<IFormFile> files, string rootPath, string? subDirectory = "", string extentFilename = "");
        
        /// <summary>
        /// Download file
        /// </summary>
        /// <param name="rootPath"></param>
        /// <param name="fileDownloadPath"></param>
        /// <param name="fileName"></param>
        Task<MemoryStream> DownloadFileAsync(string rootPath, string fileDownloadPath, string fileName);

        /// <summary>
        /// Export Data to file using predefined template
        /// </summary>
        /// <param name="fileExportPath"></param>
        /// <param name="templateFilePath"></param>
        /// <param name="data"></param>
        /// <param name="deliminator"></param>
        /// <param name="fileType"></param>
        void ExportDataToFileTemplate(string fileExportPath, string templateFilePath, DataSet data, string[] deliminator = null!, FileType fileType = FileType.Excel);
        
        /// <summary>
        /// Export Data to file using predefined template
        /// </summary>
        /// <param name="fileExportPath"></param>
        /// <param name="templateFilePath"></param>
        /// <param name="data"></param>
        /// <param name="deliminator"></param>
        /// <param name="fileType"></param>
        void ExportDataToFileTemplate<T>(string fileExportPath, string templateFilePath, List<T> data, string[] deliminator, FileType fileType = FileType.Docx);


        /// <summary>
        /// Export Data to file using predefined template
        /// </summary>
        /// <param name="fileExportPath"></param>
        /// <param name="templateFilePath"></param>
        /// <param name="data"></param>
        /// <param name="deliminator"></param>
        /// <param name="fileType"></param>
        void ExportDataToFileTemplate<T>(string fileExportPath, string templateFilePath, T data, string[] deliminator, FileType fileType = FileType.Excel);

        /// <summary>
        /// Export error message to file
        /// </summary>
        /// <param name="fileExportPath"></param>
        /// <param name="message"></param>
        /// <param name="fileType"></param>
        void ExportErrorMessageToFile(string fileExportPath, object message, FileType fileType = FileType.Excel);

        /// <summary>
        /// Convert ExcelWorksheet to model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sheet"></param>
        /// <returns></returns>
        List<T?>? GetList<T>(ExcelWorksheet sheet, ref string msg);

        /// <summary>
        /// Deleting multiple files with wildcard
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="wildcard"></param>
        void DeleteFile(string directoryPath, string wildcard, bool keepWildcard = true, bool deleteAll = true);
    }
}