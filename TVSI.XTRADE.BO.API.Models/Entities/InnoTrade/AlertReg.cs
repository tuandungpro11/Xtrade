namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AlertReg
    {
        public int Id { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public string? Symbol { get; set; }
        public decimal? MaxBuyPrice { get; set; }
        public decimal? MinSellPrice { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? MaxVolume { get; set; }
        public decimal? MaxIndex { get; set; }
        public decimal? MinIndex { get; set; }
        public string? Market { get; set; }
        public DateTime? EffectiveFromDateTime { get; set; }
        public DateTime? EffectiveToDateTime { get; set; }
        public byte[]? Sequence { get; set; }
        public int? Flag { get; set; }
        public int? NotifyAction { get; set; }
        public DateTime DateModified { get; set; }
        public int? FunctionFlag { get; set; }
    }
}
