namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderConditionStsent
    {
        public long Id { get; set; }
        public long? OrderConditionStid { get; set; }
        public string? RefOrderId { get; set; }
        public string? FisOrderId { get; set; }
        public string? EnterId { get; set; }
        public string? SecSymbol { get; set; }
        public string? Side { get; set; }
        public decimal? Price { get; set; }
        public string? ConPrice { get; set; }
        public long? Volume { get; set; }
        public long? TotalMatchedVolume { get; set; }
        public long? TotalCancelledVolume { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Status { get; set; }
        public string? RejectedReasonCode { get; set; }
    }
}
