namespace TVSI.XTRADE.BO.API.Models.Model.Request.RightRegistration;

public class RightStockListRequest
{
    public string? Symbol { get; set; }
    public int XType { get; set; } = -1;
    public string? RightDateFrom { get; set; }
    public string? RightDateTo { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}