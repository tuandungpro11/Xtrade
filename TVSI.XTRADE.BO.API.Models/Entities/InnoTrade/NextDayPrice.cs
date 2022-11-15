namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class NextDayPrice
    {
        public string Symbol { get; set; } = null!;
        public decimal? FloorPrice { get; set; }
        public decimal? CeilingPrice { get; set; }
        public decimal? RefPrice { get; set; }
        public string? Market { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
