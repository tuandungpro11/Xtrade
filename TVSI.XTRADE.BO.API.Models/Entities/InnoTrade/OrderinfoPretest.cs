namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderinfoPretest
    {
        public int Id { get; set; }
        public string? Reforderid { get; set; }
        public string? Messagetype { get; set; }
        public long? Fisorderid { get; set; }
        public string? Secsymbol { get; set; }
        public string? Side { get; set; }
        public double? Price { get; set; }
        public string? Conprice { get; set; }
        public double? Oldprice { get; set; }
        public long? Volume { get; set; }
        public long? Executedvol { get; set; }
        public double? Executedprice { get; set; }
        public long? Cancelvolume { get; set; }
        public long? Cancelledvolume { get; set; }
        public string? Account { get; set; }
        public string? Oldaccount { get; set; }
        public short? Exectranstype { get; set; }
        public string? Transtime { get; set; }
        public string? Matchedtime { get; set; }
        public string? Cancelledtime { get; set; }
        public short? Orderstatus { get; set; }
        public short? Cancelstatus { get; set; }
        public int? Ordrejreason { get; set; }
        public int? Cancelledrejreason { get; set; }
        public string? Confirmno { get; set; }
        public string? Cancelledconfirmno { get; set; }
        public short? Sourceid { get; set; }
        public short? Cancelledsourceid { get; set; }
        public string? Exectype { get; set; }
        public string? Cancelledexectype { get; set; }
        public string? Portorclient { get; set; }
        public string? Market { get; set; }
        public string? Marketstatus { get; set; }
        public string? Ordersource { get; set; }
        public bool? Isnew { get; set; }
        public long? Sequence { get; set; }
        public int? Numofmatch { get; set; }
        public double? Value { get; set; }
        public double? Commission { get; set; }
        public double? Tax { get; set; }
        public string? TraderId { get; set; }
        public string? Customerid { get; set; }
        public string? Errorreason { get; set; }
        public bool? Issentemail { get; set; }
        public double? Stopprice { get; set; }
        public long? Publishvol { get; set; }
    }
}
