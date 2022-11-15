namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CustomerAuthen
    {
        public long Id { get; set; }
        public string? CustomerId { get; set; }
        public string? AuthenId { get; set; }
        public string? ConfirmCode { get; set; }
        public int? IsConfirm { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
