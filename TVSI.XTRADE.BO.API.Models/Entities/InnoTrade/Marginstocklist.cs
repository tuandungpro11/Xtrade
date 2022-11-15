namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Marginstocklist
    {
        public long Id { get; set; }
        public string Symbol { get; set; } = null!;
        public decimal Ratio { get; set; }
        public string? Description { get; set; }
        public string? Canbuy { get; set; }
    }
}
