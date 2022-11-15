namespace TVSI.XTRADE.BO.API.Models.Model.Request.InternalAccount;

public class InterAccListExportRequest
{
    public string? UserId { get; set; }
    public string? CustomerId { get; set; }
    public int Status { get; set; }
    public string? BeginDate { get; set; }
    public string? EndDate { get; set; }
}