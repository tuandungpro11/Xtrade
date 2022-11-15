namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CustomerNotifySetting
    {
        public string CustomerId { get; set; } = null!;
        public int ServiceCode { get; set; }
        public string? MethodCode { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
