namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Coo2orderInfo
    {
        public int Id { get; set; }
        public int CooId { get; set; }
        public int OrderInfoId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public long? FisorderId { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string? ModifyBy { get; set; }
        public string? Remark { get; set; }
    }
}
