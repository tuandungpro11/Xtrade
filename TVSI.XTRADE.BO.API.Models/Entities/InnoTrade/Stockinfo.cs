namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Stockinfo
    {
        public long KeyId { get; set; }
        public long? StockNo { get; set; }
        public string MarketCode { get; set; } = null!;
        public string StockCode { get; set; } = null!;
        public string? StockName { get; set; }
        public string? StockType { get; set; }
        public decimal? ParValue { get; set; }
        public decimal? TradingUnit { get; set; }
        public DateTime? TradingDate { get; set; }
        public decimal? CeilingPrice { get; set; }
        public decimal? FloorPrice { get; set; }
        public decimal? BasicPrice { get; set; }
        public decimal? AveragePrice { get; set; }
        public decimal? MatchPrice { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
    }
}
