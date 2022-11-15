namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Advancehistory
    {
        public int Advancehistoryid { get; set; }
        public string? Userid { get; set; }
        public string? Accountno { get; set; }
        public string? Contractno { get; set; }
        public decimal? Cashamount { get; set; }
        public decimal? Grossadvance { get; set; }
        public decimal? Netadvance { get; set; }
        public int? Advancestatus { get; set; }
        public int? Tradetype { get; set; }
        public string? Reason { get; set; }
        public decimal? Advancefee { get; set; }
        public decimal? Tax { get; set; }
        public DateTime? Advancedate { get; set; }
        public DateTime? Tradedate { get; set; }
        public DateTime? Duedate { get; set; }
        public string? Source { get; set; }
        public string? TraderId { get; set; }
        public DateTime? Edittime { get; set; }
        public DateTime? Approvetime { get; set; }
        public string? Approveid { get; set; }
        public string? Customerid { get; set; }
        public string? SequenceNumber { get; set; }
        public string? PreferenceNumber { get; set; }
    }
}
