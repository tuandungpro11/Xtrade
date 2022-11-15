namespace TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader
{
    public class ExTraderCheckRequest
    {
        public string? AgentId { get; set; }
        public int AgentType { get; set; }
        public byte IsLike { get; set; } = 0;
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
