namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Orderinfobackup
    {
        public int Id { get; set; }
        public string? Reforderid { get; set; }
        public string? Messagetype { get; set; }
        public long? Fisorderid { get; set; }
        public string? Secsymbol { get; set; }
        public string? Side { get; set; }
        public decimal? Price { get; set; }
        public string? Conprice { get; set; }
        public double? Oldprice { get; set; }
        public long? Volume { get; set; }
        public long? Executedvol { get; set; }
        public decimal? Executedprice { get; set; }
        public long? Cancelvolume { get; set; }
        public long? Cancelledvolume { get; set; }
        public string? Account { get; set; }
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
        public double? Stopprice { get; set; }
        public long? Publishvol { get; set; }
        public long? ParentId { get; set; }
        /// <summary>
        /// -1: Không sưa - 0: Đang sửa - 2: Đã sửa - 3: Từ chối sửa
        /// </summary>
        public int? Changestatus { get; set; }
        public string? Changerejreason { get; set; }
        /// <summary>
        /// 0: Lệnh thường - 1: GDTT cùng công ty - 2: GDTT khác công ty
        /// </summary>
        public int? Putthroughflag { get; set; }
        /// <summary>
        /// 0: Không show/check số dư/lệnh đối ứng - 1: Được phép show/check số dư/lệnh đối ứng
        /// </summary>
        public int? AllowShow { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
        public int? OrgId { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
