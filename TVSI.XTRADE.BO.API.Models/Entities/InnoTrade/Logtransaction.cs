namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Logtransaction
    {
        public long Id { get; set; }
        public DateTime? Tradetime { get; set; }
        public string? Accountid { get; set; }
        public string? Type { get; set; }
        public string? Side { get; set; }
        public string? Secsymbol { get; set; }
        public double? Price { get; set; }
        public string? Conprice { get; set; }
        public double? Oldprice { get; set; }
        public long? Volume { get; set; }
        public long? Executedvol { get; set; }
        public double? Executedprice { get; set; }
        public long? Cancelledvolume { get; set; }
        public string? Ordrejreason { get; set; }
        public short? Sourceid { get; set; }
        public string? Market { get; set; }
        public string? Reforderid { get; set; }
        public long? Fisorderid { get; set; }
        public string? Customerid { get; set; }
        public int? Ordertype { get; set; }
        public long? Publishvol { get; set; }
        public double? Stopprice { get; set; }
    }
}
