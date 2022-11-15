namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage
{
    public class AccountChangeActiveRequest
    {
        public string? UserId { get; set; }
        public string? CustomerId { get; set; }
        public int Status { get; set; }
    }
}
