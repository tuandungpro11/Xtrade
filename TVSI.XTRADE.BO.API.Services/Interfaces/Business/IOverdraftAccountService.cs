using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftAccount;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IOverdraftAccountService
{
    Task<Response<dynamic>?> GetOverdraftAccountListAsync(OverdraftAccountListRequest model);
    Task<Response<int>> ModifyOverdraftAccountAsync(OverdraftAccountRequest model);
    Task<Response<int>> DeleteOverdraftAccountAsync(int id);
}