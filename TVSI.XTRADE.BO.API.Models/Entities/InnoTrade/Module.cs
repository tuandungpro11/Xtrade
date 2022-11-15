namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Module
    {
        public int Moduleid { get; set; }
        public string? Name { get; set; }
        public DateTime? Createdate { get; set; }
        public bool? Active { get; set; }
        public string? Remark { get; set; }
    }
}
