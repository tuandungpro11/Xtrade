namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Coredelegate
    {
        public long Id { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public string? AgentId { get; set; }
        public string? TradeTransFlag { get; set; }
        public string? StockTransFlag { get; set; }
        public string? MoneyTransFlag { get; set; }
        public string? CardId { get; set; }
        public DateTime? Effdate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? PaymentType { get; set; }
        public string? CustAcct { get; set; }
        public string? ActionType { get; set; }
    }
}
