using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftService;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IOverdraftService
{
    Task<Response<dynamic>?> GetOverdraftServiceListAsync(OverdraftServiceListRequest model);
    Task<Response<int>> ModifyOverdraftServiceAsync(OverdraftServiceRequest model);
    Task<Response<int>> DeleteOverdraftServiceAsync(int id);
}