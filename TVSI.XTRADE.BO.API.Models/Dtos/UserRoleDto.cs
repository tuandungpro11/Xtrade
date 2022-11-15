namespace TVSI.XTRADE.BO.API.Models.Dtos
{
    public class UserRoleDto : UserDto
    {
        public string AuthorizeMethod { get; set; }
        public string UserMenu { get; set; }
        public List<FunctionsDto> Functions { get; set; }
    }
}