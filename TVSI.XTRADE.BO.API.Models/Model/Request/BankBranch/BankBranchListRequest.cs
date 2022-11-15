namespace TVSI.XTRADE.BO.API.Models.Model.Request.BankNo
{
    public class BankBranchListRequest
    {
        public string? BankNo { get; set; }
        public string? BranchNo { get; set; }
        public string? BranchName { get; set; }
        public string? BranchNameEn { get; set; }
        public string? ShortBranchName { get; set; }
        public int Status { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
