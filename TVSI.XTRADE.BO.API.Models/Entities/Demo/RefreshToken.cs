namespace TVSI.XTRADE.BO.API.Models.Entities.Demo
{
    public partial class RefreshToken
    {
        public long RefreshTokenId { get; set; }
        public string? Token { get; set; }
        public DateTime? Expires { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedByIp { get; set; }
        public DateTime? RevokeDate { get; set; }
        public string? RevokedByIp { get; set; }
        public string? ReplacedByToken { get; set; }
        public string? Username { get; set; }
    }
}
