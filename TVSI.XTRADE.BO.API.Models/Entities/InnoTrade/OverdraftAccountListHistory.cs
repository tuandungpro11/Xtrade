namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OverdraftAccountListHistory
    {
        public DateTime MovingDate { get; set; }
        public long Id { get; set; }
        public string AccountId { get; set; } = null!;
        public long OverdraftServiceId { get; set; }
        public short? Status { get; set; }
        public DateTime? EffectDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Remark { get; set; }
    }
}
