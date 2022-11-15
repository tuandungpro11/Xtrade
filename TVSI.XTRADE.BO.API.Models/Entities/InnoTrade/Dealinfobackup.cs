namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Dealinfobackup
    {
        public long DealInfoId { get; set; }
        public int? ConfirmNo { get; set; }
        public int? OrderSeqNo { get; set; }
        public string? Symbol { get; set; }
        public string? Side { get; set; }
        public int? BrokerNo { get; set; }
        public int? OrderNo { get; set; }
        public int? BrokerOrderNo { get; set; }
        public int? DealVolume { get; set; }
        public decimal? DealPrice { get; set; }
        public string? DealDate { get; set; }
        public string? DealTime { get; set; }
        public string? AccountNo { get; set; }
        public string? AccType { get; set; }
        public string? Board { get; set; }
        public string? ServiceType { get; set; }
        public string? CancelFlag { get; set; }
        public string? UpdateFlag { get; set; }
        public string? PutThoughFlag { get; set; }
        public DateTime? InsertTime { get; set; }
        public decimal? Sumcomm { get; set; }
        public decimal? Sumvat { get; set; }
    }
}
