namespace TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage
{
    public class CustomerAccountRequest
    {
        public string? UserId { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerNo { get; set; }
        public string? CustomerName { get; set; }
        public int AuthType { get; set; }
        public string? IdentityCard { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? CellPhone { get; set; }
        public int Status { get; set; }
        public int AgentType { get; set; }
        public int CustomerType { get; set; }
        public int CustomerGroupId { get; set; }
        public decimal TotalPoint { get; set; }
        public string? BranchId { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public byte IsDefault { get; set; }
        public string? DefaultAccount { get; set; }
        public string? PickAccount { get; set; }
        public string? Custodian { get; set; }
        public string? MktId { get; set; }
        public string? PcFlag { get; set; }
        public string? CreditType { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Sex { get; set; }
        public DateTime CardIssue { get; set; }
        public string? PlaceIssue { get; set; }
        public string? Occupation { get; set; }
        public string? Nationality { get; set; }
        public string? Remark { get; set; }
        public string? TaxCode { get; set; }
    }
}
