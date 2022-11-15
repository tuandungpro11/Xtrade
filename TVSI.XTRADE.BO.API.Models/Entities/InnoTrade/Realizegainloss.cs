namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Realizegainloss
    {
        public long Realizeglid { get; set; }
        public string? Accountno { get; set; }
        public DateTime? Tradedate { get; set; }
        public string? Symbol { get; set; }
        public decimal? Buyprice { get; set; }
        public decimal? Sellprice { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Gainloss { get; set; }
        public decimal? Percentgl { get; set; }
        public DateTime? Syncdate { get; set; }
        public string? SeqNo { get; set; }
        public string? BookHolding { get; set; }
        public int? Coretype { get; set; }
    }
}
