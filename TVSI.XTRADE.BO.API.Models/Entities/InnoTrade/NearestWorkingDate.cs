namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class NearestWorkingDate
    {
        public string Market { get; set; } = null!;
        public DateTime? T { get; set; }
        public DateTime? T1 { get; set; }
        public DateTime? T2 { get; set; }
        public DateTime? T3 { get; set; }
    }
}
