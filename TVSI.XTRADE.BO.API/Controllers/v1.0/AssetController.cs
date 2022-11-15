using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.Asset;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class AssetController : BaseController<AssetController>
    {
        private readonly IAssetService _assetService;

        public AssetController(ILogger<AssetController> logger, IConfiguration config,
            IDetectionService detection, IAssetService assetService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _assetService = assetService;
        }
        /// <summary>
        ///     Lấy thông tin tài sản khách hàng từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Asset/GetAssetDetail
        ///     {
        ///         "AccountNo": "0001311",
        ///         "CustomerId": "",
        ///         "FromDate": "12/07/2022",
        ///         "ToDate": "13/07/2022"
        ///     }
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>
        [HttpPost("GetAssetDetail")]
        public async Task<IActionResult> GetAssetDetailAsync(AssetDetailRequest model)
        {
            var response = await _assetService.GetAssetDetailAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy lịch sử thông tin tài sản gần nhất của khách hàng từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Asset/GetLastestAssetHistory
        ///     {
        ///         "AccountNo": "0001311",
        ///         "CustomerId": ""
        ///     }
        /// </remarks>
        [HttpPost("GetLastestAssetHistory")]
        public async Task<IActionResult> GetLastestAssetHistoryAsync(AssetHistoryRequest model)
        {
            var response = await _assetService.GetLastestAssetHistoryAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }
    }
}
