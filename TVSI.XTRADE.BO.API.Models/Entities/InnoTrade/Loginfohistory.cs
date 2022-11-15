namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Loginfohistory
    {
        public long Loginfoid { get; set; }
        public string? Customerid { get; set; }
        public string? Agentid { get; set; }
        public string? Userid { get; set; }
        public int? Actiontype { get; set; }
        public DateTime? Actiontime { get; set; }
        public string? Oldinfo { get; set; }
        public string? Newinfo { get; set; }
        public string? Ip { get; set; }
        public string? Remark { get; set; }
        public string? Module { get; set; }
    }
}
