namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Orderstatistic
    {
        public long Id { get; set; }
        public string? Accountid { get; set; }
        public int? Newmatch { get; set; }
        public int? Totalmatch { get; set; }
        public int? Newcancel { get; set; }
        public int? Totalcancel { get; set; }
        public int? Newreject { get; set; }
        public int? Totalreject { get; set; }
        public bool? Isnew { get; set; }
    }
}
