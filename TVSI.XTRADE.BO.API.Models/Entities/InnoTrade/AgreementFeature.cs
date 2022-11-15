namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AgreementFeature
    {
        public long AgreementFeatureId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        /// <summary>
        /// 0 – Chưa áp dụng, 1 Đang áp dụng
        /// </summary>
        public int? Activation { get; set; }
        /// <summary>
        /// 0: không bắt buộc, 1 bắt buộc phải ký
        /// </summary>
        public int? IsRequired { get; set; }
        public string? AgreementItems { get; set; }
        public string? AgreementUrl { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
    }
}
