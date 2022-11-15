namespace TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot.ManageOrder;

public class OrderGTDResponse
{
    public int id { get; set; }
    public string source { get; set; }
    public string sourceText
    {
        get
        {
            return this.source switch
            {
                "B" => "Counter/Broker",
                "M" => "TVSI Mobile",
                "S" => "Core ",
                "W" => "iTradeHome",
                "MG" => "Môi giới/Giao dịch",
                _ => this.source
            };
        }
    }
    public string accountNo { get; set; }
    public string custCode => !string.IsNullOrEmpty(this.accountNo) ? (this.accountNo.Length > 6 ? this.accountNo[..6] : this.accountNo) : this.accountNo;
    public string side { get; set; }
    public string stockSymbol { get; set; }
    public string conditionPrice { get; set; }
    public decimal price { get; set; }
    public decimal priceText => price * 1000;
    public decimal volume { get; set; }
    public decimal? volumeMatched { get; set; }
    public decimal? volumeCancelled { get; set; }
    public decimal? lastMatchedPrice { get; set; }
    public decimal? lastMatchedPriceText => (lastMatchedPrice ?? 0) * 1000;
    public DateTime fromDate { get; set; }
    public string fromDateText => fromDate.ToString("dd/MM/yyyy");
    public DateTime toDate { get; set; }
    public string toDateText  => toDate.ToString("dd/MM/yyyy");
    public int matchingType { get; set; }
    public DateTime createdDate { get; set; }
    public string createdDateText  => this.createdDate.ToString("dd/MM/yyyy HH:mm:ss");
    public DateTime? lastModifiedDate { get; set; }
    public string lastModifiedDateText  => lastModifiedDate != null ? lastModifiedDate?.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
    public DateTime? lastProcessedDate { get; set; }
    public string lastProcessedDateText => lastProcessedDate != null ? lastProcessedDate?.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
    public DateTime? cancelledDate { get; set; }
    public string cancelledDateText => cancelledDate != null ? cancelledDate?.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
    public DateTime? lastMatchingDate { get; set; }
    public string lastMatchingDateText => lastMatchingDate != null ? lastMatchingDate?.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
    public int status { get; set; }
    public string coreOrderStatus { get; set; }
    public string rejectedReasonCode { get; set; }
}