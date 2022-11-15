namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Ccinfo
    {
        public long Ccid { get; set; }
        public string CustomerId { get; set; } = null!;
        public string? Ccpin { get; set; }
        public int? CcauthType { get; set; }
        public string? Ccmobile { get; set; }
        public bool? IvrmobileAuth { get; set; }
        public int? LanguageId { get; set; }
        public string? Channel { get; set; }
        public DateTime? Ccdate { get; set; }
        public DateTime? CclastUpdate { get; set; }
        public string? BranchId { get; set; }
        public string? Modifier { get; set; }
        public string? ModifyChannel { get; set; }
        /// <summary>
        /// Trang thai: 1: Dang hoat dong- 2: Huy
        /// </summary>
        public int? Ccstatus { get; set; }
        public string? Userid { get; set; }
    }
}
