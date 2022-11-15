namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderConditionGtd
    {
        public long Id { get; set; }
        public string Source { get; set; } = null!;
        public string AccountNo { get; set; } = null!;
        public string Side { get; set; } = null!;
        public string StockSymbol { get; set; } = null!;
        public string ConditionPrice { get; set; } = null!;
        public decimal Price { get; set; }
        public long Volume { get; set; }
        public long VolumeMatched { get; set; }
        public long? VolumeCancelled { get; set; }
        public decimal? LastMatchedPrice { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int MatchingType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime? LastProcessedDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public DateTime? LastMatchingDate { get; set; }
        public int Status { get; set; }
        public int? CoreOrderStatus { get; set; }
        public string? RejectedReasonCode { get; set; }
    }
}
