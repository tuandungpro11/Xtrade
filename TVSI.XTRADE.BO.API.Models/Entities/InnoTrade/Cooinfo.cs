namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Cooinfo
    {
        public int Id { get; set; }
        public string? MessageType { get; set; }
        public string? SecSymbol { get; set; }
        public string? Side { get; set; }
        public decimal? Price { get; set; }
        public string? ConPrice { get; set; }
        public long? Volume { get; set; }
        public long? ExecutedVol { get; set; }
        public decimal? ExecutedPrice { get; set; }
        public long? CancelVolume { get; set; }
        public long? CancelledVolume { get; set; }
        public string? CustomerId { get; set; }
        public string? Account { get; set; }
        public int? OrderType { get; set; }
        public DateTime? OrderTime { get; set; }
        public DateTime? SentTime { get; set; }
        public DateTime? CancelledTime { get; set; }
        public short? OrderStatus { get; set; }
        public short? CancelStatus { get; set; }
        public int? OrdRejReason { get; set; }
        public string? ConfirmNo { get; set; }
        public string? CancelledConfirmNo { get; set; }
        public string? Market { get; set; }
        public string? MarketStatus { get; set; }
        public string? OrderSource { get; set; }
        public string? TraderId { get; set; }
        public int? MatchingType { get; set; }
        public DateTime? EffectiveFromDateTime { get; set; }
        public DateTime? EffectiveToDateTime { get; set; }
        public short? CooType { get; set; }
        public DateTime? LastRunEoth { get; set; }
        public byte[]? RowVersion { get; set; }
        public int? Flag { get; set; }
        public string? ConstraintCoreTime { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? Remark { get; set; }
        public long? IndayExecutedVol { get; set; }
        public decimal? IndayExecutedPrice { get; set; }
    }
}
