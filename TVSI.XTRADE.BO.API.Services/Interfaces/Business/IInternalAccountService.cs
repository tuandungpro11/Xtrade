namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IInternalAccountService
{
    Task<Response<dynamic>> GetInternalAccountListAsync(InterAccListRequest model);
    Task<ResponseSingle<dynamic>> GetInternalAccountDetailAsync(InterAccDelRequest model);
    Task<Response<int>> ModifyInternalAccountAsync(InterAccRequest model);
    Task<Response<int>> DeleteInternalAccountAsync(InterAccDelRequest model);
    Task<Response<int>> ChangeStatusInternalAccountAsync(InterAccStatusRequest model);
    Task<FileStream> ExportInternalAccountListAsync(InterAccListExportRequest model, string fileExportPath);
}