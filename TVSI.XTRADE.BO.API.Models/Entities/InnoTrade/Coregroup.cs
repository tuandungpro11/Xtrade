namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Coregroup
    {
        public int Id { get; set; }
        public string? Group { get; set; }
        public string? Description { get; set; }
        public DateTime? Effdate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Maxloan { get; set; }
    }
}
