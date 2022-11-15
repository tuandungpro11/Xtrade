namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Internalaccount
    {
        public string CustomerId { get; set; } = null!;
        public string InternalAccountNo { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? InternalCustomerId { get; set; }
        public string? InternalCustomerNo { get; set; }
        public string? InternalCustomerName { get; set; }
        public string? InternalIdentityCard { get; set; }
        public string? InternalAddress { get; set; }
        public int? InternalStatus { get; set; }
        public string? InternalScanUrl { get; set; }
        public string? Remark { get; set; }
        public string? Reason { get; set; }
        public string? Modifiedby { get; set; }
        public string? Createby { get; set; }
    }
}
