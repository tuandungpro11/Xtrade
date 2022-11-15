namespace TVSI.XTRADE.BO.API.Models.Model.Request.InternalAccount;

public class InterAccRequest
{
    public string CustomerId { get; set; }
    public string InternalAccountNo { get; set; }
    public string? NewInternalAccountNo { get; set; }
    public string InternalCustomerId { get; set; }
    public string? InternalCustomerName { get; set; }
    public string InternalCustomerNo { get; set; }
    public string? InternalIdentityCard { get; set; }
    public string? InternalAddress { get; set; }
    public int InternalStatus { get; set; }
    public string? InternalScanURL { get; set; }
    public string? Remark { get; set; }
    public string? Reason { get; set; }
    public string? Date { get; set; }
    public string UserId { get; set; }
}