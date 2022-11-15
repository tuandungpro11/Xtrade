namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Coo
    {
        public long Id { get; set; }
        public long? RealId { get; set; }
        public long? ReferId { get; set; }
        public string? MessageType { get; set; }
        public string? SecSymbol { get; set; }
        public string Side { get; set; } = null!;
        public decimal? Price { get; set; }
        public string? ConPrice { get; set; }
        public long? Volume { get; set; }
        public long? ExecutedVol { get; set; }
        public decimal? ExecutedPrice { get; set; }
        public long? CancelVolume { get; set; }
        public long? CancelledVolume { get; set; }
        public string? Account { get; set; }
        public int? OrderType { get; set; }
        public string? OrderTime { get; set; }
        public string? SentTime { get; set; }
        public string? CancelledTime { get; set; }
        public short? OrderStatus { get; set; }
        public short? CancelStatus { get; set; }
        public int? OrdRejReason { get; set; }
        public string? ConfirmNo { get; set; }
        public string? CancelledConfirmNo { get; set; }
        public string? Market { get; set; }
        public string? MarketStatus { get; set; }
        public string? OrderSource { get; set; }
        public string? TraderId { get; set; }
        public string? CustomerId { get; set; }
        public decimal? Stopprice { get; set; }
        public long? Publishvol { get; set; }
        public string? UniqueId { get; set; }
        public string? TargetCustomerId { get; set; }
    }
}
