namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Creditlinestocklist
    {
        public long Id { get; set; }
        public string Symbol { get; set; } = null!;
        public decimal Ratio { get; set; }
        public string? Description { get; set; }
    }
}
