using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class TrialAccountController : BaseController<TrialAccountController>
    {
        private readonly ITrialAccountService _trialAccountService;

        public TrialAccountController(ILogger<TrialAccountController> logger, IConfiguration config,
            IDetectionService detection, ITrialAccountService trialAccountService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _trialAccountService = trialAccountService;
        }

        /// <summary>
        ///     Lấy danh sách tài khoản trải nghiệm
        /// </summary>
        /// <param name="custCode"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/TrialAccount/GetTrialAccountList?custCode=000515&status=-1
        /// </remarks>
        
        [HttpPost("GetTrialAccountList")]
        public async Task<IActionResult> GetTrialAccountListAsync(string? custCode, int status)
        {
            var response = await _trialAccountService.GetTrialAccountListAsync(custCode, status);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy chi tiết tài khoản trải nghiệm
        /// </summary>
        /// <param name="custCode"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/TrialAccount/GetTrialAccountDetail/000515
        /// </remarks>
        
        [HttpPost("GetTrialAccountDetail/{custCode}")]
        public async Task<IActionResult> GetTrialAccountDetailAsync(string custCode)
        {
            var response = await _trialAccountService.GetTrialAccountDetailAsync(custCode);
            return Ok(response);
        }

        /// <summary>
        ///     Thêm thông tin tài khoản trải nghiệm
        /// </summary>
        /// <param name="custCode"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/TrialAccount/AddTrialAccount/005151
        /// </remarks>
        
        [HttpPost("AddTrialAccount/{custCode}")]
        public async Task<IActionResult> AddTrialAccountAsync(string custCode)
        {
            var response = await _trialAccountService.AddTrialAccountAsync(custCode);
            return Ok(response);
        }

        /// <summary>
        ///     Thay đổi trạng thái tài khoản trải nghiệm
        /// </summary>
        /// <param name="custCode"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/TrialAccount/ChangeActiveTrialAccount?custCode=000515&status=1
        /// </remarks>
        
        [HttpPost("ChangeActiveTrialAccount")]
        public async Task<IActionResult> ChangeActiveTrialAccountAsync(string custCode, int status)
        {
            var response = await _trialAccountService.ChangeActiveTrialAccountAsync(custCode, status);
            return Ok(response);
        }

        /// <summary>
        ///     Export danh sách tài khoản trải nghiệm
        /// </summary>
        /// <param name="custCode"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/TrialAccount/ExportTrialAccountList?custCode=000515&status=-1
        /// </remarks>
        
        [HttpPost("ExportTrialAccountList")]
        public async Task<IActionResult> ExportTrialAccountListAsync(string? custCode, int status)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"DS_DANG_KY_TRAI_NGHIEM_XTRADE_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _trialAccountService.ExportTrialAccountListAsync(custCode, status, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }
    }
}
