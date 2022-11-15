namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Agent
    {
        public string Agentid { get; set; } = null!;
        public int? Agenttype { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Description { get; set; }
        public decimal? Bonusreserve { get; set; }
        public bool? Isnew { get; set; }
        public string? Createdby { get; set; }
        public string? Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Commission { get; set; }
        public string? Traderid { get; set; }
        public string? Supervisorid { get; set; }
        public string? Agentgroupid { get; set; }
        public string? Keyordzone { get; set; }
        public string? Tradertype { get; set; }
        public decimal? Buyauthcr { get; set; }
        public decimal? Sellauthcr { get; set; }
        public decimal? Dayauthcr { get; set; }
        public string? Setid { get; set; }
        public string? Bsdcid { get; set; }
        public decimal? Percentapp { get; set; }
        public string? Branchid { get; set; }
        public string? Changeordzone { get; set; }
        public DateTime? Expiredate { get; set; }
        public string? Viewordzone { get; set; }
        public string? Canappall { get; set; }
        public string? Typeapprove { get; set; }
        public string? Canshort { get; set; }
        public string? Cancovershort { get; set; }
        public string? Ordentrystyle { get; set; }
        public string? Ordentryseq { get; set; }
        public string? Viewordseq { get; set; }
        public string? Cancelconfirm { get; set; }
        public decimal? Buylimit { get; set; }
        public decimal? Selllimit { get; set; }
    }
}
