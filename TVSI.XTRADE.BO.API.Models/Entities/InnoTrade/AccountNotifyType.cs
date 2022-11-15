namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AccountNotifyType
    {
        public int Id { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public int? NotifyAction { get; set; }
        public int? NotifyType { get; set; }
        public int? Cc { get; set; }
    }
}
