namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class SignOnlineRegistration
    {
        public int RegistrationId { get; set; }
        public int RegistrationType { get; set; }
        public string CustomerId { get; set; } = null!;
        public int? TypeSigningId { get; set; }
        public DateTime AcceptedDate { get; set; }
        public string ConfirmCode { get; set; } = null!;
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public int? Status { get; set; }
        public int? ProStatus { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? UserId { get; set; }
        public string? Reason { get; set; }
    }
}
