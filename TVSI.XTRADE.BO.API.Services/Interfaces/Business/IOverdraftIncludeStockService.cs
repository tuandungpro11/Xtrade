using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftIncludeStock;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface IOverdraftIncludeStockService
    {
        Task<Response<dynamic>?> GetOverdraftIncludeStockListAsync(OverdraftIncludeStockListRequest model);
        Task<Response<int>> ModifyOverdraftIncludeStockAsync(OverdraftIncludeStockRequest model);
        Task<Response<int>> DeleteOverdraftIncludeStockAsync(int id);
        Task<Response<dynamic>?> GetOverdraftIncludeStockHistoryListAsync(OverdraftIncludeStockListRequest model);
    }
}
