namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderConfirmationsummaryHistory
    {
        public long SumId { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? TradeDate { get; set; }
        public string? AuthorId { get; set; }
        public string? CustomerId { get; set; }
        public string? ChannelId { get; set; }
        public int? NumberOfOrder { get; set; }
        public int? NumberOfConfirm { get; set; }
        public int? ExpiredDays { get; set; }
        public string? ConfirmContent { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
    }
}
