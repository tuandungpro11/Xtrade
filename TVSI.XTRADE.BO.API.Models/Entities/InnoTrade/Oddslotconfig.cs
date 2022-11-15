namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Oddslotconfig
    {
        public long Id { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MarketId { get; set; } = null!;
        public decimal? Ratio { get; set; }
        public string? Description { get; set; }
    }
}
