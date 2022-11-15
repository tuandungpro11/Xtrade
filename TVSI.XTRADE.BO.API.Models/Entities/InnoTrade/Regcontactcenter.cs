namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Regcontactcenter
    {
        public long Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public string? Phone { get; set; }
        public int? AuthType { get; set; }
        public string? Pin { get; set; }
        public int? LanguageId { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string? Remark { get; set; }
        public string? Email { get; set; }
    }
}
