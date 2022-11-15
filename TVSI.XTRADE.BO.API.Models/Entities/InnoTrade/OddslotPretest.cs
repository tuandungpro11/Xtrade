namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OddslotPretest
    {
        public int Oddslotid { get; set; }
        public string Contractno { get; set; } = null!;
        public string? Accountno { get; set; }
        public DateTime? Tradedate { get; set; }
        public DateTime? Duedate { get; set; }
        public string? Symbol { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Dateprice { get; set; }
        public decimal? Quantity { get; set; }
        public string? Buyer { get; set; }
        public int? Status { get; set; }
        public string? Reason { get; set; }
        public bool? Isnew { get; set; }
        public string? Userid { get; set; }
        public DateTime? Edittime { get; set; }
        public DateTime? Approvetime { get; set; }
        public string? Approveid { get; set; }
        public string? Customerid { get; set; }
        public string? Source { get; set; }
        public decimal? Value { get; set; }
        public decimal? Fee { get; set; }
        public decimal? Tax { get; set; }
    }
}
