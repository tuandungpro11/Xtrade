namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderConditionSt
    {
        public long Id { get; set; }
        public string Source { get; set; } = null!;
        public string AccountNo { get; set; } = null!;
        public string StockSymbol { get; set; } = null!;
        public decimal AvgPrice { get; set; }
        public bool? IsCheckStopLoss { get; set; }
        public decimal StopLossWhenPrice { get; set; }
        public decimal StopLossPrice { get; set; }
        public bool? IsCheckTakeProfit { get; set; }
        public decimal TakeProfitWhenPrice { get; set; }
        public decimal TakeProfitPrice { get; set; }
        public long Volume { get; set; }
        public long VolumeMatched { get; set; }
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
