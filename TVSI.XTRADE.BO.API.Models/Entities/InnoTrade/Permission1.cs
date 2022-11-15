namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Permission1
    {
        public string Actionid { get; set; } = null!;
        public int Groupid { get; set; }
        public bool Hasaccess { get; set; }

        public virtual Action Action { get; set; } = null!;
    }
}
