namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Stocktran
    {
        public long Id { get; set; }
        public string Accountno { get; set; } = null!;
        public string? Accountno2 { get; set; }
        public DateTime? Transdate { get; set; }
        public DateTime? Duedate { get; set; }
        public string? Symbol { get; set; }
        public string? Reftype { get; set; }
        public string? Stocktype { get; set; }
        public string? TransNo { get; set; }
        public string? TransType1 { get; set; }
        public string? TransType2 { get; set; }
        public string? Custtype { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string? Remark { get; set; }
        public string? Userid { get; set; }
        public string? TranDateTime { get; set; }
        public string? Authid { get; set; }
        public string? ApprDateTime { get; set; }
        public DateTime? SynDateTime { get; set; }
        public string? SeqNo { get; set; }
    }
}
