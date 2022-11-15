namespace TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

public class OrderBasketInfoRequest : OrderBaseRequest
{
    public string? CustomerID { get; set; }
    public string? BasketID{ get; set; }
    public int? PageIndex { get; set; } = 1;
    public int? PageSize { get; set; } = 20;
}