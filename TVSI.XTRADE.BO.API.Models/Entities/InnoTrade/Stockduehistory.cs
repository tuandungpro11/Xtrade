namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Stockduehistory
    {
        public long Id { get; set; }
        public string? Accountno { get; set; }
        public string? Symbol { get; set; }
        public decimal? Available { get; set; }
        public decimal? Mktvalue { get; set; }
        public decimal? Wtr { get; set; }
        public decimal? Wts { get; set; }
        public decimal? Net { get; set; }
        public decimal? WtrT1 { get; set; }
        public decimal? WtsT1 { get; set; }
        public decimal? WtrT2 { get; set; }
        public decimal? WtsT2 { get; set; }
        public decimal? WtrT3 { get; set; }
        public decimal? WtsT3 { get; set; }
        public decimal? Avgprice { get; set; }
        public DateTime? Stockduedate { get; set; }
    }
}
