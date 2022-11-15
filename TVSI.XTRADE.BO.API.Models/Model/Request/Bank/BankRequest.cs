namespace TVSI.XTRADE.BO.API.Models.Model.Request.Bank
{
    public class BankRequest
    {
        public int Id { get; set; } = 0;
        public string BankNo { get; set; }
        public string BankName { get; set; }
        public string BankNameEn { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public string Bankcheqcode { get; set; }
        public string SecCode { get; set; }
        public string SecCodeBranch { get; set; }
        public string? WithdrawAccount { get; set; }
        public string? DepositAccount { get; set; }
        public decimal MinTradingCash { get; set; }
        public decimal MaxTradingCash { get; set; }
        public string? Remark { get; set; }    
        public string? UserId { get; set; }
        public decimal TransferFee { get; set; }
    }
}
