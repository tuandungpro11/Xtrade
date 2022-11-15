namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class SectorIndex
    {
        public DateTime Date { get; set; }
        public string MarketCode { get; set; } = null!;
        public string SectorNo { get; set; } = null!;
        public double? RefIndex { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Average { get; set; }
        public double? Volume { get; set; }
        public double? Value { get; set; }
        public double? Open { get; set; }
        public double? Close { get; set; }
        public int? Up1 { get; set; }
        public int? Up2 { get; set; }
        public int? Down1 { get; set; }
        public int? Down2 { get; set; }
        public int? Up { get; set; }
        public int? Down { get; set; }
        public int? NoChange { get; set; }
        public int? Count { get; set; }
        public double? ForeignBuy { get; set; }
        public double? ForeignSell { get; set; }
        public double? IndexPoint { get; set; }
        public double? Change { get; set; }
        public double? PerChange { get; set; }
    }
}
