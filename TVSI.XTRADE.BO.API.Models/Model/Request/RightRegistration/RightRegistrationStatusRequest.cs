namespace TVSI.XTRADE.BO.API.Models.Model.Request.RightRegistration;

public class RightRegistrationStatusRequest
{
    public int Id { get; set; }
    public int Status { get; set; }
    public string? Reason { get; set; }
    public string? UserId { get; set; }
}