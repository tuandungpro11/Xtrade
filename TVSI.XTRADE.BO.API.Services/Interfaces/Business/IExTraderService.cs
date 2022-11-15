using TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface IExTraderService
    {
        Task<Response<dynamic>> GetExTraderListAsync(ExTraderListRequest model);
        Task<Response<int>> CreateExTraderAsync(ExTraderCreateRequest model);
        Task<Response<int>> UpdateExTraderAsync(ExTraderUpdateRequest model);
        Task<Response<int>> DeleteExTraderAsync(long traderId);
        Task<Response<dynamic>> CheckExTraderAsync(ExTraderCheckRequest model);
        Task<Response<int>> CreateLogExTraderAsync(ExTraderLogRequest model);
        Task<FileStream> ExportExTraderListAsync(ExTraderListExportRequest model, string fileExportPath);
    }
}
