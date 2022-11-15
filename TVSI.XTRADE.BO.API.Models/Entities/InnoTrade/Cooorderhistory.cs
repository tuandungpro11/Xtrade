namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Cooorderhistory
    {
        public long Cooorderhistoryid { get; set; }
        public long? Gtdorderid { get; set; }
        public long? Proorderid { get; set; }
        public long? Tsorderid { get; set; }
        public long? Storderid { get; set; }
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Side { get; set; }
        public int? Status { get; set; }
        public string? Orderdate { get; set; }
        public decimal? Ordertime { get; set; }
        public decimal? Matchedvolume { get; set; }
        public decimal? Matchedprice { get; set; }
    }
}
