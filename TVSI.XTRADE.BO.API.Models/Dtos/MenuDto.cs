namespace TVSI.XTRADE.BO.API.Models.Dtos
{
    public class MenuDto
    {
        public string PkMenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuNameEn { get; set; }
        public string FkFunctionCode { get; set; }
        public string MenuUrl { get; set; }
        public string MenuDescription { get; set; }
        public string MenuDescriptionEn { get; set; }
        public string MenuParentId { get; set; }
        public int SortOrder { get; set; }
        public List<MenuDto> SubMenus { get; set; }
    }
}