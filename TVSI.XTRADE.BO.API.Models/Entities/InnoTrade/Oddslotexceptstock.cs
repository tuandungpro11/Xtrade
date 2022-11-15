namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Oddslotexceptstock
    {
        public long Id { get; set; }
        public string Symbol { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string? MarketId { get; set; }
        public string? Description { get; set; }
        public short IncludeType { get; set; }
    }
}
