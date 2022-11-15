namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Usergroup
    {
        public int Usergroupid { get; set; }
        public string? Groupname { get; set; }
        public string? Description { get; set; }
        public DateTime? Createdate { get; set; }
        public bool? Active { get; set; }
    }
}
