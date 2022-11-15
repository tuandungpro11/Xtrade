namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Accountpermissiontemp
    {
        public string AccountNo { get; set; } = null!;
        public int Permission { get; set; }
        public string Channel { get; set; } = null!;
        public int? Status { get; set; }
        public string UserId { get; set; } = null!;
    }
}
