using TVSI.XTRADE.BO.API.Models.Model.Request.Agent;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface IAgentService
    {
        Task<Response<dynamic>?> GetAgentListAsync(AgentListRequest model);
        Task<Response<int>> ModifyAgentAsync(AgentRequest model);
        Task<Response<int>> DeleteAgentAsync(string agentId);
    }
}
