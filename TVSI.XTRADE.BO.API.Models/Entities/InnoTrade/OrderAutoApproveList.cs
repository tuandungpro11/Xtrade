namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderAutoApproveList
    {
        public int ApproveId { get; set; }
        public string? AccountNo { get; set; }
        public decimal? Creditline { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string? Remark { get; set; }
    }
}
