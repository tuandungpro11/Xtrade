namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Newsletterscategory
    {
        public Newsletterscategory()
        {
            Newslettersregistrations = new HashSet<Newslettersregistration>();
        }

        public long Categoryid { get; set; }
        public string? Categoryname { get; set; }
        public string? Description { get; set; }
        public bool? Active { get; set; }
        public int? Order { get; set; }
        public int? Languageid { get; set; }
        public long? Parentid { get; set; }
        public int? Level { get; set; }

        public virtual Language? Language { get; set; }

        public virtual ICollection<Newslettersregistration> Newslettersregistrations { get; set; }
    }
}
