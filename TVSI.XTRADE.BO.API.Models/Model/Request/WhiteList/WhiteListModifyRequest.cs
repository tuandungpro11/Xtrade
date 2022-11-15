namespace TVSI.XTRADE.BO.API.Models.Model.Request.WhiteList;

public class WhiteListModifyRequest
{
    public long Id { get; set; } = 0;
    public string AccountNo { get; set; }
    public int AgentType { get; set; }
    public string AgentId { get; set; }
    public string UserId { get; set; }
}