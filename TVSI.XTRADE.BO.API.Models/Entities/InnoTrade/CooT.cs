namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CooT
    {
        public int Id { get; set; }
        public int? CooId { get; set; }
        public short? TrailingAmtType { get; set; }
        public double? TrailingAmtAbs { get; set; }
        public double? TrailingAmtPer { get; set; }
        public double? MaxSellPrice { get; set; }
        public double? MinBuyPrice { get; set; }
        public double? TriggerPrice { get; set; }
        public double? PlacePrice { get; set; }
    }
}
