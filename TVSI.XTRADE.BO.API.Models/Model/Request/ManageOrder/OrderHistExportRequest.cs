namespace TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

public class OrderHistExportRequest : OrderBaseRequest
{
    public string? CustomerID { get; set; }
    public string? Symbol { get; set; }
    public int OrderStatus { get; set; }
    public string? OrderChannel { get; set; }
    public string? BeginDate { get; set; }
    public string? EndDate { get; set; }
}