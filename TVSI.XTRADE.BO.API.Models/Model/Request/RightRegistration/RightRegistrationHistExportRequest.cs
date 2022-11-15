namespace TVSI.XTRADE.BO.API.Models.Model.Request.RightRegistration;

public class RightRegistrationHistExportRequest
{
    public string? UserId { get; set; }
    public string? CustomerId { get; set; }
    public string? AccountNo { get; set; }
    public string? ContractNo { get; set; }
    public string? RightDateFrom { get; set; }
    public string? RightDateTo { get; set; }
    public int Status { get; set; } = -1;
    public int XType { get; set; } = -1; 
    public string? Symbol { get; set; }
    public string? UserIdEdit { get; set; }
}