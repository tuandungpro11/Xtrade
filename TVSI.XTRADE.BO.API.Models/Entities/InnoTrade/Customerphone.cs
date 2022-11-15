namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Customerphone
    {
        public int Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public bool? IsSms { get; set; }
        public bool? IsCc { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
