namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderPrior
    {
        public long Proorderid { get; set; }
        public string? Side { get; set; }
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Orderdate { get; set; }
        public bool? Ismatchall { get; set; }
    }
}
