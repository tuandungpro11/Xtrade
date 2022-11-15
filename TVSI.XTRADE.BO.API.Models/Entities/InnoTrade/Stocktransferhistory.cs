namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Stocktransferhistory
    {
        public long Id { get; set; }
        public string Contractno { get; set; } = null!;
        public string? Userid { get; set; }
        public string Accountno { get; set; } = null!;
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public DateTime? Transferdate { get; set; }
        public string? Receiver { get; set; }
        public int? Status { get; set; }
        public int? Feetype { get; set; }
        public decimal? Fee { get; set; }
        public string? Reason { get; set; }
        public string? Remark { get; set; }
        public string? Customerid { get; set; }
        public DateTime? Edittime { get; set; }
        public DateTime? Approvetime { get; set; }
        public string? Approveid { get; set; }
        public string? Traderid { get; set; }
        public string? Source { get; set; }
    }
}
