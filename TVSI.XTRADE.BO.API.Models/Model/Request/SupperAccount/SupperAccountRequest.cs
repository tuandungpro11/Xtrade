namespace TVSI.XTRADE.BO.API.Models.Model.Request.SupperAccount;

public class SupperAccountCreateRequest
{
    public string CustomerId { get; set; }
    public string BranchIdList { get; set; }
}

public class SupperAccountUpdateRequest
{
    public string CustomerId { get; set; }
    public string BranchId { get; set; }
    public string ChangeBranchId { get; set; }
}