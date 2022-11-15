using TVSI.XTRADE.BO.API.Models.Model.Request.CustomerGroup;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class CustomerGroupController : BaseController<CustomerGroupController>
    {
        private readonly ICustomerGroupService _customerGroupService;

        public CustomerGroupController(ILogger<CustomerGroupController> logger, IConfiguration config, IDetectionService detection,
            ICustomerGroupService customerGroupService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _customerGroupService = customerGroupService;
        }


        /// <summary>
        ///     Lấy danh sách nhóm khách hàng (Customer Group)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/CustomerGroup/GetCustomerGroupList
        ///     {
        ///         "Id": -1,
        ///         "AccountType": 0,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     AccountType:
        ///         0 : Nhà đầu tư
        ///         1 : Đại lý 
        /// </remarks>
        
        [HttpPost("GetCustomerGroupList")]
        public async Task<IActionResult> GetCustomerGroupListAsync(CustomerGroupListRequest model)
        {
            var response = await _customerGroupService.GetCustomerGroupListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Thêm nhóm khách hàng (Customer Group)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/CustomerGroup/UpdateCustomerGroup
        ///     {
        ///         "Name": "Vip",
        ///         "Description": "Group Vip",
        ///         "AccountType": 1,
        ///         "Active": 1,
        ///         "Level": 0
        ///     }
        /// </remarks>
        
        [HttpPost("CreateCustomerGroup")]
        public async Task<IActionResult> CreateCustomerGroupAsync(CustomerGroupRequest model)
        {
            var response = await _customerGroupService.CreateCustomerGroupAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Cập nhật nhóm khách hàng (Customer Group)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/CustomerGroup/UpdateCustomerGroup
        ///     {
        ///         "Id" : 9999
        ///         "Name": "Vip",
        ///         "Description": "Group Vip",
        ///         "AccountType": 1,
        ///         "Active": 1,
        ///         "Level": 0
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateCustomerGroup")]
        public async Task<IActionResult> UpdateCustomerGroupAsync(CustomerGroupRequest model)
        {
            var response = await _customerGroupService.UpdateCustomerGroupAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Xóa nhóm khách hàng (Customer Group) 
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/CustomerGroup/DeleteCustomerGroup/1
        /// </remarks>
        
        [HttpPost("DeleteCustomerGroup/{groupId:int}")]
        public async Task<IActionResult> DeleteCustomerGroupAsync(int groupId)
        {
            var response = await _customerGroupService.DeleteCustomerGroupAsync(groupId);
            return Ok(response);
        }
    }
}
