namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage
{
    public class CustomerAccountListRequest
    {
        public string? UserId { get; set; }
        public string? CustomerId { get; set; }
        public int Status { get; set; }
        public string? BranchId { get; set; }
        public int CustomerType { get; set; }
        public int CustomerGroupId { get; set; }
        public byte IsLike { get; set; }
        public string? BeginDate { get; set; }
        public string? EndDate { get; set; }
        public string? ByUser { get; set; }
        public string? IdentityCard { get; set; }
        public string? CustomerName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
