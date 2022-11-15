namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CooTriggerPriceTransaction
    {
        public int Id { get; set; }
        public int? CooId { get; set; }
        public string? Symbol { get; set; }
        public DateTime? TradeTime { get; set; }
        public double? MarketPrice { get; set; }
        public double? TriggerPrice { get; set; }
        public bool? IsTriggered { get; set; }
        public int? CoreTime { get; set; }
    }
}
