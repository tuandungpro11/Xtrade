namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderBasketinfo
    {
        public int Id { get; set; }
        public int Basketid { get; set; }
        public string? Secsymbol { get; set; }
        public string? Side { get; set; }
        public decimal? Price { get; set; }
        public string Conprice { get; set; } = null!;
        public long? Volume { get; set; }
        public string? Account { get; set; }
        public string? Transtime { get; set; }
        public string? Confirmno { get; set; }
        public short? Sourceid { get; set; }
        public string? Market { get; set; }
        public string? Marketstatus { get; set; }
        public string? Ordersource { get; set; }
        public double? Value { get; set; }
        public string Customerid { get; set; } = null!;
        public DateTime? Createdate { get; set; }
        public string? Createby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string? Modifiedby { get; set; }
        public string? Remark { get; set; }
    }
}
