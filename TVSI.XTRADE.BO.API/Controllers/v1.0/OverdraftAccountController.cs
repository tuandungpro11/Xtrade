using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftAccount;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class OverdraftAccountController : BaseController<OverdraftAccountController>
    {
        private readonly IOverdraftAccountService _overdraftAccountService;

        public OverdraftAccountController(ILogger<OverdraftAccountController> logger, IConfiguration config,
            IDetectionService detection, IOverdraftAccountService overdraftAccountService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _overdraftAccountService = overdraftAccountService;
        }


        /// <summary>
        ///     Lấy danh sách tài khoản thấu chi
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftAccount/GetOverdraftAccountList
        ///     {
        ///         "Id": -1,
        ///         "ServiceName": "mua CK",
        ///         "AccountId": "",
        ///         "Status": -1,
        ///         "FromDate": "",
        ///         "ToDate": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Status:
        ///         -1: Search All
        ///         0: Ngừng sử dụng
        ///         1: Đang sử dụng
        /// 
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("GetOverdraftAccountList")]
        public async Task<IActionResult> GetBankListAsync(OverdraftAccountListRequest model)
        {
            var response = await _overdraftAccountService.GetOverdraftAccountListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Thêm thông tin tài khoản thấu chi
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftAccount/CreateOverdraftAccount
        ///     {
        ///         "AccountId": "0005151",
        ///         "OverdraftServiceId": 13,
        ///         "Status": 1,
        ///         "EffectDate": "2022-07-01",
        ///         "ExpireDate": "2022-09-30",
        ///         "Remark": "test",
        ///         "UserId": "hungnd"
        ///     }
        /// 
        ///     Format Date: yyyy-MM-dd
        /// </remarks>
        
        [HttpPost("CreateOverdraftAccount")]
        public async Task<IActionResult> CreateOverdraftAccountAsync(OverdraftAccountRequest model)
        {
            var response = await _overdraftAccountService.ModifyOverdraftAccountAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Cập nhật thông tin tài khoản thấu chi
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftAccount/UpdateOverdraftAccount
        ///     {
        ///         "Id": 112,
        ///         "AccountId": "0005151",
        ///         "OverdraftServiceId": 1,
        ///         "Status": 1,
        ///         "EffectDate": "2022-07-01",
        ///         "ExpireDate": "2022-09-30",
        ///         "Remark": "test",
        ///         "UserId": "hungnd"
        ///     }
        /// 
        ///     Format Date: yyyy-MM-dd
        /// </remarks>
        
        [HttpPost("UpdateOverdraftAccount")]
        public async Task<IActionResult> UpdateOverdraftAccountAsync(OverdraftAccountRequest model)
        {
            var response = await _overdraftAccountService.ModifyOverdraftAccountAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Xóa thông tin tài khoản thấu chi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/OverdraftAccount/DeleteOverdraftAccount/31
        /// </remarks>
        
        [HttpPost("DeleteOverdraftAccount/{id:int}")]
        public async Task<IActionResult> DeleteOverdraftAccountAsync(int id)
        {
            var response = await _overdraftAccountService.DeleteOverdraftAccountAsync(id);
            return Ok(response);
        }
    }
}