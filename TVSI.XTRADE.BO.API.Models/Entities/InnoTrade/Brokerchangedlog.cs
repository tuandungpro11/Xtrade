namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Brokerchangedlog
    {
        public long Id { get; set; }
        public string Brokerid { get; set; } = null!;
        public string? Changetype { get; set; }
        public string? Changeinfo { get; set; }
        public DateTime? Changetime { get; set; }
        public string? Changestatus { get; set; }

        public virtual User Broker { get; set; } = null!;
    }
}
