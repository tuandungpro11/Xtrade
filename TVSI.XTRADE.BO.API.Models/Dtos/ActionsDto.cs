namespace TVSI.XTRADE.BO.API.Models.Dtos
{
    public class ActionsDto
    {
        public string ActionCode { get; set; }
        public string ActionName { get; set; }
        public List<RoleDataDto> RoleData { get; set; }
    }
}