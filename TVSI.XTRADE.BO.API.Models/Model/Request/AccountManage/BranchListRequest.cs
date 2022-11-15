namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage
{
    public class BranchListRequest
    {
        public string? BranchId { get; set; }
        public int Active { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
