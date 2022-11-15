namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class DealhistoryBackup20191016
    {
        public long Dealhistoryid { get; set; }
        public string? Confirmno { get; set; }
        public int? Orderseqno { get; set; }
        public string? Symbol { get; set; }
        public string? Side { get; set; }
        public int? Brokerno { get; set; }
        public int? Orderno { get; set; }
        public decimal? Dealvolume { get; set; }
        public decimal? Dealprice { get; set; }
        public string? Dealdate { get; set; }
        public string? Dealtime { get; set; }
        public string? Acctype { get; set; }
        public string? Board { get; set; }
        public string? Servicetype { get; set; }
        public string? Cancelflag { get; set; }
        public string? Updateflag { get; set; }
        public string? Putthroughflag { get; set; }
        public DateTime? Inserttime { get; set; }
        public decimal? Sumcomm { get; set; }
        public decimal? Sumvat { get; set; }
    }
}
