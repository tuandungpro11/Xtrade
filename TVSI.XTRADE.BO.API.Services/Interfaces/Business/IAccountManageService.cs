using TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IAccountManageService
{
    Task<Response<T>> GetCustomerAccountListAsync<T>(CustomerAccountListRequest model);
    Task<ResponseSingle<T>> GetCustomerInfoByIdAsync<T>(string customerId);
    Task<ResponseSingle<T>> GetCustomerInfoByAccountNoAsync<T>(string accountNo);
    Task<Response<T>> GetAccountListAsync<T>(AccountListRequest model);
    Task<Response<T>> GetTvsiBranchListAsync<T>(BranchListRequest model);
    Task<Response<int>> UpdateCustomerAccountAsync(CustomerAccountRequest model);
    Task<Response<int>> ChangeActiveCustomerAccountAsync(AccountChangeActiveRequest model);
    Task<Response<T>> GetCustomerEmailListAsync<T>(CustomerEmailListRequest model);
    Task<Response<int>> RegisterEmailServiceAsync(RegisterEmailServiceRequest model);
    Task<Response<int>> DeleteCustomerEmailAsync(int id);
    Task<Response<T>> GetCustomerPhoneListAsync<T>(CustomerPhoneListRequest model);
    Task<Response<int>> RegisterPhoneServiceAsync(RegisterPhoneServiceRequest model);
    Task<Response<int>> DeleteCustomerPhoneAsync(int id);
    Task<ResponseSingle<dynamic>> ResetPinPasswordAsync(ResetPinPasswordRequest model);
    Task<Response<int>> ReactiveCustomerAsync(ReactiveCustomerRequest model);
}