namespace TVSI.XTRADE.BO.API.Models.Model.Request.Agent;

public class AgentListRequest
{
    public string? AgentId { get; set; }
    public int AgentType { get; set; } = -1;
    public byte IsLike { get; set; } = 0;
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}