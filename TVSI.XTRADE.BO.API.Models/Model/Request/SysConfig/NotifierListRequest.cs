namespace TVSI.XTRADE.BO.API.Models.Model.Request.SysConfig;

public class NotifierListRequest
{
    public string? CustomerId { get; set; }
    public string? AccountNo { get; set; }
    public int NotifyAction { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}