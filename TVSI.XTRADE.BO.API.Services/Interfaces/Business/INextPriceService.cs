using Microsoft.AspNetCore.Http;
using TVSI.XTRADE.BO.API.Models.Model.Request.NextPrice;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface INextPriceService
{
    Task<Response<dynamic>?> GetNextPriceListAsync(NextPriceListRequest model);
    Task<Response<int>> CreateNextPriceAsync(NextPriceRequest model, string loginName);
    Task<Response<int>> UpdateNextPriceAsync(NextPriceRequest model, string loginName);
    Task<Response<int>> DeleteNextPriceAsync(string symbol);
    Task<Response<int>> CalculateAgainNextPriceAsync(CalculateNextPriceRequest model);
    Task<Response<NextPriceRequest>> ImportNextPriceFromFileExcelAsync(IFormFile formFile, CancellationToken cancellationToken, string loginName);
    Task<FileStream> ExportNextPriceListAsync(NextPriceListExportRequest model, string fileExportPath);
}