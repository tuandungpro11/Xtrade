using System.Globalization;

namespace TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot.ManageOrder;

public class InsideOrdersResponse
{
    public List<InsideOrdersDetailResponse> items { get; set; }
    public int totalItems { get; set; }
}

public class InsideOrdersDetailResponse
{
    public string id { get; set; }
    public int fisOrderId { get; set; }
    public string accountNo { get; set; }
    public string custCode => !string.IsNullOrEmpty(this.accountNo) ? (this.accountNo.Length > 6 ? this.accountNo[..6] : this.accountNo) : this.accountNo;
    public string secSymbol { get; set; }
    public string side { get; set; }
    public decimal volume { get; set; }
    public decimal price { get; set; }
    public string priceText => conPrice == "LO" ? (this.price * 1000).ToString(CultureInfo.InvariantCulture) : conPrice;
    public decimal matchedPrice { get; set; }
    public string conPrice { get; set; }
    public string channel { get; set; }
    public string channelText
    {
        get
        {
            return this.channel switch
            {
                "B" => "Counter/Broker",
                "M" => "TVSI Mobile",
                "S" => "Core ",
                "W" => "iTradeHome",
                "MG" => "Môi giới/Giao dịch",
                _ => this.channel
            };
        }
    }
    public string timeMatched { get; set; }
    public string timeCanceled { get; set; }
    public decimal orderValue { get; set; }
    public DateTime orderCancelRequestTime { get; set; }
    public string orderCancelRequestTimeText => orderCancelRequestTime.ToString("dd/MM/yyyy HH:mm:ss");
    public decimal totalCancelledVolume { get; set; }
    public decimal totalMatchedVolume { get; set; }
    public DateTime createdDate { get; set; }
    public string createdDateText => createdDate.ToString("dd/MM/yyyy HH:mm:ss");
    public int status { get; set; }
    public string statusName { get; set; }
}