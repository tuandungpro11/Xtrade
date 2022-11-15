namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AgreementRegistration
    {
        public long AgreementRegistrationId { get; set; }
        public long? AgreementFeatureId { get; set; }
        public string? CustomerId { get; set; }
        public string? ChannelId { get; set; }
        public string? ConfirmCode { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? CancelDate { get; set; }
        /// <summary>
        /// 0 Chưa ký,1 Đã ký ,2 Đang xử lý, 3 Chờ hủy, 4 Đã hủy
        /// </summary>
        public int? Status { get; set; }
        public string? ScanUrl { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
    }
}
