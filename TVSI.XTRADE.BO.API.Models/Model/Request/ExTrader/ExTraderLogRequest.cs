namespace TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader
{
    public class ExTraderLogRequest
    {
        public string? CustomerId { get; set; }
        public string? UserId { get; set; }
        public int ActionType { get; set; }
        public string? OldInfo { get; set; }
        public string? NewInfo { get; set; }
        public string? IP { get; set; }
        public string? Remark { get; set; }
        public string? Module { get; set; }
    }
}
