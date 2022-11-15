namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Coreaccount
    {
        public string AccountNo { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string ChannelId { get; set; } = null!;
        public bool? Canbuy { get; set; }
        public bool? CanSell { get; set; }
        public bool? IsLock { get; set; }
    }
}
