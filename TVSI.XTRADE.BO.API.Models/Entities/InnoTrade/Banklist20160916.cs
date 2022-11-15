namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Banklist20160916
    {
        public int Id { get; set; }
        public string? BankNo { get; set; }
        public string? BankName { get; set; }
        public string? BankNameE { get; set; }
        public string? ShortName { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Bankcheqcode { get; set; }
        public string? SecCode { get; set; }
        public string? SecCodeBranch { get; set; }
        public string? WithdrawAccount { get; set; }
        public string? DepositAccount { get; set; }
        public decimal? MinTradingCash { get; set; }
        public decimal? MaxTradingCash { get; set; }
        public string? CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Remark { get; set; }
    }
}
