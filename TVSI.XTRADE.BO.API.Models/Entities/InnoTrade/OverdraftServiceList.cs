namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OverdraftServiceList
    {
        public long Id { get; set; }
        public string ServiceName { get; set; } = null!;
        public short? Status { get; set; }
        public string? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Remark { get; set; }
    }
}
