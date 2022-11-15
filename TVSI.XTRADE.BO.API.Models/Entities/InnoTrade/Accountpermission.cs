namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Accountpermission
    {
        public string AccountNo { get; set; } = null!;
        public int Permission { get; set; }
        public string Channel { get; set; } = null!;
    }
}
