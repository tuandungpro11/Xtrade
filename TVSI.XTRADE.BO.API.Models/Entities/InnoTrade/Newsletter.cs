namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Newsletter
    {
        public long Newslettersid { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Categoryid { get; set; }
        public bool? Ispublished { get; set; }
        public string? Quotes { get; set; }
        public DateTime? Createdate { get; set; }
        public string? Createby { get; set; }
        public DateTime? Publisheddate { get; set; }
        public DateTime? Lastmodified { get; set; }
        public string? Modifiedby { get; set; }
        public string? Attachedfile { get; set; }
        public int? LangId { get; set; }
    }
}
