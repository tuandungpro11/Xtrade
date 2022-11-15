namespace TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;

public class OrderConditionGTDExportRequest : OrderBaseRequest
{
    public string? Source { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
    public string? status { get; set; }
}