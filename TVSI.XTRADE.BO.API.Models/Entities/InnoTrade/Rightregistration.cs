namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Rightregistration
    {
        public long Id { get; set; }
        public string? Accountno { get; set; }
        public string? Symbol { get; set; }
        public decimal? Price { get; set; }
        public decimal? Old { get; set; }
        public decimal? New { get; set; }
        public decimal? Payrate { get; set; }
        public DateTime? Closedate { get; set; }
        public DateTime? Transferfromdate { get; set; }
        public DateTime? Transfertodate { get; set; }
        public DateTime? Paydate { get; set; }
        public int? Xtype { get; set; }
        public string? Stocktype { get; set; }
        public decimal? Compunitbfxr { get; set; }
        public decimal? Compunitdep { get; set; }
        public decimal? Compunitwd { get; set; }
        public decimal? Compunitnew { get; set; }
        public decimal? Compunitconfirm { get; set; }
        public string? Delflag { get; set; }
        public string? Confirmflag { get; set; }
        public decimal? Roundup { get; set; }
        public string? Purpose { get; set; }
        public string? Remark { get; set; }
        public int? Status { get; set; }
        public decimal? Compamt { get; set; }
        public string? Newsharecode { get; set; }
        public DateTime? Rirtime { get; set; }
        public DateTime? Confirmdate { get; set; }
        public string? Refno { get; set; }
        public string? Rirno { get; set; }
        public DateTime? Xdate { get; set; }
    }
}
