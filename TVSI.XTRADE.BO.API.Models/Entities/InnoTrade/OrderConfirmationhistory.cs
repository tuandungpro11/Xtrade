namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class OrderConfirmationhistory
    {
        public int OrderConfirmationId { get; set; }
        public string CustomerId { get; set; } = null!;
        public string AccountNo { get; set; } = null!;
        /// <summary>
        /// 0: do He thong tu dong ky lenh.
        /// </summary>
        public string? AuthorId { get; set; }
        /// <summary>
        /// OrderID tren he thong FIS
        /// </summary>
        public long? FisOrderId { get; set; }
        public string? SecSymbol { get; set; }
        public int? OrderId { get; set; }
        public string? Side { get; set; }
        public decimal? Price { get; set; }
        public long? Volume { get; set; }
        public long? ExecutedVol { get; set; }
        public decimal? ExecutedPrice { get; set; }
        public long? CancelVolume { get; set; }
        public long? CancelledVolume { get; set; }
        /// <summary>
        /// Ngay giao dich
        /// </summary>
        public DateTime? TransTime { get; set; }
        public DateTime? MatchedTime { get; set; }
        public DateTime? CancelledTime { get; set; }
        public short? OrderStatus { get; set; }
        public short? CancelStatus { get; set; }
        public short? OrdRejReason { get; set; }
        public short? CancelledRejReason { get; set; }
        public string? TraderId { get; set; }
        public string? OrderSource { get; set; }
        /// <summary>
        /// Ngay ky phieu lenh
        /// </summary>
        public DateTime? SignDate { get; set; }
        /// <summary>
        /// Ma xac nhan
        /// </summary>
        public string? ConfirmCode { get; set; }
        public DateTime? ConfirmCodeDate { get; set; }
        /// <summary>
        /// 0: Chua ky - 
        /// 1: Da ky
        /// </summary>
        public int Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Remark { get; set; }
        public string? ConPrice { get; set; }
        public short? ExecTransType { get; set; }
        public long? ParentId { get; set; }
        public int? Changestatus { get; set; }
        public string? Changerejreason { get; set; }
        public string? TpCode { get; set; }
        public int? TpStatus { get; set; }
        public int? TpUse { get; set; }
        public string? AuthorChannel { get; set; }
        public int Coretype { get; set; }
    }
}
