namespace TVSI.XTRADE.BO.API.Models.Model.Request.Bank
{
    public class BankExportRequest
    {
        public string? BankNo { get; set; }
        public string? BankName { get; set; }
        public string? BankNameEn { get; set; }
        public string? ShortName { get; set; }
        public int Status { get; set; }
        public string? Bankcheqcode { get; set; }
        public string? SecCode { get; set; }
        public string? SecCodeBranch { get; set; }
    }
}
