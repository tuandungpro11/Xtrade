namespace TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

public class OrderConditionRequest
{
    public string? UserId { get; set; }
    public int CooId { get; set; }
    public string? CustomerId { get; set; }
    public string? AccountNo { get; set; }
    public string? Symbol { get; set; }
    public int CooType { get; set; }
    public int OrderStatus { get; set; }
    public string? Side { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
    public int IsExpired { get; set; }
    public int? PageIndex { get; set; } = 1;
    public int? PageSize { get; set; } = 20;
}