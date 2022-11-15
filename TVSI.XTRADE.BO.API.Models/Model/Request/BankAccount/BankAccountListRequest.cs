namespace TVSI.XTRADE.BO.API.Models.Model.Request.BankAccount
{
    public class BankAccountListRequest
    {
        public string? UserId { get; set; }
        public string? CustomerId { get; set; }
        public long BankAccountId { get; set; }
        public string? BankAccount { get; set; }
        public byte IsLike { get; set; }
        public int Status { get; set; }
        public string? ToDate { get; set; } = string.Empty;
        public string? FromDate { get; set; } = string.Empty;
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
