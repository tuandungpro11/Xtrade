namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage
{
    public class RegisterPhoneServiceRequest
    {
        public int Id { get; set; } = 0;
        public string? CustomerId { get; set; }
        public string? Phone { get; set; }
        public byte IsSMS { get; set; }
        public byte IsCC { get; set; }
        public byte IsActive { get; set; }
    }
}
