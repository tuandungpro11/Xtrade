namespace TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader
{
    public class ExTraderListRequest : ExTraderListExportRequest
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
