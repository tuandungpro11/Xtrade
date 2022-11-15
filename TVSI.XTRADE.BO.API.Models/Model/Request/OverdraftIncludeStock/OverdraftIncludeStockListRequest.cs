namespace TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftIncludeStock
{
    public class OverdraftIncludeStockListRequest
    {
        public int Id { get; set; }
        public string? Symbol { get; set; }
        public int Status { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
