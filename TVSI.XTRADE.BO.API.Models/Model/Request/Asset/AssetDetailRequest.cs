namespace TVSI.XTRADE.BO.API.Models.Model.Request.Asset;

public class AssetDetailRequest
{
    public string? AccountNo { get; set; }
    public string? CustomerId { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
}