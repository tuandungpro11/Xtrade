namespace TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftAccount;

public class OverdraftAccountListRequest
{
    public int Id { get; set; }
    public string? ServiceName { get; set; }
    public string? AccountId { get; set; }
    public short Status { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}