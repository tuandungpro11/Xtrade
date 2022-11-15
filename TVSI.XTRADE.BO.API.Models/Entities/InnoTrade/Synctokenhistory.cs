namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Synctokenhistory
    {
        public long Synctokenid { get; set; }
        public string Accountno { get; set; } = null!;
        public DateTime? Syncdate { get; set; }
        public int? Status { get; set; }

        public virtual Customer AccountnoNavigation { get; set; } = null!;
    }
}
