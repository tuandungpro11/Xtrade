using TVSI.XTRADE.BO.API.Models.Model.Request.BankAccount;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

[ApiVersion("1.0")]
public class BankAccountController : BaseController<BankAccountController>
{
    private readonly IBankAccountService _bankAccountService;

    public BankAccountController(ILogger<BankAccountController> logger, IConfiguration config,
        IDetectionService detection, IBankAccountService bankAccountService, IFileService fileService, IHostingEnvironment hostEnv)
        : base(logger, config, detection, fileService, hostEnv)
    {
        _bankAccountService = bankAccountService;
    }

    /// <summary>
    ///     Lấy danh sách tài khoản ngân hàng của khách hàng
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/BankAccount/GetBankAccountList
    ///     {
    ///         "UserId": "cuongnv3",
    ///         "CustomerId": "000515",
    ///         "BankAccountId": -1,
    ///         "BankAccount": "",
    ///         "IsLike": 1,
    ///         "Status": -2,
    ///         "ToDate": "",
    ///         "FromDate": "",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    /// 
    ///     Status:
    ///         -2: Search All
    ///         -1: Chờ Duyệt
    ///         2: Chờ HO xác nhận
    ///         3: CHờ KH xác nhận
    ///         1: KH đã kích hoạt
    ///         0: Ngừng sử dụng  --> kích hoạt lại thì chuyển sang trạng thái -1 để bắt đầu lại quy trình duyệt
    ///         4: Từ chối
    ///         5: KH hủy --> Chuyển từ trạng thái 3 nếu Từ chối
    ///
    ///     IsLike:
    ///         0: Tìm kiếm chính xác
    ///         1: Tìm kiếm gần đúng
    ///
    ///     Format Date: yyyyMMdd
    /// </remarks>
    [HttpPost("GetBankAccountList")]
    public async Task<IActionResult> GetBankAccountListAsync(BankAccountListRequest model)
    {
        var response = await _bankAccountService.GetBankAccountListAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy thông tin chi tiết tài khoản ngân hàng của khách hàng
    /// </summary>
    /// <param name="bankAccountId"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/BankAccount/GetBankAccountListById/1934
    /// </remarks>
    [HttpPost("GetBankAccountDetail/{bankAccountId:long}")]
    public async Task<IActionResult> GetBankAccountDetailAsync(long bankAccountId)
    {
        var response = await _bankAccountService.GetBankAccountDetailAsync(bankAccountId);
        return Ok(response);
    }

    /// <summary>
    ///     Thêm tài khoản ngân hàng cho khách hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    ///     Sample request:
    /// 
    ///         POST /api/BankAccount/CreateBankAccount
    ///         {
    ///             "BankAccount": "12345987451",
    ///             "CustomerId": "000515",
    ///             "Beneficiary": "Test",
    ///             "BankName": "",
    ///             "Province": "",
    ///             "Remark": "test",
    ///             "Priority": 0,
    ///             "Status": -1,
    ///             "URLPath": "",
    ///             "BankNo": "145",
    ///             "BranchNo": "002",
    ///             "UserId": "cuongnv3",
    ///             "BankType": 0
    ///         }
    ///
    ///     Status: mặc định = -1 (Chờ duyệt)
    /// </remarks>
    [HttpPost("CreateBankAccount")]
    public async Task<IActionResult> CreateBankAccountAsync(BankAccountCreateRequest model)
    {
        var response = await _bankAccountService.CreateBankAccountAsync(model);
        return Ok(response);
    }


    /// <summary>
    ///     Cập nhật thông tin tài khoản ngân hàng cho khách hàng
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    ///     Sample request:
    /// 
    ///         POST /api/BankAccount/UpdateBankAccount
    ///         {
    ///             "BankAccountId" : 1899
    ///             "BankAccount": "12345987451",
    ///             "CustomerId": "000515",
    ///             "Beneficiary": "Test",
    ///             "BankName": "",
    ///             "Province": "",
    ///             "Remark": "test",
    ///             "Priority": 0,
    ///             "Status": -1,
    ///             "Reason": "test update",
    ///             "URLPath": "",
    ///             "BankNo": "145",
    ///             "BranchNo": "002",
    ///             "UserId": "cuongnv3",
    ///             "BankType": 0
    ///         }
    /// </remarks>
    [HttpPost("UpdateBankAccount")]
    public async Task<IActionResult> UpdateBankAccountAsync(BankAccountUpdateRequest model)
    {
        var response = await _bankAccountService.UpdateBankAccountAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Phê duyệt thông tin tài khoản ngân hàng cho khách hàng
    /// </summary>
    /// 
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/BankAccount/ChangeStatusBankAccount
    ///     {
    ///         "BankAccountId": 1934,
    ///         "Status" : 3,
    ///         "Reason" : "Test",
    ///         "ModifiedBy" : "cuongnv3"
    ///     }
    /// </remarks>
    [HttpPost("ChangeStatusBankAccount")]
    public async Task<IActionResult> ChangeStatusBankAccountAsync(BankAccountStatusRequest model)
    {
        var response = await _bankAccountService.ChangeStatusBankAccountAsync(model);
        return Ok(response);
    }
}