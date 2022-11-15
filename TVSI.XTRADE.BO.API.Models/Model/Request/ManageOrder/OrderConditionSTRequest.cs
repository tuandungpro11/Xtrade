namespace TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

public class OrderConditionSTRequest : OrderConditionSTExportRequest
{
    public int? PageIndex { get; set; } = 1;
    public int? PageSize { get; set; } = 20;
}