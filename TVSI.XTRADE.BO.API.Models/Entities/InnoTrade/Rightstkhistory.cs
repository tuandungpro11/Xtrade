namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Rightstkhistory
    {
        public long Id { get; set; }
        public string? ContractNo { get; set; }
        public string? AccountNo { get; set; }
        public string? Symbol { get; set; }
        public decimal? Price { get; set; }
        public decimal? Old { get; set; }
        public decimal? New { get; set; }
        public decimal? PayRate { get; set; }
        public decimal? Compamt { get; set; }
        public decimal? CompUnitNew { get; set; }
        public decimal? CompUnitConfirm { get; set; }
        public int? Xtype { get; set; }
        public int? Status { get; set; }
        public string? UserId { get; set; }
        public DateTime? RightDate { get; set; }
        public DateTime? TransferToDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public bool? IsNew { get; set; }
        public string? Reason { get; set; }
        public string? Source { get; set; }
        public string? CustomerId { get; set; }
        public DateTime? EditTime { get; set; }
        public DateTime? ApproveTime { get; set; }
        public string? ApproveId { get; set; }
        public decimal? Volume { get; set; }
        public string? NewShareCode { get; set; }
        public string? Receiveraccount { get; set; }
        public DateTime? Confirmdate { get; set; }
        public int? Rrid { get; set; }
        public DateTime? Transferfromdate { get; set; }
        public decimal? Compunitbfxr { get; set; }
        public decimal? Compunitdep { get; set; }
        public decimal? Compunitwd { get; set; }
        public string? Delflag { get; set; }
        public string? Confirmflag { get; set; }
        public decimal? Roundup { get; set; }
        public DateTime? Paydate { get; set; }
        public string? Rirno { get; set; }
    }
}
