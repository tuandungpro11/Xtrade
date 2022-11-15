namespace TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot.ManageOrder;

public class OutsideOrdersResponse
{
    public List<OutsideOrderDetailsResponse> items { get; set; }
    public int totalItems { get; set; }
}

public class OutsideOrderDetailsResponse
{
    public string id { get; set; }
    public int fisOrderId { get; set; }
    public string accountNo { get; set; }
    public string custCode => !string.IsNullOrEmpty(this.accountNo) ? (this.accountNo.Length > 6 ? this.accountNo[..6] : this.accountNo) : this.accountNo;

    public string secSymbol { get; set; }
    public string side { get; set; }
    public decimal volume { get; set; }
    public decimal price { get; set; }
    public decimal priceText => this.price * 1000;
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
    public bool? pushStatus { get; set; }  // trạng thái đẩy lệnh ngoài giờ vào lệnh trong giờ = true tức là đã đẩy thành công
    public string pushStatusText
    {
        get
        {
            return this.pushStatus switch
            {
                true => "Thành công",
                _ => "Chưa đẩy/ đẩy thất bại"
            };
        }
    }
    public bool allowRePush { get; set; } // Cho phép đẩy lại lệnh
    public string errorCode { get; set; } //  Code đẩy lệnh không thành công
    public string errorMessage { get; set; } // Chi tiết lý do đẩy lệnh không thành công
}