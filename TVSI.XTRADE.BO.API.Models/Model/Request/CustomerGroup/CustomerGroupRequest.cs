namespace TVSI.XTRADE.BO.API.Models.Model.Request.CustomerGroup;

public class CustomerGroupRequest
{
    public int Id { get; set; } = 0;
    public string Name { get; set; }
    public string? Description { get; set; }
    public int AccountType { get; set; }
    public byte Active { get; set; }
    public int Level { get; set; }
}