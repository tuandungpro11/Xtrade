namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Account20190912
    {
        public long Id { get; set; }
        public string AccountNo { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public int? AccountType { get; set; }
        public string? AgentId { get; set; }
        public DateTime? BelongDate { get; set; }
        public bool? IsDefault { get; set; }
        public string? PaymentType { get; set; }
        public string? DelegateRemark { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int CoreType { get; set; }
        public string? CoreAccount { get; set; }
    }
}
