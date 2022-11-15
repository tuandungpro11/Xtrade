namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class SignOnlineType
    {
        public int SigningId { get; set; }
        public string? SigningName { get; set; }
        public string? SigningDescription { get; set; }
        public string? SigningTerm { get; set; }
        public bool? IsActive { get; set; }
        public int? LanguageId { get; set; }
    }
}
