namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Loyaltyrewardspoint
    {
        public long Loyaltyrewardspointid { get; set; }
        public string? Accountno { get; set; }
        public string? Brokerid { get; set; }
        public DateTime? Editdate { get; set; }
        public decimal? Oldpoint { get; set; }
        public decimal? Newpoint { get; set; }
        public string? Description { get; set; }
    }
}
