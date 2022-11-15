namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Cashbalance
    {
        public long Id { get; set; }
        public string Accountno { get; set; } = null!;
        public string? Accountno2 { get; set; }
        public DateTime Asofdate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Buycredit { get; set; }
        public decimal? Wtr { get; set; }
        public decimal? Dividend { get; set; }
        public decimal? Overdue { get; set; }
        public string? TransType1 { get; set; }
        public string? BookHolding { get; set; }
        public int? Coretype { get; set; }
    }
}
