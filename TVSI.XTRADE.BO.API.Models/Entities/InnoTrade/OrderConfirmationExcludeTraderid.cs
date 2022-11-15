namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderConfirmationExcludeTraderid
    {
        public long ExTraderId { get; set; }
        public string TraderId { get; set; } = null!;
        public int TraderType { get; set; }
        public short? Status { get; set; }
        public DateTime? EffDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
    }
}
