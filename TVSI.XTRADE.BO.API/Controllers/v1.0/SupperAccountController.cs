using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.SupperAccount;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class SupperAccountController : BaseController<SupperAccountController>
    {
        private readonly ISupperAccountService _supperAccountService;

        public SupperAccountController(ILogger<SupperAccountController> logger, IConfiguration config,
            IDetectionService detection, ISupperAccountService supperAccountService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _supperAccountService = supperAccountService;
        }

        /// <summary>
        ///     Lấy danh sách quyền đại lý tự doanh theo chi nhánh
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SupperAccount/GetSupperAccountList
        ///     {
        ///         "UserId": "hungnd",
        ///         "CustomerId": "000515",
        ///         "BranchId": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// </remarks>
        
        [HttpPost("GetSupperAccountList")]
        public async Task<IActionResult> GetSupperAccountListAsync([FromBody] SupperAccountListRequest model)
        {
            var response = await _supperAccountService.GetSupperAccountListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy thông tin quyền đại lý tự doanh theo chi nhánh
        /// </summary>
        /// <param name="id"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SupperAccount/GetSupperAccount/123
        /// </remarks>
        
        [HttpPost("GetSupperAccount/{id:long}")]
        public async Task<IActionResult> GetSupperAccountDetailAsync(long id)
        {
            var response = await _supperAccountService.GetSupperAccountDetailAsync(id);
            return Ok(response);
        }

        /// <summary>
        ///     Thêm thông tin quyền đại lý tự doanh theo chi nhánh
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SupperAccount/CreateSupperAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "BranchIdList": "00, 01, 02, 04"
        ///     }
        /// 
        /// </remarks>
        
        [HttpPost("CreateSupperAccount")]
        public async Task<IActionResult> CreateSupperAccountAsync(SupperAccountCreateRequest model)
        {
            var response = await _supperAccountService.CreateSupperAccountAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Cập nhật thông tin quyền đại lý tự doanh theo chi nhánh
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SupperAccount/UpdateSupperAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "BranchId": "02",
        ///         "ChangeBranchId": "04"
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateSupperAccount")]
        public async Task<IActionResult> UpdateSupperAccountAsync(SupperAccountUpdateRequest model)
        {
            var response = await _supperAccountService.UpdateSupperAccountAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Xóa thông tin quyền đại lý tự doanh theo chi nhánh
        /// </summary>
        /// 
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SupperAccount/DeleteSupperAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "BranchId": "01"
        ///     }
        /// </remarks>
        
        [HttpPost("DeleteSupperAccount")]
        public async Task<IActionResult> DeleteSupperAccountAsync(SupperAccountDelRequest model)
        {
            var response = await _supperAccountService.DeleteSupperAccountAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Active/Inactive thông tin quyền đại lý tự doanh theo chi nhánh
        /// </summary>
        /// 
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/SupperAccount/ChangeActiveSupperAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "BranchId": "01",
        ///         "Status" : 0
        ///     }
        /// </remarks>
        
        [HttpPost("ChangeActiveSupperAccount")]
        public async Task<IActionResult> ChangeActiveSupperAccountAsync(SupperAccountActiveRequest model)
        {
            var response = await _supperAccountService.ChangeActiveSupperAccountAsync(model);
            return Ok(response);
        }
    }
}
