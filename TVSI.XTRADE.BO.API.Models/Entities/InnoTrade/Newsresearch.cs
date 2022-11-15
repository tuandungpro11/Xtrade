namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Newsresearch
    {
        public long Newsresearchid { get; set; }
        public string Title { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Introduction { get; set; } = null!;
        public string Content { get; set; } = null!;
        public long Categoryid { get; set; }
        public bool Ispublished { get; set; }
        public string? Quotes { get; set; }
        public DateTime Createdate { get; set; }
        public string Createby { get; set; } = null!;
        public DateTime? Publisheddate { get; set; }
        public DateTime Lastmodified { get; set; }
        public string Modifiedby { get; set; } = null!;
        public string Attachedfile { get; set; } = null!;
        public string Source { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Numviews { get; set; }
        public int Languageid { get; set; }
        public int? Customergroupid { get; set; }
        public bool? IsHotNews { get; set; }
        public string? NewsresearchidExt { get; set; }
        public string? Sourceid { get; set; }

        public virtual Newsresearchcategory Category { get; set; } = null!;
    }
}
