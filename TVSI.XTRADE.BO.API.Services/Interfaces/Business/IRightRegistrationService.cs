namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IRightRegistrationService
{
    Task<Response<dynamic>> GetRightRegistrationListAsync(RightRegistrationListRequest model);
    Task<Response<dynamic>> GetRightRegistrationHistAsync(RightRegistrationHistRequest model);
    Task<ResponseSingle<dynamic>> GetRightRegistrationDetailAsync(long id);
    Task<Response<dynamic>> GetRightStockListAsync(RightStockListRequest model);
    Task<Response<int>> ChangeStatusRightRegistrationAsync(RightRegistrationStatusRequest model);
    Task<FileStream> ExportRightRegistrationListAsync(RightRegistrationListExportRequest model, string fileExportPath);
    Task<FileStream> ExportRightRegistrationHistAsync(RightRegistrationHistExportRequest model, string fileExportPath);
}