namespace TVSI.XTRADE.BO.API.Models.Model.Request.BankAccount;

public class BankAccountUpdateRequest : BankAccountRequest
{
    public long BankAccountId { get; set; }
    public string? Reason { get; set; }
}