namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class User
    {
        public User()
        {
            Brokerchangedlogs = new HashSet<Brokerchangedlog>();
        }

        public string Userid { get; set; } = null!;
        public int? Bousergroupid { get; set; }
        public string? Branchid { get; set; }
        public string? Password { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public DateTime? Lastmodified { get; set; }
        public string? Remark { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Brokerchangedlog> Brokerchangedlogs { get; set; }
    }
}
