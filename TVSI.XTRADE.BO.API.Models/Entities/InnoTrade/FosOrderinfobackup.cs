namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class FosOrderinfobackup
    {
        public long Id { get; set; }
        public long? OrgId { get; set; }
        public long? Parentid { get; set; }
        public string? Reforderid { get; set; }
        public string? Parentreforderid { get; set; }
        public string? Coreorderid { get; set; }
        public string? Orgcoreorderid { get; set; }
        public short? Exectranstype { get; set; }
        public string? Messagetype { get; set; }
        public DateTime? Transtime { get; set; }
        public short? Orderstatus { get; set; }
        public short? Sourceid { get; set; }
        public string? Ordrejreason { get; set; }
        public string? Orderrorreason { get; set; }
        public string? Customerno { get; set; }
        public string? Account { get; set; }
        public string? Market { get; set; }
        public string? Exchange { get; set; }
        public string? ExchangeSessionid { get; set; }
        public string? Secsymbol { get; set; }
        public string? Side { get; set; }
        public double? Price { get; set; }
        public string? Conprice { get; set; }
        public long? Volume { get; set; }
        public long? Minvolume { get; set; }
        public decimal? Stopprice { get; set; }
        public long? Publishvol { get; set; }
        public double? Commission { get; set; }
        public double? Tax { get; set; }
        public string? Currency { get; set; }
        public long? Executedvolume { get; set; }
        public double? Executedprice { get; set; }
        public DateTime? Executedtime { get; set; }
        public int? Numofexecution { get; set; }
        public long? Cancelvolume { get; set; }
        public long? Cancelledvolume { get; set; }
        public DateTime? Cancelledtime { get; set; }
        public short? Cancelstatus { get; set; }
        public string? Cancelledrejreason { get; set; }
        public string? Cancellederrorreason { get; set; }
        public int? Cancelledsourceid { get; set; }
        public string? Portorclient { get; set; }
        public string? Ordersource { get; set; }
        public string? Traderid { get; set; }
        public string? Customerid { get; set; }
        public string? Targetcustomerid { get; set; }
        public DateTime? Changetime { get; set; }
        public short? Changestatus { get; set; }
        public int? Changesourceid { get; set; }
        public string? Changerejreason { get; set; }
        public string? Changeerrorreason { get; set; }
        public int? Putthroughflag { get; set; }
        public string? Tradeby { get; set; }
        public double? Tradebyvalue { get; set; }
        public string? Position { get; set; }
        public short? Auctionorder { get; set; }
        public int? Allowshow { get; set; }
        public short? Isnew { get; set; }
        public long? Sequence { get; set; }
        public string? Metadata { get; set; }
        public DateTime? Createtime { get; set; }
        public string? Createby { get; set; }
        public DateTime? Modifytime { get; set; }
        public string? Modifyby { get; set; }
        public string? Remark { get; set; }
        public DateTime? Backuptime { get; set; }
        public string? Backupby { get; set; }
        public string? Orgordersource { get; set; }
        public int? OrderType { get; set; }
        public int? StopOrderType { get; set; }
        public DateTime? EffectiveTime { get; set; }
        public string? TriggerPriceDirection { get; set; }
        public decimal? PegOffsetValue { get; set; }
        public int? PegMoveType { get; set; }
        public int? PegOffsetType { get; set; }
        public int? PegLimitType { get; set; }
        public decimal? TriggerPrice { get; set; }
        public string? CoreOrderStatus { get; set; }
        public long? CooparentId { get; set; }
        public string? CooorderId { get; set; }
        public decimal? StopPrice4Bb { get; set; }
        public decimal? ProfitStep { get; set; }
        public decimal? LossStep { get; set; }
        public decimal? StopStep { get; set; }
        public decimal? StopToler { get; set; }
    }
}
