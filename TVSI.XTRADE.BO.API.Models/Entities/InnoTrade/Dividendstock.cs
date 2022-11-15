namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Dividendstock
    {
        public long Id { get; set; }
        public string? Accountno { get; set; }
        public DateTime? Xdate { get; set; }
        public DateTime? Refdate { get; set; }
        public string? Sharecode { get; set; }
        public int? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Purpose { get; set; }
        public decimal? Oldvalue { get; set; }
        public decimal? Newvalue { get; set; }
        public decimal? Roundup { get; set; }
        public string? Roundupflag { get; set; }
        public string? Xtype { get; set; }
        public string? Remark { get; set; }
    }
}
