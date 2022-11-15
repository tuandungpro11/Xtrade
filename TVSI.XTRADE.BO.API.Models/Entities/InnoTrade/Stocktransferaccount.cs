namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Stocktransferaccount
    {
        public long Id { get; set; }
        public string Accountno { get; set; } = null!;
        public string Customerid { get; set; } = null!;
        public DateTime? Createddate { get; set; }
        public string? Description { get; set; }
    }
}
