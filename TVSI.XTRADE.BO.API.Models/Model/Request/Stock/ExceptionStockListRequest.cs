namespace TVSI.XTRADE.BO.API.Models.Model.Request.Stock
{
    public class ExceptionStockListRequest : ExceptionStockListExportRequest
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
