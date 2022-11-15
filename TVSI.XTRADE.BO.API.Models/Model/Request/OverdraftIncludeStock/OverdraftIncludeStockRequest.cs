namespace TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftIncludeStock
{
    public class OverdraftIncludeStockRequest
    {
        public int Id { get; set; }
        public string? Symbol { get; set; }
        public int Status { get; set; }
        public DateTime? EffectDate { get; set; } 
        public DateTime? ExpireDate { get; set; }
        public string Remark { get; set; }
        public string UserId { get; set; }
    }
}
