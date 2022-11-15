namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Emaillog
    {
        public long Emaillogid { get; set; }
        public string? Customerid { get; set; }
        public string? Userid { get; set; }
        public DateTime? Senttime { get; set; }
        public string? Sent2email { get; set; }
        public string? Subject { get; set; }
        public int? Status { get; set; }
        public string? Remark { get; set; }
    }
}
