namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class TvsiDuLieuXacNhanLenh
    {
        public int? Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public string AccountNo { get; set; } = null!;
        public string SecSymbol { get; set; } = null!;
        public int? OrderId { get; set; }
        public string? Side { get; set; }
        public decimal? Price { get; set; }
        public long? Volume { get; set; }
        public long? ExecutedVol { get; set; }
        public decimal? ExecutedPrice { get; set; }
        public long? CancelVolume { get; set; }
        public long? CancelledVolume { get; set; }
        public DateTime? TransTime { get; set; }
        public DateTime? MatchedTime { get; set; }
        public DateTime? CancelledTime { get; set; }
        public string? TraderId { get; set; }
        public string? OrderSource { get; set; }
        public string? ConfirmCode { get; set; }
        public DateTime? ConfirmCodeDate { get; set; }
        public int Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public string? TpCode { get; set; }
        public int? TpStatus { get; set; }
        public int? TpUse { get; set; }
    }
}
