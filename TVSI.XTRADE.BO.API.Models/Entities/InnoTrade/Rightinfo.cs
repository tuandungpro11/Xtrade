namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Rightinfo
    {
        public long Id { get; set; }
        public string? Symbol { get; set; }
        public DateTime? Xdate { get; set; }
        public decimal? Old { get; set; }
        public decimal? New { get; set; }
        public decimal? Price { get; set; }
        public decimal? Roundup { get; set; }
        public DateTime? Confirmdate { get; set; }
        public int? Xtype { get; set; }
        public string? Stocktype { get; set; }
        public string? Reftype { get; set; }
        public long? Seqno { get; set; }
        public string? Newsharecode { get; set; }
        public DateTime? TransferLimitDate { get; set; }
    }
}
