namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderT
    {
        public long Tsorderid { get; set; }
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Side { get; set; }
        public string? Orderdate { get; set; }
        public decimal? Downboundprice { get; set; }
        public decimal? Upboundprice { get; set; }
    }
}
