namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class PushNewsNotify
    {
        public long Id { get; set; }
        public string? CustomerId { get; set; }
        public int? ServiceCode { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? PushDateTime { get; set; }
        public int? ConfirmStatus { get; set; }
        public string? Remark { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
