namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Agentcustomer
    {
        public int Id { get; set; }
        public string AccountId { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? Authorize { get; set; }
        public string? OldNew { get; set; }
        public int AgentId { get; set; }

        public virtual Customer Account { get; set; } = null!;
    }
}
