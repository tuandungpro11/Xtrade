namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AgentBrokerException
    {
        public long Id { get; set; }
        public int? CustType { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public string? TraderId { get; set; }
    }
}
