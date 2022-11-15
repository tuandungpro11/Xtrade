namespace TVSI.XTRADE.BO.API.Models.Model.Request.CustomerGroup;

public class CustomerGroupListRequest
{
    public int Id { get; set; }
    public int AccountType { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}