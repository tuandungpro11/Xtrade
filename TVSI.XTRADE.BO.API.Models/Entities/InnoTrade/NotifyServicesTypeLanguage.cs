namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class NotifyServicesTypeLanguage
    {
        public int ServiceCode { get; set; }
        public int LangId { get; set; }
        public string? ServiceName { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
