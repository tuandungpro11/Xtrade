namespace TVSI.XTRADE.BO.API.Models.Model.Request.Stock
{
    public class DeleteExceptionStockRequest
    {
        public string Symbol { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
    }
}
