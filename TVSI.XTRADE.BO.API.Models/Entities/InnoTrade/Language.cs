namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Language
    {
        public Language()
        {
            Newsletterscategories = new HashSet<Newsletterscategory>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Newsletterscategory> Newsletterscategories { get; set; }
    }
}
