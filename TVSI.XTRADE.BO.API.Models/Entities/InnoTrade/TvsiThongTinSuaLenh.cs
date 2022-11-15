namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class TvsiThongTinSuaLenh
    {
        public long ThongTinSuaLenhId { get; set; }
        public string SoHieuLenh { get; set; } = null!;
        public string SoTaiKhoan { get; set; } = null!;
        public string TradeIdSuaLenh { get; set; } = null!;
        public string ThoiGianSuaLenh { get; set; } = null!;
        public bool? LenhSua { get; set; }
        public double? GiaCu { get; set; }
        public double? GiaMoi { get; set; }
        public DateTime? NgayGiaoDich { get; set; }
        public string? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? NguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
