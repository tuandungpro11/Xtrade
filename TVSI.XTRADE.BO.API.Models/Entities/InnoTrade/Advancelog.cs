namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Advancelog
    {
        public long Advancelogid { get; set; }
        public string? Brokerid { get; set; }
        public DateTime? Actiondate { get; set; }
        public string? Beginstatus { get; set; }
        public string? Laststatus { get; set; }
        public string? Contractno { get; set; }
    }
}
