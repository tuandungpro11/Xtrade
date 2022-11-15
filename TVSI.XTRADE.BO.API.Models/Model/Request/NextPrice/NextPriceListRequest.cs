namespace TVSI.XTRADE.BO.API.Models.Model.Request.NextPrice;

public class NextPriceListRequest : NextPriceListExportRequest
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}