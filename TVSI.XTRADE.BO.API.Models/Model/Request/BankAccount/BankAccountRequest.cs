namespace TVSI.XTRADE.BO.API.Models.Model.Request.BankAccount;

public class BankAccountRequest
{
    public string BankAccount { get; set; }
    public string CustomerId { get; set; }
    public string? Beneficiary { get; set; }
    public string? BankName { get; set; }
    public string? Province { get; set; }
    public string? Remark { get; set; }
    public int Priority { get; set; }
    public int Status { get; set; }
    public string? URLPath { get; set; }
    public string BankNo { get; set; }
    public string BranchNo { get; set; }
    public string UserId { get; set; }
    public int BankType { get; set; }
}