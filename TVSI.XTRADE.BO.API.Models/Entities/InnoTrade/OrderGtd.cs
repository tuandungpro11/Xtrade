namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderGtd
    {
        public long Gtdorderid { get; set; }
        public long? Realid { get; set; }
        public long? Referid { get; set; }
        public string? Accountno { get; set; }
        public string? Symbol { get; set; }
        public string? Side { get; set; }
        public long? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Conprice { get; set; }
        public long? Cancelvolume { get; set; }
        public long? Cancelledvolume { get; set; }
        public DateTime? Begindate { get; set; }
        public DateTime? Enddate { get; set; }
        public string? Ordertime { get; set; }
        public string? Senttime { get; set; }
        public string? Cancelledtime { get; set; }
        public int? Orderstatus { get; set; }
        public string? Market { get; set; }
        public string? Marketstatus { get; set; }
        public string? Ordersource { get; set; }
        public int? Ordrejreason { get; set; }
        public string? Traderid { get; set; }
        public int? Type { get; set; }
    }
}
