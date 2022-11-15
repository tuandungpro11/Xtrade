namespace TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot.Logging;

public class LogLoginResponse
{
    public string traceId { get; set; }
    public string userId { get; set; }
    public string accountNo { get; set; }
    public string controllerName { get; set; }
    public string actionName { get; set; }
    public string method { get; set; }
    public string clientIP { get; set; }
    public int timeExecute { get; set; }
    public DateTime createdDate { get; set; }
    public string createdDateText => createdDate.ToString("dd/MM/yyyy HH:mm:ss");
}