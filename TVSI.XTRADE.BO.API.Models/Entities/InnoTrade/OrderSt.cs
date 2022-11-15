namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderSt
    {
        public long Storderid { get; set; }
        public string? Symbol { get; set; }
        public string? Side { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Orderdate { get; set; }
        public decimal? Limitgainprice { get; set; }
        public decimal? Limitgainratio { get; set; }
        public decimal? Limitlossprice { get; set; }
        public decimal? Limitlossratio { get; set; }
    }
}
