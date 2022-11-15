namespace TVSI.XTRADE.BO.API.Models.Model.Request.FileAttach;

public class FileAttachDownloadRequest
{
    [Required]
    public string? FileUrl { get; set; }
    [Required]
    public string? BusinessType { get; set; }
}