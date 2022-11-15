namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Changeaccountinfo
    {
        public int Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public string OldContent { get; set; } = null!;
        public string NewContent { get; set; } = null!;
        public int Type { get; set; }
        public int Status { get; set; }
        public string? Reason { get; set; }
    }
}
