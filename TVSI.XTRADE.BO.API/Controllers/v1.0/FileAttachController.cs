using System.Globalization;
using TVSI.XTRADE.BO.API.Models.Model.Request.FileAttach;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0;

public class FileAttachController : BaseController<FileAttachController>
{
    private readonly IFileAttachService _fileAttachService;

    public FileAttachController(ILogger<FileAttachController> logger, IConfiguration config,
        IDetectionService detection, IFileAttachService fileAttachService, IFileService fileService,
        IHostingEnvironment hostEnv)
        : base(logger, config, detection, fileService, hostEnv)
    {
        _fileAttachService = fileAttachService;
    }

    /// <summary>
    ///     Lấy danh sách file attach
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/FileAttach/GetFileAttachList
    ///     {
    ///         "customerId": "000515",
    ///         "businessType": "INTERNAL_ACCOUNT",
    ///         "pageIndex": 1,
    ///         "pageSize": 20
    ///     }
    ///
    ///     businessType:
    ///         INTERNAL_ACCOUNT: Tài khoản chuyển tiền nội bộ
    ///         BANK_ACCOUNT: Tài khoản ngân hàng
    /// </remarks>
    [HttpPost("GetFileAttachList")]
    public async Task<IActionResult> GetFileAttachListAsync(FileAttachListRequest model)
    {
        var response = await _fileAttachService.GetFileAttachListAsync(model);
        return Ok(response);
    }
    /// <summary>
    ///     Xóa thông tin file attach
    /// </summary>
    /// <param name="fileId"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/FileAttach/DeleteFileAttach/57
    /// </remarks>

    [HttpPost("DeleteFileAttach/{fileId:long}")]
    public async Task<IActionResult> DeleteFileAttachAsync(long fileId)
    {
        var response = await _fileAttachService.DeleteFileAttachAsync(fileId, GetLoginName());
        return Ok(response);
    }

    /// <summary>
    ///     Upload file attach.
    /// </summary>
    /// <returns></returns>
    [HttpPost("UploadFileAttach")]
    public async Task<IActionResult> UploadFileAttachAsync(List<IFormFile> files, string customerId, string businessType)
    {
        var rootPath = _hostEnv.ContentRootPath;
        var fileUploads  = _fileService.UploadFile(files, rootPath,$"{_config["File:AttachPath"]}{businessType}", DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"));

        var response = await _fileAttachService.UploadFileAttachAsync(customerId, businessType, fileUploads, GetLoginName());
        return Ok(response);
    }

    /// <summary>
    ///     Download file attach.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    /// /// <remarks>
    /// Sample request:
    /// 
    ///     POST /api/FileAttach/DownloadFileAttach
    ///     {
    ///         "fileUrl": "files/attach/bank_account/tui_essential_crossbody_djen_dv2400_01_standard.jpg",
    ///         "businessType": "INTERNAL_ACCOUNT"
    ///     }
    /// </remarks>
    [HttpPost("DownloadFileAttach")]
    public async Task<IActionResult> DownloadFileAttachAsync(FileAttachDownloadRequest model)
    {
        var rootPath = _hostEnv.ContentRootPath;
        var fileName = model.FileUrl?.Split("/").LastOrDefault() ?? string.Empty;
        var memoryStream = await _fileService.DownloadFileAsync(rootPath, $"{_config["File:AttachPath"]}{model.BusinessType}", fileName);

        return File(memoryStream, "application/octet-stream", fileName);
    }
}