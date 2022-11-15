using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.WhiteList;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class WhiteListController : BaseController<WhiteListController>
    {
        private readonly IWhiteListService _whiteListService;

        public WhiteListController(ILogger<WhiteListController> logger, IConfiguration config,
            IDetectionService detection, IWhiteListService whiteListService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _whiteListService = whiteListService;
        }

        /// <summary>
        ///     Lấy danh sách ủy quyền giao dịch của KH cho đại lý
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/WhiteList/GetWhiteList
        ///     {
        ///         "UserId": "hungnd",
        ///         "AccountNo": "000515",
        ///         "AgentType": 2,
        ///         "AgentId": "",
        ///         "FromDate": "20000623",
        ///         "ToDate": "20220630",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        ///
        ///     AgentType:
        ///         1: Đại lý chính thức
        ///         2. Đại lý tự do
        /// </remarks>
        
        [HttpPost("GetWhiteList")]
        public async Task<IActionResult> GetWhiteListAsync(WhiteListRequest model)
        {
            var response = await _whiteListService.GetWhiteListAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Thêm ủy quyền giao dịch của KH cho đại lý
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/WhiteList/CreateWhiteList
        ///     {
        ///         "Id": 0,
        ///         "AccountNo": "0005151",
        ///         "AgentType": 2,
        ///         "AgentId": "300002",
        ///         "UserId": "hungnd"
        ///     }
        /// </remarks>
        
        [HttpPost("CreateWhiteList")]
        public async Task<IActionResult> CreateWhiteListAsync(WhiteListModifyRequest model)
        {
            var response = await _whiteListService.ModifyWhiteListAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Cập nhật thông tin ủy quyền giao dịch của KH cho đại lý
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/WhiteList/UpdateWhiteList
        ///     {
        ///         "Id": 39,
        ///         "AccountNo": "0005156",
        ///         "AgentType": 2,
        ///         "AgentId": "300002",
        ///         "UserId": "hungnd"
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateWhiteList")]
        public async Task<IActionResult> UpdateWhiteListAsync(WhiteListModifyRequest model)
        {
            var response = await _whiteListService.ModifyWhiteListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Xóa ủy quyền giao dịch của KH cho đại lý
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/WhiteList/DeleteWhiteList
        ///     {
        ///         "Id": 39,
        ///         "UserId": "hungnd"
        ///     }
        /// </remarks>
        
        [HttpPost("DeleteWhiteList")]
        public async Task<IActionResult> DeleteWhiteListAsync(WhiteListDelRequest model)
        {
            var response = await _whiteListService.DeleteWhiteListAsync(model);
            return Ok(response);
        }
    }
}