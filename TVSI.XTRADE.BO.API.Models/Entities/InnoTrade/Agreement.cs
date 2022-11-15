namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Agreement
    {
        public long Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public int? AgreementType { get; set; }
        public string? Channel { get; set; }
        public DateTime? AgreementDate { get; set; }
    }
}
