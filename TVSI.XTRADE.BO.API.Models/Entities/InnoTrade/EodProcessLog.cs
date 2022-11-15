namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class EodProcessLog
    {
        public long Id { get; set; }
        public string? Table { get; set; }
        public DateTime? ProcessDate { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int? Status { get; set; }
        public string? Message { get; set; }
        public string? FullMessage { get; set; }
        public int? NumberOfRowFromTradeDbBefore { get; set; }
        public int? NumberOfRowFromTradeDbAfter { get; set; }
        public int? NumberOfRowFromCore { get; set; }
    }
}
