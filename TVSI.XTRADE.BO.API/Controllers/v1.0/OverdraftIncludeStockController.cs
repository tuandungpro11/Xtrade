using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftIncludeStock;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

[ApiVersion("1.0")]
public class OverdraftIncludeStockController : BaseController<OverdraftIncludeStockController>
{
    private readonly IOverdraftIncludeStockService _overdraftStockService;

    public OverdraftIncludeStockController(ILogger<OverdraftIncludeStockController> logger, IConfiguration config,
        IDetectionService detection, IOverdraftIncludeStockService overdraftStockService, IFileService fileService, IHostingEnvironment hostEnv)
        : base(logger, config, detection, fileService, hostEnv)
    {
        _overdraftStockService = overdraftStockService;
    }


    /// <summary>
    ///     Lấy danh sách mã CK được mua
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/OverdraftIncludeStock/GetOverdraftIncludeStockList
    ///     {
    ///         "Id": -1,
    ///         "Symbol": "",
    ///         "Status": -1,
    ///         "FromDate": "",
    ///         "ToDate": "",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    /// 
    ///     Status:
    ///         -1: Search All
    ///         0: Ngừng sử dụng
    ///         1: Đang sử dụng
    /// 
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("GetOverdraftIncludeStockList")]
    public async Task<IActionResult> GetBankListAsync(OverdraftIncludeStockListRequest model)
    {
        var response = await _overdraftStockService.GetOverdraftIncludeStockListAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Thêm thông tin mã CK được mua
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/OverdraftIncludeStock/CreateOverdraftIncludeStock
    ///     {
    ///         "Symbol": "HVN",
    ///         "Status": 1,
    ///         "EffectDate": "2022-07-26",
    ///         "ExpireDate": "2022-07-27",
    ///         "Remark": "Abc",
    ///         "UserId": "hungnd"
    ///     }
    /// 
    ///     Format Date: yyyy-MM-dd
    /// </remarks>
    
    [HttpPost("CreateOverdraftIncludeStock")]
    public async Task<IActionResult> CreateOverdraftIncludeStockAsync(OverdraftIncludeStockRequest model)
    {
        var response = await _overdraftStockService.ModifyOverdraftIncludeStockAsync(model);
        return Ok(response);
    }


    /// <summary>
    ///     Cập nhật thông tin mã CK được mua
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/OverdraftIncludeStock/UpdateOverdraftIncludeStock
    ///     {
    ///         "Id": 112,
    ///         "Symbol": "ACB",
    ///         "Status": 1,
    ///         "EffectDate": "2022-07-26",
    ///         "ExpireDate": "2022-07-27",
    ///         "Remark": "Abc",
    ///         "UserId": "hungnd"
    ///     }
    /// 
    ///     Format Date: yyyy-MM-dd
    /// </remarks>
    
    [HttpPost("UpdateOverdraftIncludeStock")]
    public async Task<IActionResult> UpdateOverdraftIncludeStockAsync(OverdraftIncludeStockRequest model)
    {
        var response = await _overdraftStockService.ModifyOverdraftIncludeStockAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Xóa thông tin mã CK được mua
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/OverdraftIncludeStock/DeleteOverdraftIncludeStock/126
    /// </remarks>
    
    [HttpPost("DeleteOverdraftIncludeStock/{id:int}")]
    public async Task<IActionResult> DeleteOverdraftIncludeStockAsync(int id)
    {
        var response = await _overdraftStockService.DeleteOverdraftIncludeStockAsync(id);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy lịch sử mã CK được mua
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/OverdraftIncludeStock/GetOverdraftIncludeStockHistoryList
    ///     {
    ///         "Id": 112,
    ///         "Symbol": "HVN",
    ///         "Status": -1,
    ///         "FromDate": "20220612",
    ///         "ToDate": "20220613",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    /// 
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("GetOverdraftIncludeStockHistoryList")]
    public async Task<IActionResult> GetOverdraftIncludeStockHistoryListAsync(OverdraftIncludeStockListRequest model)
    {
        var response = await _overdraftStockService.GetOverdraftIncludeStockHistoryListAsync(model);
        return Ok(response);
    }
}