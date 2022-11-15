namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Loginlog
    {
        public long Loginhistoryid { get; set; }
        public string Customerid { get; set; } = null!;
        public DateTime? Logindate { get; set; }
        public DateTime? Logoutdate { get; set; }
        public string? Ip { get; set; }
        public string? Sessionid { get; set; }
        public int? Status { get; set; }
        public string? Channel { get; set; }
        public string? Userid { get; set; }
        public string? Remark { get; set; }
        public string? Metadata { get; set; }
    }
}
