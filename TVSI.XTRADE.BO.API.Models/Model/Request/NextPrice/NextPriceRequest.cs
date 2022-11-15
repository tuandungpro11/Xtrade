namespace TVSI.XTRADE.BO.API.Models.Model.Request.NextPrice;

public class NextPriceRequest
{
    public string Symbol { get; set; }
    public float FloorPrice { get; set; }
    public float CellingPrice { get; set; }
    public float RefPrice { get; set; }
    public string Market { get; set; }
}