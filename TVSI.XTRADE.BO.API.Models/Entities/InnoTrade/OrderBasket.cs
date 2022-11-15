namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderBasket
    {
        public int BasketId { get; set; }
        public string BasketName { get; set; } = null!;
        public string? Account { get; set; }
        public string CustomerId { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Remark { get; set; }
    }
}
