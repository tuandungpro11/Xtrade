namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Dividendcash
    {
        public long Id { get; set; }
        public string? Accountno { get; set; }
        public DateTime? Refdate { get; set; }
        public DateTime? Effdate { get; set; }
        public string? Sharecode { get; set; }
        public int? Volume { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amt { get; set; }
        public string? Remark { get; set; }
    }
}
