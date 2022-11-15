namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderSplit
    {
        public long Ordersplitid { get; set; }
        public string? Accountno { get; set; }
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Side { get; set; }
    }
}
