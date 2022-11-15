namespace TVSI.XTRADE.BO.API.Models.Entities.Demo
{
    public partial class LogLogin
    {
        public long LogLoginId { get; set; }
        public string? Username { get; set; }
        public string? Channel { get; set; }
        public string? IpAddress { get; set; }
        public string? Device { get; set; }
        public string? Browser { get; set; }
        public string? Platform { get; set; }
        public string? Engine { get; set; }
        public DateTime? LoginTime { get; set; }
    }
}
