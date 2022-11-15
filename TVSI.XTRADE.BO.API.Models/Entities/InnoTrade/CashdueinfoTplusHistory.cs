namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CashdueinfoTplusHistory
    {
        public long Cashdueinfoid { get; set; }
        public string? Accountno { get; set; }
        public decimal? Payment { get; set; }
        public decimal? Overdue { get; set; }
        public decimal? Available { get; set; }
        public decimal? WtsCashT1 { get; set; }
        public decimal? WtrCashT1 { get; set; }
        public decimal? WtsCashT2 { get; set; }
        public decimal? WtrCashT2 { get; set; }
        public decimal? WtsCashT3 { get; set; }
        public decimal? WtrCashT3 { get; set; }
        public decimal? AmtCashT1 { get; set; }
        public decimal? AmtCashT2 { get; set; }
        public decimal? AmtCashT3 { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
