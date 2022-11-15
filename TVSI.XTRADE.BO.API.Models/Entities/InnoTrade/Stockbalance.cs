namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Stockbalance
    {
        public long Id { get; set; }
        public string Accountno { get; set; } = null!;
        public string? Accountno2 { get; set; }
        public DateTime? Asofdate { get; set; }
        public string? Stocksymbol { get; set; }
        public string? Stocktype { get; set; }
        public decimal? Quantity { get; set; }
    }
}
