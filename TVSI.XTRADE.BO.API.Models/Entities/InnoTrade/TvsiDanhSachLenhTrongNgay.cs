namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class TvsiDanhSachLenhTrongNgay
    {
        public int DanhSachLenhTrongNgayId { get; set; }
        public decimal? Orderno { get; set; }
        public string? Secsymbol { get; set; }
        public string? Side { get; set; }
        public string? Accountno { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Price { get; set; }
        public string? Orderstatus { get; set; }
        public string? Orderdate { get; set; }
        public string? Ordertime { get; set; }
        public string? Enterid { get; set; }
        public string? Cancelid { get; set; }
        public string? Canceltime { get; set; }
        public decimal? Cancelvolume { get; set; }
        public string? Conditionprice { get; set; }
        public decimal? Matchvolume { get; set; }
        public decimal? Matchvalue { get; set; }
        public string? Market { get; set; }
        public string? Servicetype { get; set; }
        public string? Branchid { get; set; }
        public string? Showprice { get; set; }
        public string? Traderid { get; set; }
        public string? Rejectcode { get; set; }
        public string? Rejecttext { get; set; }
        public string? NguoiSuaCuoi { get; set; }
        public DateTime? NgaySuaCuoi { get; set; }
        public string? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
