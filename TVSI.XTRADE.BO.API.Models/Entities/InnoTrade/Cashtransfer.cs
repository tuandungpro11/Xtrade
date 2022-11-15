namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Cashtransfer
    {
        public long Id { get; set; }
        public string? Contractno { get; set; }
        public string? Userid { get; set; }
        public string? Accountno { get; set; }
        public DateTime? Transferdate { get; set; }
        public string? Receivername { get; set; }
        public string? Identitycard { get; set; }
        public string? Bankaccount { get; set; }
        public string? Bankname { get; set; }
        public string? Branchbankname { get; set; }
        public decimal? Amount { get; set; }
        public string? Remark { get; set; }
        public string? Reason { get; set; }
        public int? Feetype { get; set; }
        public int? Transfertype { get; set; }
        public decimal? Fee { get; set; }
        public int? Status { get; set; }
        public bool? Isnew { get; set; }
        public DateTime? Edittime { get; set; }
        public DateTime? Approvetime { get; set; }
        public string? Approveid { get; set; }
        public string? Customerid { get; set; }
        public string? Transrefer { get; set; }
        public int? AmountType { get; set; }
        public string? SequenceNumber { get; set; }
        public string? PreferenceNumber { get; set; }
        public string? ImbsContractno { get; set; }
        public string? Bankcode { get; set; }
        public string? Branchcode { get; set; }
        public string? Transfersource { get; set; }
        public int? IsAutoApproval { get; set; }
        public string? Errordesc { get; set; }
        public int? ApiRetriedTimes { get; set; }
        public string? Source { get; set; }
        public string? Movementid { get; set; }
        public string? Createtime { get; set; }
        public int? PendingStatusId { get; set; }
        public decimal? MoneyTransfer { get; set; }
    }
}
