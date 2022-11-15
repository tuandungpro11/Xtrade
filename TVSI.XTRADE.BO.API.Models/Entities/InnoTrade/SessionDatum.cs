namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class SessionDatum
    {
        public string SessionId { get; set; } = null!;
        public DateTime? LastAccessTime { get; set; }
        public string? UserId { get; set; }
        public bool? IsFirstLogon { get; set; }
        public string? RequestIpAddress { get; set; }
        public string? ServerIpAddress { get; set; }
        public string? ChannelId { get; set; }
        public DateTime? LoginTime { get; set; }
        public string? Lat { get; set; }
        public string? Lng { get; set; }
        public string? MacAddress { get; set; }
        public string? DeviceId { get; set; }
        public string? UserAgent { get; set; }
        public string? PartnerSessionId { get; set; }
        public string? Address { get; set; }
        public int? IsActive { get; set; }
    }
}
