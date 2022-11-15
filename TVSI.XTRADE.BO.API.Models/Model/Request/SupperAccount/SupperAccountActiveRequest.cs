namespace TVSI.XTRADE.BO.API.Models.Model.Request.SupperAccount;

public class SupperAccountActiveRequest
{
    public string? CustomerId { get; set; }
    public string? BranchId { get; set; }
    public int Status { get; set; }
}