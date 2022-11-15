namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class LoanMarginInterest
    {
        public long AutoId { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? PostDate { get; set; }
        public int? NoDay { get; set; }
        public decimal? DebtAmt { get; set; }
        public double? InterestRate { get; set; }
        public decimal? InterestAmt { get; set; }
        public decimal? InterestTotalAmt { get; set; }
        public string? Remark { get; set; }
        public DateTime? SyncDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
    }
}
