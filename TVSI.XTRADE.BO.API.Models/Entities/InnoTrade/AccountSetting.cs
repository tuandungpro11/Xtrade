namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class AccountSetting
    {
        public long Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public string AccountNo { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
    }
}
