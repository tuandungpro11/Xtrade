namespace TVSI.XTRADE.BO.API.Models.Model.Request.Agent
{
    public class AgentRequest
    {
        public string AgentId { get; set; }
        public string AgentType { get; set; }
        public decimal BonusReserve { get; set; } = 0;
        public int Commission { get; set; } = 0;
        public string? TraderId { get; set; } = null;
        public string? SupervisorId { get; set; } = null;
        public string? AgentGroupId { get; set; } = null;
        public string? KeyOrdZone { get; set; } = null;
        public string? Description { get; set; } = null;
        public string? ModifiedBy { get; set; }
    }
}
