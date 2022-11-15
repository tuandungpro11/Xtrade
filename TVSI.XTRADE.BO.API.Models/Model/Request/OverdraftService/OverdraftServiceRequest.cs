namespace TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftService;

public class OverdraftServiceRequest
{
    public int Id { get; set; }
    public string ServiceName { get; set; }
    public short Status { get; set; }
    public string? IsDelete { get; set; }
    public string? Remark { get; set; }
    public string UserId { get; set; }
}