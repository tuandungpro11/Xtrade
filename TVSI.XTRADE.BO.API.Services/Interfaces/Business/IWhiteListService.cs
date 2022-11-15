using TVSI.XTRADE.BO.API.Models.Model.Request.WhiteList;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface IWhiteListService
    {

        Task<Response<dynamic>?> GetWhiteListAsync(WhiteListRequest model);
        Task<Response<int>> ModifyWhiteListAsync(WhiteListModifyRequest model);
        Task<Response<int>> DeleteWhiteListAsync(WhiteListDelRequest model);
    }
}
