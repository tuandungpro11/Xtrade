using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.SysConfig;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class SysConfigController : BaseController<SysConfigController>
    {
        private readonly ISysConfigService _sysConfigService;

        public SysConfigController(ILogger<SysConfigController> logger, IConfiguration config, IDetectionService detection,
            ISysConfigService sysConfigService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _sysConfigService = sysConfigService;
        }


        /// <summary>
        ///     Lấy danh sách thông tin cấu hình hệ thống
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SysConfig/GetSysConfigList
        ///     {
        ///         "Category": "INTERNAL_ACCOUNT",
        ///         "Group": "STATUS",
        ///         "Code": ""
        ///     }
        /// </remarks>
        
        [HttpPost("GetSysConfigList")]
        public async Task<IActionResult> GetSysConfigListAsync(SysConfigListRequest model)
        {
            var response = await _sysConfigService.GetSysConfigListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy danh sách thông tin cấu hình hệ thống nghiệp vụ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SysConfig/GetConfigurationList
        ///     {
        ///         "Name": "all",
        ///         "PageIndex": 0,
        ///         "PageSize": 0
        ///     }
        /// </remarks>
        
        [HttpPost("GetConfigurationList")]
        public async Task<IActionResult> GetConfigurationListAsync(ConfigurationListRequest model)
        {
            var response = await _sysConfigService.GetConfigurationListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Cập nhật thông tin cấu hình hệ thống nghiệp vụ
        /// </summary>
        /// <param name="jsonData"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SysConfig/UpdateConfigurationList
        ///     {
        ///         "jsonData": "{\"PointValue\":\"100\",\"AdvTax\":\"0.2\",\"AdvMinFee\":\"100000\",\"AdvFeeRatio\":\"0.01\",\"AdvLoanRatio\":\"100\"}"
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateConfigurationList")]
        public async Task<IActionResult> UpdateConfigurationListAsync(ConfigurationJsonRequest? jsonData)
        {
            var json = jsonData != null ? jsonData.JsonData : "{}";
            var response = await _sysConfigService.UpdateConfigurationListAsync(json);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy danh sách kênh giao dịch
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SysConfig/GetAllChannel
        /// </remarks>
        
        [HttpPost("GetAllChannel")]
        public async Task<IActionResult> GetAllChannelAsync()
        {
            var response = await _sysConfigService.GetAllChannelAsync();
            return Ok(response);
        }

        /// <summary>
        ///     Cập nhật thông tin phí/thuế giao dịch theo kênh giao dịch
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SysConfig/UpdateFeeTaxChannel
        ///     {
        ///         "Id": 1,
        ///         "FeeRatio": 0.3,
        ///         "MinFee": 100
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateFeeTaxChannel")]
        public async Task<IActionResult> UpdateFeeTaxChannelAsync(FeeTaxChannelRequest model)
        {
            var response = await _sysConfigService.UpdateFeeTaxChannelAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy danh sách thông tin cảnh báo
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SysConfig/GetNotifierList
        ///     {
        ///         "CustomerId": "",
        ///         "AccountNo": "",
        ///         "NotifyAction": -1,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     NotifyAction:
        ///         -1: Tất cả
        ///         2: Giá chứng khoán
        ///         3: Chỉ số thị trường
        /// </remarks>
        
        [HttpPost("GetNotifierList")]
        public async Task<IActionResult> GetNotifierListAsync(NotifierListRequest model)
        {
            var response = await _sysConfigService.GetNotifierListAsync(model);
            return Ok(response);
        }
    }
}
