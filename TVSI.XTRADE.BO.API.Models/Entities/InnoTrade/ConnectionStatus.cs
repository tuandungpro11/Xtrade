namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class ConnectionStatus
    {
        public int Id { get; set; }
        public bool? Connected { get; set; }
        public string? InnoTradeGwname { get; set; }
        public int? CoreType { get; set; }
    }
}
