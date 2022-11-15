namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Broker
    {
        public string Traderid { get; set; } = null!;
        public string? Tradername { get; set; }
        public string? Password { get; set; }
        public string? Pin { get; set; }
        public string? Identitycard { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? Tradertype { get; set; }
        public string? Supervisorid { get; set; }
        public string? Tradergroup { get; set; }
        public string? Branchid { get; set; }
        public DateTime? Activedate { get; set; }
        public DateTime? Expiredate { get; set; }
        public int? Status { get; set; }
        public string? Pinconfirmcode { get; set; }
        public string? Passconfirmcode { get; set; }
        public string? Keyordzone { get; set; }
    }
}
