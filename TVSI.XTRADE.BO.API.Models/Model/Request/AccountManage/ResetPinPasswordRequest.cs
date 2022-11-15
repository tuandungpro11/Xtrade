namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage;

public class ResetPinPasswordRequest
{
    public string CustomerId { get; set; }
    public int SendSMS { get; set; } = 0;
    public int ChangeType { get; set; }
}