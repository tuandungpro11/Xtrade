namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AlertAction
    {
        public int Id { get; set; }
        public int? Alertregid { get; set; }
        public string? Customerid { get; set; }
        public string? Accountno { get; set; }
        public int? NotifyAction { get; set; }
        public string? Symbol { get; set; }
        public string? Market { get; set; }
        public decimal? Matchedvalue { get; set; }
        public decimal? Conditionvalue { get; set; }
        public int? Conditiontype { get; set; }
        public DateTime? Alertdate { get; set; }
        public string? Message { get; set; }
    }
}
