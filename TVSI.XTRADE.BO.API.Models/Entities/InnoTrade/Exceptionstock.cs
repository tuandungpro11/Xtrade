namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Exceptionstock
    {
        public string Date { get; set; } = null!;
        public string? StockSymbol { get; set; }
        public string? Market { get; set; }
        public int Id { get; set; }
    }
}
