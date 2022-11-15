namespace TVSI.XTRADE.BO.API.Models.Model.Request.Logging;

public class LogLoginPasiotRequest: LogLoginPasiotExportRequest
{
    public int? PageIndex { get; set; } = 1;
    public int? PageSize { get; set; } = 20;
}