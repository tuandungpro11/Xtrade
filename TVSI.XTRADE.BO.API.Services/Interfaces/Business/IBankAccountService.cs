using TVSI.XTRADE.BO.API.Models.Model.Request.BankAccount;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IBankAccountService
{
    Task<Response<dynamic>> GetBankAccountListAsync(BankAccountListRequest model);
    Task<ResponseSingle<dynamic>> GetBankAccountDetailAsync(long bankAccountId);
    Task<Response<int>> CreateBankAccountAsync(BankAccountCreateRequest model);
    Task<Response<int>> UpdateBankAccountAsync(BankAccountUpdateRequest model);
    Task<Response<int>> ChangeStatusBankAccountAsync(BankAccountStatusRequest model);
}