namespace TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader
{
    public class ExTraderCreateRequest
    {
        public string TraderId { get; set; }
        public int TraderType { get; set; }
        public int Status { get; set; }
        public DateTime EffDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string? Remark { get; set; }
        public string UserId { get; set; }
    }
}