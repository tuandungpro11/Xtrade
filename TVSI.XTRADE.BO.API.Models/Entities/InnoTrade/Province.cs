namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Province
    {
        public string ProvinceId { get; set; } = null!;
        public string? ProvinceName { get; set; }
        public long? IsActive { get; set; }
        public string? Remark { get; set; }
        public long Id { get; set; }
    }
}
