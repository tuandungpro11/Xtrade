namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage
{
    public class CustomerEmailListRequest
    {
        public string? CustomerId { get; set; }
        public int IsActive { get; set; }
        public string? Email { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
