namespace TVSI.XTRADE.BO.API.Models.Model.Request.Stock;

public class StockInfoRequest
{
    public string Symbol { get; set; }
    public int LanguageId { get; set; } = 1;
}