using TVSI.XTRADE.BO.API.Models.Model.Request.Logging;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface ILoggingService
{
    Task<Response<dynamic>> GetLogLoginITradeHomeListAsync(LogLoginInnoRequest model);
    Task<ResponsePartner> GetLogLoginListAsync(LogLoginPasiotRequest model);
    Task<ResponsePartner> GetLogLoginDetailAsync(string traceId);
    Task<FileStream> ExportLogLoginListAsync(LogLoginPasiotExportRequest model, string fileExportPath);
    Task<Response<dynamic>> GetLogSystemListAsync(LogSystemRequest model);
}