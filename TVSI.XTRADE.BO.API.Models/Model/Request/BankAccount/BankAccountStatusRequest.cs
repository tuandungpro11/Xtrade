namespace TVSI.XTRADE.BO.API.Models.Model.Request.BankAccount;

public class BankAccountStatusRequest
{
    public long BankAccountId { get; set; }
    public int Status { get; set; }
    public string? Reason { get; set; }
    public string ModifiedBy { get; set; }
}