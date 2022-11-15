namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CustomerContact
    {
        public int Id { get; set; }
        public string? CustomerId { get; set; }
        public string? DisplayName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Skype { get; set; }
        public string? Yahoo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Remark { get; set; }
    }
}
