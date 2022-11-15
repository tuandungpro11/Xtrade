namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Nexdayprice
    {
        public long Id { get; set; }
        public string? Symbol { get; set; }
        public decimal? FloorPrice { get; set; }
        public decimal? CeilingPrice { get; set; }
        public decimal? RefPrice { get; set; }
        public string? Market { get; set; }
    }
}
