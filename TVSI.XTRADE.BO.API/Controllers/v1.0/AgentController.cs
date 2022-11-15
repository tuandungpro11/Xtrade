using TVSI.XTRADE.BO.API.Models.Model.Request.Agent;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    public class AgentController : BaseController<AgentController>
    {
        private readonly IAgentService _agentService;

        public AgentController(ILogger<AgentController> logger, IConfiguration config, IDetectionService detection,
            IAgentService agentService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _agentService = agentService;
        }

        /// <summary>
        ///     Lấy danh sách Agent 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Agent/GetAgentList
        ///     {
        ///         "AgentId": "000515",
        ///         "AgentType": 1,
        ///         "IsLike": 0,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        ///
        ///     AgentId:
        ///         "": Search all
        /// 
        ///     AgentType:
        ///         -1: Search all
        ///         1: Đại lý chính thức
        ///         2: Đại lý tự do
        ///         3: Đại lý tự doanh
        ///
        ///     IsLike:
        ///         0: Tìm kiếm chính xác
        ///         1: Tìm kiếm gần đúng
        ///
        /// </remarks>
        
        [HttpPost("GetAgentList")]
        public async Task<IActionResult> GetAgentListAsync(AgentListRequest model)
        {
            var response = await _agentService.GetAgentListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Thêm thông tin Agent
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Agent/CreateAgent
        ///     {
        ///         "AgentId": "000515",
        ///         "AgentType": 1,
        ///         "BonusReserve": 0,
        ///         "Commission": 0,
        ///         "TraderId": "",
        ///         "SupervisorId": "",
        ///         "AgentGroupId": "",
        ///         "KeyOrdZone": "",
        ///         "Description": "",
        ///         "ModifiedBy": "hungnd"
        ///     }
        /// </remarks>
        
        [HttpPost("CreateAgent")]
        public async Task<IActionResult> CreateAgentAsync(AgentRequest model)
        {
            var response = await _agentService.ModifyAgentAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Cập nhật thông tin Agent
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Agent/UpdateAgent
        ///     {
        ///         "AgentId": "000515",
        ///         "AgentType": 1,
        ///         "BonusReserve": 0,
        ///         "Commission": 0,
        ///         "TraderId": "",
        ///         "SupervisorId": "",
        ///         "AgentGroupId": "",
        ///         "KeyOrdZone": "",
        ///         "Description": "",
        ///         "ModifiedBy": "hungnd"
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateAgent")]
        public async Task<IActionResult> UpdateAgentAsync(AgentRequest model)
        {
            var response = await _agentService.ModifyAgentAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Xóa thông tin Agent (khi KH là nhà đầu tư)
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Agent/DeleteAgent/000515
        /// 
        /// </remarks>
        
        [HttpPost("DeleteAgent/{agentId}")]
        public async Task<IActionResult> DeleteAgentAsync(string agentId)
        {
            var response = await _agentService.DeleteAgentAsync(agentId);
            return Ok(response);
        }
    }
}