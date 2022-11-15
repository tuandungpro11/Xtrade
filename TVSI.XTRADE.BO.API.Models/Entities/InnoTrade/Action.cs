namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Action
    {
        public Action()
        {
            Permission1s = new HashSet<Permission1>();
        }

        public string Actionid { get; set; } = null!;
        public string? Actionname { get; set; }
        public string? Description { get; set; }
        public bool Isactive { get; set; }
        public string? Functionid { get; set; }

        public virtual Function? Function { get; set; }
        public virtual ICollection<Permission1> Permission1s { get; set; }
    }
}
