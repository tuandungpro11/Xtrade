namespace TVSI.XTRADE.BO.API.Models.Model.Request.InternalAccount;

public class InterAccListRequest : InterAccListExportRequest
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}