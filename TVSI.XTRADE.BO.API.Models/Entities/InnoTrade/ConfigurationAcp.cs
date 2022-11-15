namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class ConfigurationAcp
    {
        public long Id { get; set; }
        public decimal? BeginVal { get; set; }
        public decimal? EndVal { get; set; }
        public decimal? Rate { get; set; }
        public int? Type { get; set; }
        public string? Remark { get; set; }
    }
}
