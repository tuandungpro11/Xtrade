namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class StepPriceRangeBackup20220506
    {
        public int Id { get; set; }
        public string? Market { get; set; }
        public string? StockType { get; set; }
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }
        public decimal? PriceStep { get; set; }
        public long? MaxVol { get; set; }
        public string? AssetCode { get; set; }
        public string? AssetType { get; set; }
        public decimal? PriceUnit { get; set; }
        public long? VolumeUnit { get; set; }
        public int? TradingType { get; set; }
        public long? MinVol { get; set; }
        public decimal? Multiplier { get; set; }
    }
}
