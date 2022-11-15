using TVSI.XTRADE.BO.API.Models.Model.Request.FileAttach;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IFileAttachService
{
    Task<Response<dynamic>?> GetFileAttachListAsync(FileAttachListRequest model);
    Task<Response<long>> DeleteFileAttachAsync(long fileId, string loginName);
    Task<Response<long>> UploadFileAttachAsync(string customerId, string businessType, string files, string loginName);
}