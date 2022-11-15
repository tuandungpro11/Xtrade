using Microsoft.AspNetCore.Http;
using TVSI.XTRADE.BO.API.Models.Model.Request.Stock;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface IExceptionStockService
    {
        Task<Response<dynamic>?> GetExceptionStockListAsync(ExceptionStockListRequest model);
        Task<Response<dynamic>?> GetStockInfoDetailAsync(StockInfoRequest model);
        Task<Response<int>> CreateExceptionStockAsync(ModifyExceptionStock model);
        Task<Response<int>> UpdateExceptionStockAsync(ModifyExceptionStock model);
        Task<Response<int>> DeleteExceptionStockAsync(DeleteExceptionStockRequest model);
        Task<Response<ModifyExceptionStock>> ImportExceptionStockFromFileExcelAsync(IFormFile formFile, CancellationToken cancellationToken);
        Task<FileStream> ExportExceptionStockListAsync(ExceptionStockListExportRequest model, string fileExportPath);
    }
}
