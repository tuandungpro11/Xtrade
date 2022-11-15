namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Cashtran
    {
        public long Id { get; set; }
        public string Accountno { get; set; } = null!;
        public string? Accountno2 { get; set; }
        public DateTime? Transdate { get; set; }
        public DateTime? Duedate { get; set; }
        public string? TransNo { get; set; }
        public string? TransType1 { get; set; }
        public string? TransType2 { get; set; }
        public string? Symbol { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public decimal? Remain { get; set; }
        public decimal? Firstremain { get; set; }
        public decimal? Lastremain { get; set; }
        public decimal? Amount { get; set; }
        public string? Remark { get; set; }
        public string? Remark2 { get; set; }
        public string? Userid { get; set; }
        public string? TranDateTime { get; set; }
        public string? Authid { get; set; }
        public string? ApprDateTime { get; set; }
        public DateTime? SynDateTime { get; set; }
        public string? BookHolding { get; set; }
        public int? Coretype { get; set; }
        public int? Cod { get; set; }
    }
}
