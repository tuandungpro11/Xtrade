using TVSI.XTRADE.BO.API.Models.Model.Request.Stock;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IStockService
{
    Task<Response<dynamic>?> GetStockInfoDetailAsync(StockInfoRequest model);
}