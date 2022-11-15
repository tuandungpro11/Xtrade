namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Breakingnews
    {
        public long Breakingnewsid { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int Languageid { get; set; }
        public bool? Ispublished { get; set; }
        public DateTime Createddate { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Publisheddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string? Modifiedby { get; set; }
        public string? Url { get; set; }
        public DateTime? Duedate { get; set; }
    }
}
