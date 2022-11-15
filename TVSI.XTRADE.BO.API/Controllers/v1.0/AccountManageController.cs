using TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage;
using TVSI.XTRADE.BO.API.Models.Model.Response.AccountManage;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

[ApiVersion("1.0")]
public class AccountManageController : BaseController<AccountManageController>
{
    private readonly IAccountManageService _accountManageService;

    public AccountManageController(ILogger<AccountManageController> logger, IConfiguration config,
        IDetectionService detection, IAccountManageService accountManageService, IFileService fileService, IHostingEnvironment hostEnv)
        : base(logger, config, detection, fileService, hostEnv)
    {
        _accountManageService = accountManageService;
    }

    /// <summary>
    ///     Lấy danh sách tài khoản khách hàng (Customer account)
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/GetCustomerAccountList
    ///     {
    ///         "UserId": "",
    ///         "CustomerId": "",
    ///         "Status": -1,
    ///         "BranchId": "",
    ///         "CustomerType": -1,
    ///         "CustomerGroupId": -1,
    ///         "IsLike": 1,
    ///         "BeginDate": "",
    ///         "EndDate": "",
    ///         "ByUser": "",
    ///         "IdentityCard": "",
    ///         "CustomerName": "",
    ///         "Phone": "",
    ///         "Email": "",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    /// 
    ///     Status:
    ///         -1: Search all
    ///         -2: Chưa kích hoạt
    ///         0: Khóa bởi nhân viên
    ///         1: Kích hoạt
    /// 
    ///     CustomerType:
    ///         -1: Search all
    ///         0: Nhà đầu tư
    ///         1: Đại lý chính thức
    ///         2: Đại lý tự do
    ///         3: Đại lý tự doanh
    ///
    ///     IsLike:
    ///         0: Tìm kiếm chính xác
    ///         1: Tìm kiếm gần đúng
    ///
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("GetCustomerAccountList")]
    public async Task<IActionResult> GetCustomerAccountListAsync(CustomerAccountListRequest model)
    {
        var response = await _accountManageService.GetCustomerAccountListAsync<dynamic>(model);
        return Ok(response);
    }


    /// <summary>
    ///     Lấy thông tin tài khoản khách hàng (Customer account)
    /// </summary>
    /// <param name="customerId"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/GetCustomerById/000515
    /// </remarks>
    
    [HttpPost("GetCustomerInfoById/{customerId}")]
    public async Task<IActionResult> GetCustomerDetailAsync(string customerId)
    {
        var response = await _accountManageService.GetCustomerInfoByIdAsync<dynamic>(customerId);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy thông tin tài khoản khách hàng (Customer account) theo AccountNo
    /// </summary>
    /// <param name="accountNo"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/GetCustomerInfoByAccountNo/0005151
    /// </remarks>
    
    [HttpPost("GetCustomerInfoByAccountNo/{accountNo}")]
    public async Task<IActionResult> GetCustomerInfoByAccountNoAsync(string accountNo)
    {
        var response = await _accountManageService.GetCustomerInfoByAccountNoAsync<dynamic>(accountNo);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy danh sách tiểu khoản của khách hàng (SubAccount)
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/GetAccountList
    ///     {
    ///         "CustomerId": "000515"
    ///     }
    /// </remarks>
    
    [HttpPost("GetAccountList")]
    public async Task<IActionResult> GetAccountListAsync(AccountListRequest model)
    {
        var response = await _accountManageService.GetAccountListAsync<dynamic>(model);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy danh sách chi nhánh của công ty chứng khoán TVSI
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/GetTvsiBranchList
    ///     {
    ///         "BranchId": "",
    ///         "Active": -1,
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    /// 
    ///     BranchId:
    ///         "": Tất cả
    /// 
    ///     Active:
    ///         -1: Tất cả
    ///         0: Inactive
    ///         1: Active
    /// </remarks>
    
    [HttpPost("GetTvsiBranchList")]
    public async Task<IActionResult> GetTvsiBranchListAsync(BranchListRequest model)
    {
        var response = await _accountManageService.GetTvsiBranchListAsync<dynamic>(model);
        return Ok(response);
    }

    /// <summary>
    ///     Cập nhật thông tin của tài khoản khách hàng
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/UpdateCustomerAccount
    ///     {
    ///         "UserId": "cuongnv3",
    ///         "CustomerId": "000515",
    ///         "CustomerNo": "044C000515",
    ///         "CustomerName": "Mr. Nguyễn Minh Dương",
    ///         "AuthType": 1,
    ///         "IdentityCard": "012458320",
    ///         "Address": "Tây Trúc, Ấn Độ",
    ///         "Email": "",
    ///         "Phone": "",
    ///         "CellPhone": "0983981510111",
    ///         "Status": 1,
    ///         "AgentType": 1,
    ///         "CustomerType": 1,
    ///         "CustomerGroupId": 3,
    ///         "TotalPoint": 0,
    ///         "BranchID": "09",
    ///         "ContactEmail": "duongnm@tvsi.com.vn",
    ///         "ContactPhone": "0983981410",
    ///         "IsDefault": 0,
    ///         "DefaultAccount": Null,
    ///         "PickAccount": "0005151",
    ///         "Custodian": "",
    ///         "MktId": "6240",
    ///         "PcFlag": "",
    ///         "CreditType": "N",
    ///         "BirthDay": Null,
    ///         "Sex": "",
    ///         "CardIssue": Null,
    ///         "PlaceIssue": "",
    ///         "Occupation": "",
    ///         "Nationality": "",
    ///         "Remark": "",
    ///         "TaxCode": ""
    ///     }
    /// 
    ///     Status:
    ///         0: Chưa kích hoạt
    ///         1: Kích hoạt
    /// 
    ///     CustomerType:
    ///         0: Nhà đầu tư (AgentType = 0)
    ///         1: Đại lý
    /// 
    ///     AgentType:
    ///         1: Đại lý chính thức
    ///         2: Đại lý tự do
    ///         3: Đại lý tự doanh
    ///
    /// </remarks>
    [HttpPost("UpdateCustomerAccount")]
    public async Task<IActionResult> UpdateCustomerAccountAsync(CustomerAccountRequest model)
    {
        var response = await _accountManageService.UpdateCustomerAccountAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Thay đổi trọng thái Active của tài khoản khách hàng
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/ChangeActiveCustomerAccount
    ///     {
    ///         "UserId": "cuongnv3",
    ///         "CustomerId": "000515",
    ///         "Status": 1,
    ///     }
    ///
    ///     Status:
    ///         0: Inactive
    ///         1: Active
    /// </remarks>
    [HttpPost("ChangeActiveCustomerAccount")]
    public async Task<IActionResult> ChangeActiveCustomerAccountAsync(AccountChangeActiveRequest model)
    {
        var response = await _accountManageService.ChangeActiveCustomerAccountAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy danh sách email của khách hàng
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/GetCustomerEmailList
    ///     {
    ///         "CustomerId": "000515",
    ///         "IsActive": -1,
    ///         "Email": "",
    ///         "FromDate": "",
    ///         "ToDate": "",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    ///
    ///     IsActive:
    ///         -1: Search all
    ///         0: Inactive
    ///         1: Active
    ///
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("GetCustomerEmailList")]
    public async Task<IActionResult> GetCustomerEmailListAsync(CustomerEmailListRequest model)
    {
        var response = await _accountManageService.GetCustomerEmailListAsync<dynamic>(model);
        return Ok(response);
    }

    /// <summary>
    ///     Đăng ký email sử dụng dịch vụ
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/RegisterEmailService
    ///     {
    ///         "Id": 3291,
    ///         "CustomerId": "000515",
    ///         "Email": "service@tvsi.com.vn",
    ///         "IsKQGD": 1,
    ///         "IsQC": 0,
    ///         "IsActive": 1
    ///     }
    ///
    ///     IsActive:
    ///         -1: Search all
    ///         0: Inactive
    ///         1: Active
    ///
    /// </remarks>
    [HttpPost("RegisterEmailService")]
    public async Task<IActionResult> RegisterEmailServiceAsync(RegisterEmailServiceRequest model)
    {
        var response = await _accountManageService.RegisterEmailServiceAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Xóa email của khách hàng
    /// </summary>
    /// <param name="id"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/DeleteCustomerEmail/8710
    /// </remarks>
    [HttpPost("DeleteCustomerEmail/{id:int}")]
    public async Task<IActionResult> DeleteCustomerEmailAsync(int id)
    {
        var response = await _accountManageService.DeleteCustomerEmailAsync(id);
        return Ok(response);
    }

    /// <summary>
    ///     Lấy danh sách sđt của khách hàng
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/GetCustomerPhoneList
    ///     {
    ///         "CustomerId": "000515",
    ///         "IsActive": -1,
    ///         "Phone": "",
    ///         "FromDate": "",
    ///         "ToDate": "",
    ///         "PageIndex": 1,
    ///         "PageSize": 20
    ///     }
    ///
    ///     IsActive:
    ///         -1: Search all
    ///         0: Inactive
    ///         1: Active
    ///
    ///     Format Date: yyyyMMdd
    /// </remarks>
    
    [HttpPost("GetCustomerPhoneList")]
    public async Task<IActionResult> GetCustomerPhoneListAsync(CustomerPhoneListRequest model)
    {
        var response = await _accountManageService.GetCustomerPhoneListAsync<dynamic>(model);
        return Ok(response);
    }


    /// <summary>
    ///     Đăng ký sđt sử dụng dịch vụ
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/RegisterPhoneService
    ///     {
    ///         "Id": 3291,
    ///         "CustomerId": "000515",
    ///         "Phone": "0979797979",
    ///         "IsSMS": 1,
    ///         "IsCC": 0,
    ///         "IsActive": 1
    ///     }
    ///
    ///     IsActive:
    ///         -1: Search all
    ///         0: Inactive
    ///         1: Active
    /// </remarks>
    [HttpPost("RegisterPhoneService")]
    public async Task<IActionResult> RegisterPhoneServiceAsync(RegisterPhoneServiceRequest model)
    {
        var response = await _accountManageService.RegisterPhoneServiceAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Xóa sđt của khách hàng
    /// </summary>
    /// <param name="id"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/DeleteCustomerPhone/8710
    /// </remarks>
    [HttpPost("DeleteCustomerPhone/{id:int}")]
    public async Task<IActionResult> DeleteCustomerPhoneAsync(int id)
    {
        var response = await _accountManageService.DeleteCustomerPhoneAsync(id);
        return Ok(response);
    }

    /// <summary>
    ///     Reset thông tin Pin, Pass của tài khoản
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/ResetPinPassword
    ///     {
    ///         "CustomerId": "999999",
    ///         "SendSMS": 1,
    ///         "ChangeType": 0
    ///     }
    ///
    ///     SendSMS:
    ///         0: Không gửi SMS (mặc định chỉ gửi email)
    ///         1: Gửi SMS
    /// 
    ///     ChangeType:
    ///         0: reset Password
    ///         1: reset Pin
    ///         2: reset cả hai thông tin
    ///         
    /// </remarks>
    [HttpPost("ResetPinPassword")]
    public async Task<IActionResult> ResetPinPassword(ResetPinPasswordRequest model)
    {
        var response = await _accountManageService.ResetPinPasswordAsync(model);
        return Ok(response);
    }

    /// <summary>
    ///     Kích hoạt lại tài khoản (reset Pin, Pass)
    /// </summary>
    /// <param name="model"></param>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/AccountManage/ReactiveCustomer
    ///     {
    ///         "CustomerId": "999999",
    ///         "Email": "abc@gmail.com",
    ///         "FullName": "Nguyễn Văn A"
    ///     }
    /// </remarks>
    [HttpPost("ReactiveCustomer")]
    public async Task<IActionResult> ReactiveCustomerAsync(ReactiveCustomerRequest model)
    {
        var response = await _accountManageService.ReactiveCustomerAsync(model);
        return Ok(response);
    }
}