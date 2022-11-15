namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Ordersource
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Traderid { get; set; }
        public string? Servicetype { get; set; }
        public string? Source { get; set; }
        public decimal? Feeratio { get; set; }
        public string? Pipename { get; set; }
        public string? Pipeserver { get; set; }
        public string? Domain { get; set; }
        public string? Userid { get; set; }
        public string? Pwd { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? MinFee { get; set; }
    }
}
