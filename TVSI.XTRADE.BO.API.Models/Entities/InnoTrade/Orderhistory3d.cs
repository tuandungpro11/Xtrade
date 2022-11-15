namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Orderhistory3d
    {
        public long Orderhistoryid { get; set; }
        public string? Accountno { get; set; }
        public string Orderdate { get; set; } = null!;
        public string? Ordertime { get; set; }
        public int Orderno { get; set; }
        public string? Side { get; set; }
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public decimal? Matchvolume { get; set; }
        public decimal? Matchprice { get; set; }
        public decimal? Fee { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Matchvalue { get; set; }
        public string? Orderstatus { get; set; }
        public int? Channel { get; set; }
        public int? Orderseqno { get; set; }
        public string? Secsymbolfront { get; set; }
        public string? Secsymbolreport { get; set; }
        public string? Board { get; set; }
        public int? Brokerno { get; set; }
        public int? Brokerorderno { get; set; }
        public string? Accttype { get; set; }
        public decimal? Pubvolume { get; set; }
        public int? Minorstatus { get; set; }
        public string? Enterid { get; set; }
        public string? Cancelid { get; set; }
        public string? Canceltime { get; set; }
        public int? Cancelvolume { get; set; }
        public string? Approveid { get; set; }
        public string? Approvetime { get; set; }
        public string? Conditionprice { get; set; }
        public string? Condition { get; set; }
        public string? Market { get; set; }
        public string? Trusteeid { get; set; }
        public string? Ordertype { get; set; }
        public int? Dealcount { get; set; }
        public string? Servicetype { get; set; }
        public string? Chguserid { get; set; }
        public string? Updateflag { get; set; }
        public string? Delflag { get; set; }
        public string? Putthroughflag { get; set; }
        public string? Branchid { get; set; }
        public string? Effecteddate { get; set; }
        public string? Customerid { get; set; }
        public decimal? Stopprice { get; set; }
        public decimal? Publishvol { get; set; }
    }
}
