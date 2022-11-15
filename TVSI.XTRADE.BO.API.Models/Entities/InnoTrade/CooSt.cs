namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CooSt
    {
        public int Id { get; set; }
        public int? CooId { get; set; }
        public decimal? RefPrice { get; set; }
        public decimal? TakeProfitAbs { get; set; }
        public decimal? TakeProfitPer { get; set; }
        public decimal? TakeProfitTriggerPrice { get; set; }
        public decimal? StopLossAbs { get; set; }
        public decimal? StopLossPer { get; set; }
        public decimal? StopLossTriggerPrice { get; set; }
    }
}
