using TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

[ApiVersion("1.0")]
public class ExTraderController : BaseController<ExTraderController>
{
    private readonly IExTraderService _exTraderService;

    public ExTraderController(ILogger<ExTraderController> logger, IConfiguration config, IDetectionService detection,
        IExTraderService exTraderService, IFileService fileService, IHostingEnvironment hostEnv)
        : base(logger, config, detection, fileService, hostEnv)
    {
        _exTraderService = exTraderService;
    }


    /// <summary>
    ///     Lấy danh sách TraderID không phát sinh phiếu lệnh
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/ExTrader/GetExTraderList
    ///     {
    ///         "ExTraderId": -1,
    ///         "TraderId": "",
    ///         "Branch": "",
    ///         "TraderType":-1,
    ///         "Status": -1,
    ///         "FromDate": "20170101",
    ///         "ToDate": "20701231",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    /// 
    ///     Status:
    ///         -1: Search All
    ///         0: Ngừng sử dụng
    ///         1: Đang sử dụng
    /// 
    ///     TraderType:
    ///         -1: Search All
    ///         0: EnterID
    ///         1: CancelID
    /// 
    ///     Format Date: yyyyMMdd 
    /// </remarks>
    
    [HttpPost("GetExTraderList")]
    public async Task<IActionResult> GetExTraderListAsync(ExTraderListRequest model)
    {
        var response = await _exTraderService.GetExTraderListAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Thêm TraderID không phát sinh phiếu lệnh
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/ExTrader/CreateExTrader
    ///     {
    ///         "TraderId": "1232",
    ///         "TraderType":1,
    ///         "Status": 1,
    ///         "EffDate": "2022-07-01",
    ///         "ExpDate": "2022-07-25",
    ///         "Remark": "Abc",
    ///         "UserId": "hungnd"
    ///     }
    /// 
    ///     Format Date: yyyy-MM-dd
    /// </remarks>
    
    [HttpPost("CreateExTrader")]
    public async Task<IActionResult> CreateExTraderAsync(ExTraderCreateRequest model)
    {
        var response = await _exTraderService.CreateExTraderAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Cập nhật TraderID không phát sinh phiếu lệnh
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/ExTrader/UpdateExTrader
    ///     {
    ///         "ExTraderId" : 123
    ///         "TraderId": "1232",
    ///         "TraderType": 1,
    ///         "Status": 1,
    ///         "EffDate": "2022-07-01",
    ///         "ExpDate": "2022-07-25",
    ///         "Remark": "Abc",
    ///         "UserId": "hungnd"
    ///     }
    /// 
    ///     Format Date: yyyy-MM-dd
    /// </remarks>
    
    [HttpPost("UpdateExTrader")]
    public async Task<IActionResult> UpdateExTraderAsync(ExTraderUpdateRequest model)
    {
        var response = await _exTraderService.UpdateExTraderAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Xóa thông tin TraderID không phát sinh phiếu lệnh
    /// </summary>
    /// <param name="exTraderId"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/ExTrader/DeleteExTrader/0213
    /// 
    /// </remarks>
    
    [HttpPost("DeleteExTrader/{exTraderId:long}")]
    public async Task<IActionResult> DeleteExTraderAsync(long exTraderId)
    {
        var response = await _exTraderService.DeleteExTraderAsync(exTraderId);
        return Ok(response);
    }

    /// <summary>
    ///     Kiểm tra TraderID không phát sinh phiếu lệnh
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/ExTrader/CheckExTraderId
    ///     {
    ///         "AgentId": "2002",
    ///         "AgentType": 1,
    ///         "IsLike": 0,
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    ///
    ///     IsLike:
    ///         0: Tìm kiếm chính xác
    ///         1: Tìm kiếm gần đúng
    /// </remarks>
    
    [HttpPost("CheckExTraderId")]
    public async Task<IActionResult> CheckExTraderIdAsync(ExTraderCheckRequest model)
    {
        var response = await _exTraderService.CheckExTraderAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Thêm log TraderID không phát sinh phiếu lệnh
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/ExTrader/CreateLogExTrader
    ///     {
    ///         "CustomerId": "000515",
    ///         "UserId": "hungnd",
    ///         "ActionType":7,
    ///         "OldInfo": "1",
    ///         "NewInfo": "0",
    ///         "IP": "127.0.0.1",
    ///         "Remark": "Abc",
    ///         "Module": 123
    ///     }
    /// </remarks>
    
    [HttpPost("CreateLogExTrader")]
    public async Task<IActionResult> CreateLogExTraderAsync(ExTraderLogRequest model)
    {
        var response = await _exTraderService.CreateLogExTraderAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Export danh sách TraderID không phát sinh phiếu lệnh
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/ExTrader/ExportExTraderList
    ///     {
    ///         "ExTraderId": -1,
    ///         "TraderId": "",
    ///         "Branch": "",
    ///         "TraderType":-1,
    ///         "Status": -1,
    ///         "FromDate": "20170101",
    ///         "ToDate": "20701231"
    ///     }
    /// 
    ///     Status:
    ///         -1: Search All
    ///         0: Ngừng sử dụng
    ///         1: Đang sử dụng
    /// 
    ///     TraderType:
    ///         -1: Search All
    ///         0: EnterID
    ///         1: CancelID
    /// 
    ///     Format Date: yyyyMMdd 
    /// </remarks>
    
    [HttpPost("ExportExTraderList")]
    public async Task<IActionResult> ExportExTraderListAsync(ExTraderListExportRequest model)
    {
        var folderExportPath = GetFolderExportPath();
        var fileName = $"TRADERID_KHONG_PHAT_SINH_PL_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
        var fileExportPath = Path.Combine(folderExportPath, fileName);

        var fs = await _exTraderService.ExportExTraderListAsync(model, fileExportPath);
        return File(fs, "application/octet-stream", fileName);
    }
}