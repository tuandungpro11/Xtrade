namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Customerchangedloghistory
    {
        public long Changeid { get; set; }
        public string? Customerid { get; set; }
        public int? Changetype { get; set; }
        public string? Changeinfo { get; set; }
        public DateTime? Changetime { get; set; }
        public string? Changeperson { get; set; }
        public int? Changestatus { get; set; }
        public bool? Isuser { get; set; }
        public string? Userid { get; set; }
    }
}
