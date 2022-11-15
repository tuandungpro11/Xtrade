namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AuditAuthentication
    {
        public long Id { get; set; }
        public string? CustomerId { get; set; }
        public string? FeatureCode { get; set; }
        public int? FeatureActionType { get; set; }
        public string? RefId { get; set; }
        public string? Ip { get; set; }
        public string? UniqueId { get; set; }
        public string? Metadata { get; set; }
        public string? Cadata { get; set; }
        public string? ConfirmCode { get; set; }
        public string? AuthenId { get; set; }
        public int? IsConfirm { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Remark { get; set; }
        public string? CoreOrderId { get; set; }
    }
}
