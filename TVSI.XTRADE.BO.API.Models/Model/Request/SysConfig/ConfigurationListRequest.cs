namespace TVSI.XTRADE.BO.API.Models.Model.Request.SysConfig;

public class ConfigurationListRequest
{
    public string? Name { get; set; }
    public int? PageIndex { get; set; } = 1;
    public int? PageSize { get; set; } = 20;
}