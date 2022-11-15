namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Customerpermission
    {
        public string CustomerId { get; set; } = null!;
        public string ChannelId { get; set; } = null!;
        public bool? Canbuy { get; set; }
        public bool? CanSell { get; set; }
        public bool? IsLock { get; set; }
        public long Id { get; set; }
    }
}
