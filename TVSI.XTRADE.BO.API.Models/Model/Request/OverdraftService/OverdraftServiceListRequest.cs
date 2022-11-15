namespace TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftService;

public class OverdraftServiceListRequest
{
    public int Id { get; set; }
    public string? ServiceName { get; set; }
    public short Status { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}