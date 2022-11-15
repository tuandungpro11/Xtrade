namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class FosDealinfobackup
    {
        public long Id { get; set; }
        public long? OrgId { get; set; }
        public string Coreorderid { get; set; } = null!;
        public string? Orgcoreorderid { get; set; }
        public string Coredealid { get; set; } = null!;
        public long? Sequence { get; set; }
        public long? Executedvolume { get; set; }
        public decimal? Executedprice { get; set; }
        public DateTime? Executedtime { get; set; }
        public DateTime? Createtime { get; set; }
        public string? Createby { get; set; }
        public DateTime? Modifytime { get; set; }
        public string? Modifyby { get; set; }
        public string? Remark { get; set; }
        public DateTime? Backuptime { get; set; }
        public string? Backupby { get; set; }
    }
}
