namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Customerpermissiont
    {
        public string CustomerId { get; set; } = null!;
        public bool? CanBuy { get; set; }
        public string? Status { get; set; }
        public string? UserId { get; set; }
        public long Id { get; set; }
    }
}
