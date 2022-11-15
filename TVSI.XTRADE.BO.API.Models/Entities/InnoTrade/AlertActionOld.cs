namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AlertActionOld
    {
        public int Id { get; set; }
        public int? AlertRegId { get; set; }
        public string? CustomerId { get; set; }
        public string? Symbol { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal? SellPrice { get; set; }
        public decimal? Price { get; set; }
        public decimal? Index { get; set; }
        public int? Volume { get; set; }
        public string? Market { get; set; }
        public string? Message { get; set; }
        public string? AccountNo { get; set; }
        public DateTime? AlertDate { get; set; }
    }
}
