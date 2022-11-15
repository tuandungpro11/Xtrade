namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage
{
    public class RegisterEmailServiceRequest
    {
        public int Id { get; set; } = 0;
        public string? CustomerId { get; set; }
        public string? Email { get; set; }
        public byte IsKQGD { get; set; }
        public byte IsQC { get; set; }
        public byte IsActive { get; set; }
    }
}
