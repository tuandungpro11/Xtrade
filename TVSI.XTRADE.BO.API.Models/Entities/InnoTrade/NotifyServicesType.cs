namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class NotifyServicesType
    {
        public int Id { get; set; }
        public int ServiceCode { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
