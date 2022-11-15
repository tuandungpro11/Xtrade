namespace TVSI.XTRADE.BO.API.Models.Model.Request.FileAttach;

public class FileAttachListRequest
{
    public string? CustomerId { get; set; }
    public string? BusinessType { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}