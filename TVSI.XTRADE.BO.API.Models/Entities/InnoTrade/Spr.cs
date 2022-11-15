namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Spr
    {
        public long Id { get; set; }
        public string? ContractNo { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        /// <summary>
        /// So tien can ho tro
        /// </summary>
        public decimal? Amount { get; set; }
        public decimal? ReAmount { get; set; }
        public decimal? RemainAmount { get; set; }
        /// <summary>
        /// Ngay mau chung khoan
        /// </summary>
        public DateTime? TradeDate { get; set; }
        /// <summary>
        /// Gia tri lenh dat cua ngay TradeDate
        /// </summary>
        public decimal? TradeValue { get; set; }
        public int? Status { get; set; }
        /// <summary>
        /// 1: nhan ho tro, 2: tra ho tro
        /// </summary>
        public int? Type { get; set; }
        public string? Source { get; set; }
        public string? TraderId { get; set; }
        public DateTime? Sprdate { get; set; }
        public string? UserId { get; set; }
        public DateTime? EditTime { get; set; }
        public DateTime? ApproveTime { get; set; }
        public string? ApproveId { get; set; }
        public string? Remark { get; set; }
        public bool? IsNew { get; set; }
        public decimal? Interest { get; set; }
        public int? NumOfDate { get; set; }
        public DateTime? FundingDate { get; set; }
        public short? PaymentNo { get; set; }
        public string? RefContractNo { get; set; }
    }
}
