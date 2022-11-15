namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Accountagent
    {
        public string AccountNo { get; set; } = null!;
        public string AgentId { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActived { get; set; }
    }
}
