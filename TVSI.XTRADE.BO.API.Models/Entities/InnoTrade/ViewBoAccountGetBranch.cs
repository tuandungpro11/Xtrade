namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class ViewBoAccountGetBranch
    {
        public string Accountno { get; set; } = null!;
        public string? Branchid { get; set; }
        public string? Branchname { get; set; }
        public string CustomerId { get; set; } = null!;
        public string? Customerno { get; set; }
        public string? Customername { get; set; }
        public string? Identitycard { get; set; }
        public int? CustomerType { get; set; }
    }
}
