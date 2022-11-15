namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class TvsiDanhSachDealLenhTrongNgay
    {
        public int DanhSachDealLenhTrongNgayId { get; set; }
        public decimal? Confirmno { get; set; }
        public decimal? Orderseqno { get; set; }
        public string? Secsymbol { get; set; }
        public string? Side { get; set; }
        public string? Brokerno { get; set; }
        public decimal? Orderno { get; set; }
        public string? Brokerorderno { get; set; }
        public decimal? Dealvolume { get; set; }
        public decimal? Dealprice { get; set; }
        public string? Dealdate { get; set; }
        public string? Dealtime { get; set; }
        public string? Accountno { get; set; }
        public string? Acctype { get; set; }
        public string? Board { get; set; }
        public string? Servicetype { get; set; }
        public string? Cancelflag { get; set; }
        public string? Updateflag { get; set; }
        public string? Putthroughflag { get; set; }
        public string? Contrafirm { get; set; }
        public string? Custtype { get; set; }
        public string? Mktordno { get; set; }
        public string? Mktconfirmno { get; set; }
        public string? Dueday { get; set; }
        public DateTime? Inserttime { get; set; }
        public int? Flag { get; set; }
        public string? NguoiSuaCuoi { get; set; }
        public DateTime? NgaySuaCuoi { get; set; }
        public string? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
