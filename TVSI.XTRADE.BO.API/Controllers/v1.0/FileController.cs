using TVSI.XTRADE.BO.API.Models.Enums;
using TVSI.XTRADE.BO.API.Services.Interfaces.Core;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class FileController : BaseController<FileController>
    {
        private readonly IAuthService _authService;
        private readonly IFileService _fileService;
        private readonly IHostingEnvironment _env;

        public FileController(ILogger<FileController> logger, IConfiguration config, IDetectionService detection, 
            IAuthService authService, IFileService fileService, IHostingEnvironment env)
            : base(logger, config, detection)
        {
            _authService = authService;
            _fileService = fileService;
            _env = env;
        }

        /// <summary>
        /// Export data to excel file.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("ExportToExcel")]
        public async Task<IActionResult> ExportToExcel(Request<dynamic> model, CancellationToken cancellationToken)
        {
            var rootPath = _env.ContentRootPath;
            var folderExportPath = Path.Combine(rootPath, "Files/Export");
            var fileName = $"{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);


            //var result = await _gatewayService.AdoGatewayDynamicStoredAsync(model);
            var result = new Response<dynamic>();
            if (result.Code != "1")
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, result);
                return File(new FileStream(fileExportPath, FileMode.Open, FileAccess.Read), "application/octet-stream", fileName);
            }

            var ds = result.Data;
            if (ds is null)
            {
                var message = (new Response<dynamic>()
                {
                    Code = ((int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                    Message = "Data not found.",
                    Data = null,
                });

                _fileService.ExportErrorMessageToFile(fileExportPath, message);
                return File(new FileStream(fileExportPath, FileMode.Open, FileAccess.Read), "application/octet-stream", fileName);
            }

            ds.Tables[0].TableName = "INFO";
            ds.Tables[1].TableName = "DATA";

            var templatePath = ds.Tables[0].Rows[0]["X_TEMPLATE_FILE"].ToString();
            if (string.IsNullOrWhiteSpace(templatePath))
            {
                var message = (new Response<dynamic>()
                {
                    Code = ((int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                    Message = "Chưa cấu hình file template.",
                    Data = null,
                });

                _fileService.ExportErrorMessageToFile(fileExportPath, message);
                return File(new FileStream(fileExportPath, FileMode.Open, FileAccess.Read), "application/octet-stream", fileName);
            }


            if (!System.IO.File.Exists(templatePath))
            {
                var message = (new Response<dynamic>()
                {
                    Code = ((int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                    Message = "Không tìm thấy file template.",
                    Data = null,
                });

                _fileService.ExportErrorMessageToFile(fileExportPath, message);
                return File(new FileStream(fileExportPath, FileMode.Open, FileAccess.Read), "application/octet-stream", fileName);
            }

            if (!Directory.Exists(folderExportPath))
            {
                Directory.CreateDirectory(folderExportPath);
            }
            else
            {
                for (var i = 1; i <= 7; i++)
                {
                    _fileService.DeleteFile(folderExportPath, $"*{DateTime.Now.AddDays(-i):yyyyMMdd}*.xlsx");
                }
            }

            _fileService.ExportDataToFileTemplate(fileExportPath, templatePath, ds, new[] { "{", "}" });

            var fs = new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            return File(fs, "application/octet-stream", fileName);
        }
    }
}
