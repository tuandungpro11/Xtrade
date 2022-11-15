namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class NotifyDeviceId
    {
        public long Id { get; set; }
        public string? CustomerId { get; set; }
        public string? DeviceId { get; set; }
        public string? Channel { get; set; }
        public string? Remark { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? RegisteredConfirmation { get; set; }
    }
}
