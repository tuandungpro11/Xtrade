namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Coo2orderinfohistory
    {
        public int Id { get; set; }
        public int CooId { get; set; }
        public int OrderInfoId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? FisorderId { get; set; }
    }
}
