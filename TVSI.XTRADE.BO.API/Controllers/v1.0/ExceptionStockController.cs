using TVSI.XTRADE.BO.API.Models.Model.Request.Stock;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

[ApiVersion("1.0")]
public class ExceptionStockController : BaseController<ExceptionStockController>
{
    private readonly IExceptionStockService _exceptionStockService;

    public ExceptionStockController(ILogger<ExceptionStockController> logger, IConfiguration config,
        IDetectionService detection, IFileService fileService, IHostingEnvironment env,
        IExceptionStockService exceptionStockService)
        : base(logger, config, detection, fileService, env)
    {
        _exceptionStockService = exceptionStockService;
    }

    /// <summary>
    ///     Lấy danh sách mã CK loại trừ đặt lệnh trước ngày
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Stock/GetExceptionStockList
    ///     {
    ///         "Symbol": "",
    ///         "FromDate": "20220616",
    ///         "ToDate": "20220623",
    ///         "LangId" : 1,
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     } 
    ///
    ///     LangId:
    ///         1: VN
    ///         2: EN
    /// 
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("GetExceptionStockList")]
    public async Task<IActionResult> GetExceptionStockListAsync(ExceptionStockListRequest model)
    {
        var response = await _exceptionStockService.GetExceptionStockListAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Thêm mã CK loại trừ đặt lệnh trước ngày
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Stock/CreateExceptionStock
    ///     {
    ///         "Symbol": "HVN",
    ///         "Date": "20220629",
    ///         "Market": "HOSE",
    ///     }
    /// 
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("CreateExceptionStock")]
    public async Task<IActionResult> CreateExceptionStockAsync(ModifyExceptionStock model)
    {
        var response = await _exceptionStockService.CreateExceptionStockAsync(model);
        return Ok(response);
    }


    /// <summary>
    ///     Cập nhật mã CK loại trừ đặt lệnh trước ngày
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Stock/UpdateExceptionStock
    ///     {
    ///         "Id": 12,
    ///         "Symbol": "HVN",
    ///         "Date": "20220702",
    ///         "Market": "HOSE",
    ///     }
    /// 
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("UpdateExceptionStock")]
    public async Task<IActionResult> UpdateExceptionStockAsync(ModifyExceptionStock model)
    {
        var response = await _exceptionStockService.UpdateExceptionStockAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Xóa mã CK loại trừ đặt lệnh trước ngày
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Stock/DeleteExceptionStock
    ///     {
    ///         "Symbol": "HVN",
    ///         "FromDate": "20220623",
    ///         "ToDate": "20220629"
    ///     }
    /// 
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("DeleteExceptionStock")]
    public async Task<IActionResult> DeleteExceptionStockAsync(DeleteExceptionStockRequest model)
    {
        var response = await _exceptionStockService.DeleteExceptionStockAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy thông tin mã CK
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Stock/GetStockInfoBySymbol
    ///     {
    ///         "Symbol": "HVN",
    ///         "LanguageId": 1
    ///     }
    ///
    ///     LanguageId:
    ///         1: VN
    ///         2: EN
    /// </remarks>
    
    [HttpPost("GetStockInfoBySymbol")]
    public async Task<IActionResult> GetStockInfoDetailAsync(StockInfoRequest model)
    {
        //var response = await _stockService.GetStockInfoDetailAsync(model);
        //return Ok(response);
        return NotFound(CommonConstants.ApiDeprecated);
    }
    
    /// <summary>
    /// Lấy template file Import.
    /// </summary>
    /// <returns></returns>
    
    [HttpPost("DownloadTemplateImportExceptionStock")]
    public async Task<IActionResult> DownloadTemplateImportExceptionStockAsync()
    {
        var rootPath = _hostEnv.ContentRootPath;
        const string fileName = "ImportExceptionStock.xlsx";
        var memoryStream = await _fileService.DownloadFileAsync(rootPath, "Template/Import", fileName);

        return File(memoryStream, "application/octet-stream", fileName);
    }

    /// <summary>
    /// Import data from excel file.
    /// </summary>
    /// <param name="formFile"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    
    [HttpPost("ImportExceptionStock")]
    public async Task<IActionResult> ImportExceptionStockFromFileExcelAsync(IFormFile formFile, CancellationToken cancellationToken)
    {
        var response = await _exceptionStockService.ImportExceptionStockFromFileExcelAsync(formFile, cancellationToken);
        return Ok(response);
    }

    /// <summary>
    ///     Export danh sách mã CK loại trừ đặt lệnh trước ngày
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Stock/GetExceptionStockList
    ///     {
    ///         "Symbol": "",
    ///         "FromDate": "20220616",
    ///         "ToDate": "20220623",
    ///         "LangId" : 1
    ///     } 
    ///
    ///     LangId:
    ///         1: VN
    ///         2: EN
    /// 
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("ExportExceptionStockList")]
    public async Task<IActionResult> ExportExceptionStockListAsync(ExceptionStockListExportRequest model)
    {
        var folderExportPath = GetFolderExportPath();
        var fileName = $"DS_MA_CK_LOAI_TRU_DAT_LENH_TRUOC_NGAY_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
        var fileExportPath = Path.Combine(folderExportPath, fileName);

        var fs = await _exceptionStockService.ExportExceptionStockListAsync(model, fileExportPath);
        return File(fs, "application/octet-stream", fileName);
    }
}