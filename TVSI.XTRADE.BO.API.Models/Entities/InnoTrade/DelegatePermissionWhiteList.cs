namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class DelegatePermissionWhiteList
    {
        public int Id { get; set; }
        public string? AgentId { get; set; }
        public int? AgentType { get; set; }
        public string? AccountNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Remark { get; set; }
    }
}
