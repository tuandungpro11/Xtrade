namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class StockinfoOddlot
    {
        public long KeyId { get; set; }
        public string StockCode { get; set; } = null!;
        public decimal? MatchPrice { get; set; }
        public decimal? MatchQtty { get; set; }
        public decimal? TotalQtty { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? BestBidQtty3 { get; set; }
        public decimal? BestBidPrice3 { get; set; }
        public decimal? BestBidQtty2 { get; set; }
        public decimal? BestBidPrice2 { get; set; }
        public decimal? BestBidQtty1 { get; set; }
        public decimal? BestBidPrice1 { get; set; }
        public decimal? BestOfferPrice1 { get; set; }
        public decimal? BestOfferQtty1 { get; set; }
        public decimal? BestOfferPrice2 { get; set; }
        public decimal? BestOfferQtty2 { get; set; }
        public decimal? BestOfferPrice3 { get; set; }
        public decimal? BestOfferQtty3 { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
        public long? Sequence { get; set; }
    }
}
