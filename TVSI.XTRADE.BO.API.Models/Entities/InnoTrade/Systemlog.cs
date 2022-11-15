namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Systemlog
    {
        public long Systemlogid { get; set; }
        public string? Userid { get; set; }
        public int? Actiontype { get; set; }
        public DateTime? Actiondate { get; set; }
        public string? Accountno { get; set; }
        public int? Moduleid { get; set; }
        public string? Remark { get; set; }
    }
}
