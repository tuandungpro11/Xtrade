namespace TVSI.XTRADE.BO.API.Models.Model.Request.Logging;

public class LogLoginPasiotExportRequest
{
    public string? UserId { get; set; }
    public string? ControllerName { get; set; } = "system";
    public string? ActionName { get; set; } = "login";
    public string? ClientIP { get; set; }
    public string? Method { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
}