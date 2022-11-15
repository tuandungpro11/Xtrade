using TVSI.XTRADE.BO.API.Models.Model.Request.BankBranch;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

[ApiVersion("1.0")]
public class BankBranchController : BaseController<BankBranchController>
{
    private readonly IBankBranchService _bankBranchService;

    public BankBranchController(ILogger<BankBranchController> logger, IConfiguration config, IDetectionService detection,
        IBankBranchService bankBranchService, IFileService fileService, IHostingEnvironment hostEnv)
        : base(logger, config, detection, fileService, hostEnv)
    {
        _bankBranchService = bankBranchService;
    }

    /// <summary>
    ///     Lấy danh sách chi nhánh ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/BankBranch/GetBankBranchList
    ///     {
    ///         "BankNo": "111",
    ///         "BranchNo": "",
    ///         "BranchName": "",
    ///         "BranchNameEn": "",
    ///         "ShortBranchName": "",
    ///         "Status": 1,
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    /// </remarks>
    
    [HttpPost("GetBankBranchList")]
    public async Task<IActionResult> GetBankBranchListAsync(BankBranchListRequest model)
    {
        var response = await _bankBranchService.GetBankBranchListAsync(model);
        return Ok(response);
    }


    /// <summary>
    ///     Thêm chi nhánh ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/BankBranch/CreateBankBranch
    ///     {
    ///         "BankNo": "111",
    ///         "BranchNo": "9999",
    ///         "BranchName": "Tên chi nhánh",
    ///         "BranchNameEn": "Tên chi nhánh En",
    ///         "ShortBranchName": "Tên chi nhánh rút gọn",
    ///         "Status": 1,
    ///         "Remark": "",
    ///         "UserId": "hungnd"
    ///     }
    /// </remarks>
    
    [HttpPost("CreateBankBranch")]
    public async Task<IActionResult> CreateBankBranchAsync(BankBranchRequest model)
    {
        var response = await _bankBranchService.ModifyBankBranchAsync(model);
        return Ok(response);
    }


    /// <summary>
    ///     Cập nhật thông tin chi nhánh ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/BankBranch/UpdateBankBranch
    ///     {
    ///         "Id": 126,
    ///         "BankNo": "111",
    ///         "BranchNo": "9999",
    ///         "BranchName": "Tên chi nhánh",
    ///         "BranchNameEn": "Tên chi nhánh En",
    ///         "ShortBranchName": "Tên chi nhánh rút gọn",
    ///         "Status": 1,
    ///         "Remark": "",
    ///         "UserId": "hungnd"
    ///     }
    /// </remarks>
    
    [HttpPost("UpdateBankBranch")]
    public async Task<IActionResult> UpdateBankBranchAsync(BankBranchRequest model)
    {
        var response = await _bankBranchService.ModifyBankBranchAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Xóa chi nhánh ngân hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/BankBranch/DeleteBankBranch
    ///     {
    ///         "Id": 126
    ///         "BankNo": "111",
    ///         "BranchNo": "",
    ///     }
    /// </remarks>
    
    [HttpPost("DeleteBankBranch")]
    public async Task<IActionResult> DeleteBankBranchAsync(BankBranchDelRequest model)
    {
        var response = await _bankBranchService.DeleteBankBranchAsync(model);
        return Ok(response);
    }
}