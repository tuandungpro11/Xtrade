namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class TvsiWatchList
    {
        public long WatchListId { get; set; }
        public string WatchList { get; set; } = null!;
        public string Symbols { get; set; } = null!;
        public int Priority { get; set; }
        public string CustomerId { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int Status { get; set; }
    }
}
