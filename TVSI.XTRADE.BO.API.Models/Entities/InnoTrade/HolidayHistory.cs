namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class HolidayHistory
    {
        public long Holidayid { get; set; }
        public DateTime? Holiday { get; set; }
        public bool? Repeat { get; set; }
        public string? Description { get; set; }
    }
}
