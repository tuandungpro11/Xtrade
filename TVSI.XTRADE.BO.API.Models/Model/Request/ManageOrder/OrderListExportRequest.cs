namespace TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

public class OrderListExportRequest
{
    public string UserId { get; set; }
    public string? Accounts { get; set; }
    public string? Channel { get; set; }
    public string? Status { get; set; }
    public string? SecSymbols { get; set; }
    public string? FisOrderIds { get; set; }
}