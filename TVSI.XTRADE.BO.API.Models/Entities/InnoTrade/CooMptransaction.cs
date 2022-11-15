namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CooMptransaction
    {
        public int Id { get; set; }
        public DateTime? TradeTime { get; set; }
        public string? Symbol { get; set; }
        public double? Price { get; set; }
        public int? CoreTime { get; set; }
    }
}
