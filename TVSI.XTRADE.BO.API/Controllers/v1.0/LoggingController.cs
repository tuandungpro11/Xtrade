using TVSI.XTRADE.BO.API.Models.Model.Request.Logging;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class LoggingController : BaseController<LoggingController>
    {
        private readonly ILoggingService _loggingService;

        public LoggingController(ILogger<LoggingController> logger, IConfiguration config,
            IDetectionService detection, ILoggingService loggingService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _loggingService = loggingService;
        }

        /// <summary>
        ///     Lấy danh sách log login từ iTrade-Home (innoDB)
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Logging/GetLogLoginITradeHomeList
        ///     {
        ///         "Status": 1,
        ///         "Channel": "",
        ///         "CustomerId": "",
        ///         "BeginDate": "20210601",
        ///         "EndDate": "20221219",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Status:
        ///         -1: Search all
        ///         1: Đăng nhập chưa thoát
        ///         2: Đăng nhập đã thoát
        ///         3: Đăng nhập hết giờ
        ///         4: Đăng nhập bị NV kích
        /// 
        ///     Channel:
        ///         "": Search all
        ///         "B": Counter/Broker
        ///         "M": TVSI Mobile
        ///         "S": Core
        ///         "W": iTrade-Home  
        /// 
        ///     Format Date: yyyyMMdd
        /// </remarks>

        
        [HttpPost("GetLogLoginITradeHomeList")]
        public async Task<IActionResult> GetLogLoginITradeHomeListAsync(LogLoginInnoRequest model)
        {
            var response = await _loggingService.GetLogLoginITradeHomeListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy danh sách log login từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Logging/GetLogLoginList
        ///     {
        ///         "UserId": "000131",
        ///         "ControllerName": "",
        ///         "ActionName": "",
        ///         "ClientIP": "",
        ///         "Method": "",
        ///         "FromDate": "01/06/2000",
        ///         "ToDate": "24/08/2022",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>

        
        [HttpPost("GetLogLoginList")]
        public async Task<IActionResult> GetLogLoginListAsync(LogLoginPasiotRequest model)
        {
            var response = await _loggingService.GetLogLoginListAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy thông tin chi tiết log login từ Pasiot Api
        /// </summary>
        /// <param name="traceId"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Logging/GetLogLoginDetail/4402fb72dcef4928a65344af2d0252c3
        /// </remarks>

        
        [HttpPost("GetLogLoginDetail/{traceId}")]
        public async Task<IActionResult> GetLogLoginDetailAsync(string traceId)
        {
            var response = await _loggingService.GetLogLoginDetailAsync(traceId);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Export danh sách log login từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Logging/ExportLogLoginList
        ///     {
        ///         "UserId": "000131",
        ///         "ControllerName": "",
        ///         "ActionName": "",
        ///         "ClientIP": "",
        ///         "Method": "",
        ///         "FromDate": "01/06/2000",
        ///         "ToDate": "24/08/2022"
        ///     }
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>

        
        [HttpPost("ExportLogLoginList")]
        public async Task<IActionResult> ExportLogLoginListAsync(LogLoginPasiotExportRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"NHAT_KY_DANG_NHAP_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _loggingService.ExportLogLoginListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }

        /// <summary>
        ///     Lấy danh sách log system
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Logging/GetLogSystemList
        ///     {
        ///         "UserId": "",
        ///         "CustomerId": "",
        ///         "ActionType": -1,
        ///         "BranchId": "",
        ///         "BeginDate": "20210601",
        ///         "EndDate": "20221219",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     } 
        /// 
        ///     Format Date: yyyyMMdd
        /// </remarks>

        
        [HttpPost("GetLogSystemList")]
        public async Task<IActionResult> GetLogSystemListAsync(LogSystemRequest model)
        {
            var response = await _loggingService.GetLogSystemListAsync(model);
            return Ok(response);
        }
    }
}
