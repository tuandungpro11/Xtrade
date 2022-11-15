namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Customergroup
    {
        public int Customergroupid { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Createdate { get; set; }
        public int? Accountype { get; set; }
        public bool? Active { get; set; }
        public int Level { get; set; }
    }
}
