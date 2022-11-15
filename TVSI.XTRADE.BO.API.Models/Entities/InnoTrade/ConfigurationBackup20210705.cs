namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class ConfigurationBackup20210705
    {
        public string Key { get; set; } = null!;
        public string? Value { get; set; }
        public string? Description { get; set; }
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
