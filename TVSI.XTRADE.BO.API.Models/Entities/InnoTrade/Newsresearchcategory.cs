namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Newsresearchcategory
    {
        public Newsresearchcategory()
        {
            Newsresearches = new HashSet<Newsresearch>();
        }

        public long Categoryid { get; set; }
        public string? Categoryname { get; set; }
        public string? Description { get; set; }
        public int? Order { get; set; }
        public int? Languageid { get; set; }
        public long? Parentid { get; set; }
        public int? Level { get; set; }
        public bool? Ispublished { get; set; }

        public virtual ICollection<Newsresearch> Newsresearches { get; set; }
    }
}
