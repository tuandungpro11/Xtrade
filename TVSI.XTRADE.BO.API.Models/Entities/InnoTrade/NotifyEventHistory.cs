namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class NotifyEventHistory
    {
        public int Id { get; set; }
        public int? NotifyAction { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public int? TriggerId { get; set; }
        public DateTime? TriggerDate { get; set; }
        public int? NotifyStatus { get; set; }
        public int? NotifyRetCode { get; set; }
        public int? Wsstatus { get; set; }
        public string? WsretCode { get; set; }
        public DateTime? ProcessedTime { get; set; }
        public string? Description { get; set; }
        public int? ConfirmStatus { get; set; }
    }
}
