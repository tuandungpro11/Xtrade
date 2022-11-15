namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Tradetrnhistbackup
    {
        public long Id { get; set; }
        public string? Accountno { get; set; }
        public string? Accountno2 { get; set; }
        public DateTime? Tradedate { get; set; }
        public DateTime? Duedate { get; set; }
        public string? Referno { get; set; }
        public int? Orderno { get; set; }
        public string? Symbol { get; set; }
        public string? Side { get; set; }
        public int? Unit { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Commission { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Grossamount { get; set; }
    }
}
