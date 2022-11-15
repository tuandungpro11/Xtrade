using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

[ApiVersion("1.0")]
public class BankController : BaseController<BankController>
{
    private readonly IBankService _bankService;

    public BankController(ILogger<BankController> logger, IConfiguration config, IDetectionService detection, 
        IFileService fileService, IHostingEnvironment hostEnv, IBankService bankService)
        : base(logger, config, detection, fileService, hostEnv)
    {
        _bankService = bankService;
    }

    /// <summary>
    ///     Lấy danh sách ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Bank/GetBankList
    ///     {
    ///         "BankNo": "",
    ///         "BankName": "",
    ///         "BankNameEn": "",
    ///         "ShortName": "",
    ///         "Status": -1,
    ///         "Bankcheqcode": "",
    ///         "SecCode": "",
    ///         "SecCodeBranch": "",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    ///     
    ///     Status:
    ///         -1: Search all
    ///         0: Chưa kích hoạt
    ///         1: Kích hoạt
    /// </remarks>
    
    [HttpPost("GetBankList")]
    public async Task<IActionResult> GetBankListAsync(BankListRequest model)
    {
        var response = await _bankService.GetBankListAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy thông tin chi tiết ngân hàng
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Bank/GetBankDetail/123
    /// </remarks>
    
    [HttpPost("GetBankDetail/{id:int}")]
    public async Task<IActionResult> GetBankDetailAsync(int id)
    {
        var response = await _bankService.GetBankDetailAsync(id);
        return Ok(response);
    }

    /// <summary>
    ///     Thêm thông tin ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Bank/CreateBank
    ///     {
    ///         "BankNo": "111",
    ///         "BranchNo": "9999",
    ///         "BankName": "Tên ngân hàng",
    ///         "BankNameEn": "Tên ngân hàng En",
    ///         "ShortName": "Tên ngân hàng rút gọn",
    ///         "Bankcheqcode": "09",
    ///         "SecCode": "11",
    ///         "SecCodeBranch": "1",
    ///         "WithdrawAccount": "1",
    ///         "DepositAccount": "1",
    ///         "MinTradingCash": 1,
    ///         "MaxTradingCash": 10000000000,
    ///         "Status": 1,
    ///         "Remark": "",
    ///         "UserId": "hungnd",
    ///         "TransferFee": 50000
    ///     }
    /// </remarks>
    
    [HttpPost("CreateBank")]
    public async Task<IActionResult> CreateBankAsync(BankRequest model)
    {
        var response = await _bankService.ModifyBankAsync(model);
        return Ok(response);
    }


    /// <summary>
    ///     Cập nhật thông tin ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Bank/UpdateBank
    ///     {
    ///         "Id" : 9999
    ///         "BankNo": "111",
    ///         "BranchNo": "9999",
    ///         "BankName": "Tên ngân hàng",
    ///         "BankNameEn": "Tên ngân hàng En",
    ///         "ShortName": "Tên ngân hàng rút gọn",
    ///         "Bankcheqcode": "09",
    ///         "SecCode": "11",
    ///         "SecCodeBranch": "1",
    ///         "WithdrawAccount": "1",
    ///         "DepositAccount": "1",
    ///         "MinTradingCash": 1,
    ///         "MaxTradingCash": 10000000000,
    ///         "Status": 1,
    ///         "Remark": "",
    ///         "UserId": "hungnd",
    ///         "TransferFee": 50000
    ///     }
    /// </remarks>
    
    [HttpPost("UpdateBank")]
    public async Task<IActionResult> UpdateBankAsync(BankRequest model)
    {
        var response = await _bankService.ModifyBankAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Xóa thông tin ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Bank/DeleteBank
    ///     {
    ///         "Id": 126
    ///         "BankNo": "111"
    ///     }
    /// </remarks>
    
    [HttpPost("DeleteBank")]
    public async Task<IActionResult> DeleteBankAsync(BankDelRequest model)
    {
        var response = await _bankService.DeleteBankAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Export danh sách ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/Bank/ExportBankList
    ///     {
    ///         "BankNo": "",
    ///         "BankName": "",
    ///         "BankNameEn": "",
    ///         "ShortName": "",
    ///         "Status": -1,
    ///         "Bankcheqcode": "",
    ///         "SecCode": "",
    ///         "SecCodeBranch": ""
    ///     }
    ///     
    ///     Status:
    ///         -1: Search all
    ///         0: Chưa kích hoạt
    ///         1: Kích hoạt
    /// </remarks>
    
    [HttpPost("ExportBankList")]
    public async Task<IActionResult> ExportBankListAsync(BankExportRequest model)
    {
        var folderExportPath = GetFolderExportPath();
        var fileName = $"DS_NGAN_HANG_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
        var fileExportPath = Path.Combine(folderExportPath, fileName);

        var fs = await _bankService.ExportBankListAsync(model, fileExportPath);
        return File(fs, "application/octet-stream", fileName);
    }
}