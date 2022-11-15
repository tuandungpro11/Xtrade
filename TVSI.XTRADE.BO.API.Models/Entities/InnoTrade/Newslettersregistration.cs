namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Newslettersregistration
    {
        public Newslettersregistration()
        {
            Categories = new HashSet<Newsletterscategory>();
        }

        public int Newslettersregistrationid { get; set; }
        public string? Customerid { get; set; }
        public string? Email { get; set; }
        public DateTime? Registerdate { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Changedate { get; set; }

        public virtual ICollection<Newsletterscategory> Categories { get; set; }
    }
}
