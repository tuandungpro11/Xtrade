using System.Globalization;
using TVSI.XTRADE.BO.API.Common;

namespace TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot.ManageOrder;

public class OrdersHistResponse
{
    public int rowCount { get; set; }
    public string customerId { get; set; }
    public string accountNo { get; set; }
    public string secSymbol { get; set; }
    public int orderNo { get; set; }
    public string side { get; set; }
    public decimal price { get; set; }
    public decimal volume { get; set; }
    public string condition { get; set; }
    public string conditionPrice { get; set; }
    public string orderType { get; set; }
    public string enterID { get; set; }
    public string orderDate { get; set; }
    public string? orderDateText => this.orderDate.ConvertToDateString();
    public string orderTime { get; set; }
    public string orderStatus { get; set; }
    public string orderStatusName { get; set; }
    public decimal matchVolume { get; set; }
    public string cancelID { get; set; }
    public string cancelTime { get; set; }
    public decimal cancelVolume { get; set; }
    public string serviceType { get; set; }
    public int orderSeqNo { get; set; }
    public decimal matchValue { get; set; }
    public decimal matchValueDisplay => matchValue * 1000;
    public decimal matchPrice { get; set; }
    public string trusteeID { get; set; }
    public decimal pubVolume { get; set; }
    public decimal comm { get; set; }
    public decimal tax { get; set; }
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
    public string effectedDate { get; set; }

    public string? effectedDateText => effectedDate.ConvertToDateString();

    public decimal totalMoney
    {
        get
        {
            if (this.side == "B")
            {
                return this.matchValueDisplay + this.comm;
            }

            return this.matchValueDisplay - this.comm - this.tax;
        }
    }
}