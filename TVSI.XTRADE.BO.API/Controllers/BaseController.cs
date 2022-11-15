using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public abstract class BaseController<T> : ControllerBase where T : class
{
    protected readonly IHostingEnvironment _hostEnv;
    protected readonly IConfiguration _config;
    protected readonly IDetectionService _detection;
    protected readonly ILogger<T> _logger;
    protected readonly IFileService _fileService;

    protected BaseController(ILogger<T> logger, IConfiguration config, IDetectionService detection, IFileService fileService, IHostingEnvironment hostEnv)
    {
        _hostEnv = hostEnv;
        _logger = logger;
        _config = config;
        _detection = detection;
        _fileService = fileService;
    }

    protected string? GetLoginName()
    {
        var loginName = HttpContext.User.Claims.FirstOrDefault(c =>
            c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
        return loginName ?? "system";
    }

    protected string GetFolderExportPath()
    {
        var rootPath = _hostEnv.ContentRootPath;
        var folderExportPath = Path.Combine(rootPath, _config["File:ExportPath"]);
        if (!Directory.Exists(folderExportPath))
        {
            Directory.CreateDirectory(folderExportPath);
        }
        else
        {
           _fileService.DeleteFile(folderExportPath, $"*{DateTime.Now:yyyyMMdd}*.xlsx", true, false);
        }

        return folderExportPath;
    }
}