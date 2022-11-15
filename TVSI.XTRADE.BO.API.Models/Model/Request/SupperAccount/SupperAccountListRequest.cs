
namespace TVSI.XTRADE.BO.API.Models.Model.Request.SupperAccount
{
    public class SupperAccountListRequest
    {
        public string? UserId { get; set; }
        public string? CustomerId { get; set; }
        public string? BranchId { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
