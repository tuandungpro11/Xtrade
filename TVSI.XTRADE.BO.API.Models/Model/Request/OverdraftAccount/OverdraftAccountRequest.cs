namespace TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftAccount;

public class OverdraftAccountRequest
{
    public int Id { get; set; } = 0;
    public string AccountId { get; set; }
    public long OverdraftServiceId { get; set; }
    public int Status { get; set; }
    public DateTime EffectDate { get; set; }
    public DateTime ExpireDate { get; set; }
    public string? Remark { get; set; }
    public string? UserId { get; set; }
}