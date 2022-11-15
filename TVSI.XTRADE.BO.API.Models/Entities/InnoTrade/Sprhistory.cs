namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Sprhistory
    {
        public long Id { get; set; }
        public string? ContractNo { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ReAmount { get; set; }
        public decimal? RemainAmount { get; set; }
        public DateTime? TradeDate { get; set; }
        public decimal? TradeValue { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public string? Source { get; set; }
        public string? TraderId { get; set; }
        public DateTime? Sprdate { get; set; }
        public string? UserId { get; set; }
        public DateTime? EditTime { get; set; }
        public DateTime? ApproveTime { get; set; }
        public string? ApproveId { get; set; }
        public string? Remark { get; set; }
        public decimal? Interest { get; set; }
        public int? NumOfDate { get; set; }
        public DateTime? FundingDate { get; set; }
        public short? PaymentNo { get; set; }
        public string? RefContractNo { get; set; }
    }
}
