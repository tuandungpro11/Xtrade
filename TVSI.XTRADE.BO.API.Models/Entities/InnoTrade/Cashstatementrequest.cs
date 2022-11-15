namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Cashstatementrequest
    {
        public long Id { get; set; }
        public string? Userid { get; set; }
        public string? Customerid { get; set; }
        public string? Accountno { get; set; }
        public string? Traderid { get; set; }
        public string? Source { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public DateTime? Requestdate { get; set; }
        public int? Status { get; set; }
        public bool? Isnew { get; set; }
        public DateTime? Processdate { get; set; }
        public string? Reason { get; set; }
    }
}
