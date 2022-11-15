namespace TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

public class OrderBasketRequest : OrderBaseRequest
{
    public string? CustomerID { get; set; }
    public int? PageIndex { get; set; } = 1;
    public int? PageSize { get; set; } = 20;
}