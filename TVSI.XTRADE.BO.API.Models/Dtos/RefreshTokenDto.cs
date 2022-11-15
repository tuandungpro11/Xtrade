using TVSI.XTRADE.BO.API.Models.Entities.Demo;

namespace TVSI.XTRADE.BO.API.Models.Dtos
{
    public class RefreshTokenDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<RefreshToken> RefreshToken { get; set; }
    }
}