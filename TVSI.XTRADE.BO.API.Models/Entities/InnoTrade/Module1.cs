namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Module1
    {
        public Module1()
        {
            Functions = new HashSet<Function>();
        }

        public string Moduleid { get; set; } = null!;
        public string Modulename { get; set; } = null!;
        public string? Description { get; set; }
        public bool Isactive { get; set; }

        public virtual ICollection<Function> Functions { get; set; }
    }
}
