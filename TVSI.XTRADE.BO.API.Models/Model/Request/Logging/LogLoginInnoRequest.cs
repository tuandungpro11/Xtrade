namespace TVSI.XTRADE.BO.API.Models.Model.Request.Logging
{
    public class LogLoginInnoRequest
    {
        public int Status { get; set; }
        public string? Channel { get; set; }
        public string? CustomerId { get; set; }
        public string? BeginDate { get; set; }
        public string? EndDate { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
