namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Commission
    {
        public long Id { get; set; }
        /// <summary>
        /// Free agent
        /// </summary>
        public string AgentId { get; set; } = null!;
        /// <summary>
        /// MktId
        /// </summary>
        public string? BrokerId { get; set; }
        /// <summary>
        /// So tien hoa hong duoc lanh toi thoi diem ComDate
        /// </summary>
        public decimal? Commission1 { get; set; }
        /// <summary>
        /// Ngay tinh phi hoa hong
        /// </summary>
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Remark { get; set; }
        public DateTime? CommDate { get; set; }
    }
}
