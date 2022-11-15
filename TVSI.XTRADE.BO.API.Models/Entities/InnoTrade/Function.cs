namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Function
    {
        public Function()
        {
            Actions = new HashSet<Action>();
        }

        public string Functionid { get; set; } = null!;
        public string Functionname { get; set; } = null!;
        public string? Description { get; set; }
        public bool Isactive { get; set; }
        public string? Moduleid { get; set; }

        public virtual Module1? Module { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}
