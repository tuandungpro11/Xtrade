namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderGroup
    {
        public long Grouporderid { get; set; }
        public string? Accountno { get; set; }
        public string? Side { get; set; }
        public decimal? Sumorder { get; set; }
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Changevolume { get; set; }
        public decimal? Price { get; set; }
        public decimal? Changeprice { get; set; }
        public string? Orderdate { get; set; }
    }
}
