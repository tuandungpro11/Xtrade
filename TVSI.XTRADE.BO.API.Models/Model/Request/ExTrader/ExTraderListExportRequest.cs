namespace TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader;

public class ExTraderListExportRequest
{
    public long ExTraderId { get; set; }
    public string? TraderId { get; set; }
    public string? Branch { get; set; }
    public int TraderType { get; set; }
    public int Status { get; set; }
    public string? ToDate { get; set; }
    public string? FromDate { get; set; }
}