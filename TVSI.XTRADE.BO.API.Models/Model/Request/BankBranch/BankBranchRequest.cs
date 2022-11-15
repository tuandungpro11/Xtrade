namespace TVSI.XTRADE.BO.API.Models.Model.Request.BankBranch
{
    public class BankBranchRequest
    {
        public int Id { get; set; } = 0;
        public string BankNo { get; set; }
        public string BranchNo { get; set; }
        public string BranchName { get; set; }
        public string BranchNameEn { get; set; }
        public string ShortBranchName { get; set; }
        public int Status { get; set; }
        public string? Remark { get; set; }
        public string UserId { get; set; }
    }
}
