namespace TVSI.XTRADE.BO.API.Models.Model.Request.Logging;

public class LogSystemRequest
{
    public string? UserId { get; set; }
    public string? CustomerId { get; set; }
    public int ActionType { get; set; }
    public string? BranchId { get; set; }
    public string? BeginDate { get; set; }
    public string? EndDate { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}