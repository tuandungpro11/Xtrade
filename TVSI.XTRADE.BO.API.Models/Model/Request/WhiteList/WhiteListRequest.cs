namespace TVSI.XTRADE.BO.API.Models.Model.Request.WhiteList;

public class WhiteListRequest
{
    public string? UserId { get; set; }
    public string? AccountNo { get; set; }
    public int AgentType { get; set; }
    public string? AgentId { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}