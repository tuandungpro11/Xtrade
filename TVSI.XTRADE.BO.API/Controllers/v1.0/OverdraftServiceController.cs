using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftService;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class OverdraftServiceController : BaseController<OverdraftServiceController>
    {
        private readonly IOverdraftService _overdraftService;

        public OverdraftServiceController(ILogger<OverdraftServiceController> logger, IConfiguration config,
            IDetectionService detection, IOverdraftService overdraftService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _overdraftService = overdraftService;
        }


        /// <summary>
        ///     Lấy danh sách mã CK được mua
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftService/GetOverdraftServiceList
        ///     {
        ///         "Id": -1,
        ///         "ServiceName": "mua CK",
        ///         "Status": -1,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Status:
        ///         -1: Search All
        ///         0: Ngừng sử dụng
        ///         1: Đang sử dụng
        /// </remarks>
        
        [HttpPost("GetOverdraftServiceList")]
        public async Task<IActionResult> GetBankListAsync(OverdraftServiceListRequest model)
        {
            var response = await _overdraftService.GetOverdraftServiceListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Thêm thông tin dịch vụ thấu chi
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftService/CreateOverdraftService
        ///     {
        ///         "Id": 0,
        ///         "ServiceName": "ban CK",
        ///         "Status": 1,
        ///         "IsDelete": "",
        ///         "Remark": "test",
        ///         "UserId": "hungnd"
        ///     }
        /// </remarks>
        
        [HttpPost("CreateOverdraftService")]
        public async Task<IActionResult> CreateOverdraftServiceAsync(OverdraftServiceRequest model)
        {
            var response = await _overdraftService.ModifyOverdraftServiceAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Cập nhật thông tin dịch vụ thấu chi
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftService/UpdateOverdraftService
        ///     {
        ///         "Id": 15,
        ///         "ServiceName": "ban CK",
        ///         "Status": 0,
        ///         "IsDelete": "",
        ///         "Remark": "test 2",
        ///         "UserId": "hungnd"
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateOverdraftService")]
        public async Task<IActionResult> UpdateOverdraftServiceAsync(OverdraftServiceRequest model)
        {
            var response = await _overdraftService.ModifyOverdraftServiceAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Xóa thông tin dịch vụ thấu chi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftService/DeleteOverdraftService/15
        /// </remarks>
        
        [HttpPost("DeleteOverdraftService/{id:int}")]
        public async Task<IActionResult> DeleteOverdraftServiceAsync(int id)
        {
            var response = await _overdraftService.DeleteOverdraftServiceAsync(id);
            return Ok(response);
        }
    }
}