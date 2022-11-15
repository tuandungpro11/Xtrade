namespace TVSI.XTRADE.BO.API.Models.Model.Request.InternalAccount;

public class InterAccStatusRequest
{
    public string CustomerId { get; set; }
    public string InternalAccountNo { get; set; }
    public int InternalStatus { get; set; }
    public string? Reason { get; set; }
    public string? ModifiedBy { get; set; }
}