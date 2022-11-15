namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AccumulationPoint
    {
        public long Id { get; set; }
        public string? CustomerId { get; set; }
        public string? UserId { get; set; }
        public decimal? CurrentAccumulationPoint { get; set; }
        public decimal? NewAccumulationPoint { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CalDate { get; set; }
        public DateTime? ChangedDate { get; set; }
        public string? Remark { get; set; }
    }
}
