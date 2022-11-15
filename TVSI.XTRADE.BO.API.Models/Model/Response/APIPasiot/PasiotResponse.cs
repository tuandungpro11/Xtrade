namespace TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot;

public class PasiotResponse
{
    public string retCode { get; set; } = "-1";
    public string? retMsg { get; set; }
    public object? retData { get; set; } = null;
}