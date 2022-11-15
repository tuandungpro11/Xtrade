namespace TVSI.XTRADE.BO.API.Models.Entities.Demo
{
    public class ErrorCode
    {
        [Key]
        public string ErrCode { get; set; } = null!;
        public string? ErrMsgVi { get; set; }
        public string? ErrMsgEn { get; set; }
        public string? Channel { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
