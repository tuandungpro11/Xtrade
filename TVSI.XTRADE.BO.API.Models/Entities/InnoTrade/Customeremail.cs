namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Customeremail
    {
        public int Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool? IsSms { get; set; }
        public bool? IsCc { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
