namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Portfolio
    {
        public long Id { get; set; }
        public string? Accountno { get; set; }
        public DateTime? Portfoliodate { get; set; }
        public string? Symbol { get; set; }
        public string? Trusteeid { get; set; }
        public decimal? Startvolume { get; set; }
        public decimal? Startprice { get; set; }
        public decimal? Avaivolume { get; set; }
        public decimal? Actualvolume { get; set; }
        public decimal? Avgprice { get; set; }
        public decimal? Todayrealize { get; set; }
        public int? Sectype { get; set; }
    }
}
