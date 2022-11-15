using TVSI.XTRADE.BO.API.Attribute;
using TVSI.XTRADE.BO.API.Models.Enums;
using TVSI.XTRADE.BO.API.Models.Model;
using TVSI.XTRADE.BO.API.Models.Model.Request;
using TVSI.XTRADE.BO.API.Models.Model.Response;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class AuthController : BaseController<AuthController>
    {
        private readonly IAuthService _authService;
        private readonly IDistributeCacheService _distributeCache;
        public AuthController(IDistributeCacheService distributeCache, IAuthService authService, ILogger<AuthController> logger, IConfiguration config, IDetectionService detection)
            : base(logger, config, detection)
        {
            _distributeCache = distributeCache;
            _authService = authService;
        }

        /// <summary>
        /// Get application environment information
        /// </summary>
        /// <returns> Returns application environment information </returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/Environment
        ///     {
        ///     }
        /// 
        /// </remarks>
        [AllowAnonymous]
        [HttpPost("Environment")]
        public IActionResult GetEnvironment()
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return Ok($"The application is being installed on {env} environment [Machine: {Environment.MachineName}, " +
                      $"User Domain: {Environment.UserDomainName}, user: {Environment.UserName}]");
        }

        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/Authenticate
        ///     {
        ///         "Username": "demo",
        ///         "password": "demo"
        ///     }
        /// 
        /// </remarks>
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticateRequest model)
        {
            await _distributeCache.LoadDataToCache();

            var detectInfo = GetDetectionInfo();
            var response = await _authService.AuthenticateAsync(model, detectInfo);

            _logger.LogInformation($"{MethodBase.GetCurrentMethod()?.Name}: {JsonConvert.SerializeObject(response)}");
            return Ok(response);
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/Logout
        ///     {
        ///     }
        /// 
        /// </remarks>
        [TokenBlackList]
        [HttpPost("Logout")]
        public IActionResult Logout()
        {
            var accessToken = Request.Headers["Authorization"].ToString().Replace(CommonConstants.SchemaAuth, "");
            var Username = HttpContext.User.Claims.FirstOrDefault(c =>
                c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;

            var response = _authService.Logout(accessToken, Username);
            return Ok(response);
        }

        /// <summary>
        /// Lock login for an account
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/LockLogin/demo
        /// 
        /// </remarks>
        [TokenBlackList]
        [HttpPost("LockLogin/{Username}")]
        public IActionResult LockLogin(string Username)
        {
            var userLogin = HttpContext.User.Claims.FirstOrDefault(c =>
                c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            
            var response = _authService.LockLogin(Username, true);
            return Ok(response);
        }

        /// <summary>
        /// UnLock login for an accounts login failed over number of times allowed
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/UnLockLogin/demo
        /// 
        /// </remarks>
        [TokenBlackList]
        [HttpPost("UnLockLogin/{Username}")]
        public IActionResult UnLockLogin(string Username)
        {
            var response = _authService.UnlockLogin(Username);
            return Ok(response);
        }

        /// <summary>
        /// Returns a new JWT authentication token and the user details and generate a new refresh token, the old refresh token is revoked.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/RefreshToken
        ///     {
        ///         "refreshToken": "Wx2vs9H4mlw0JPbHvmLwSy4fHGcsbS0FQsCX2egj0MFTzACrqMoGN3RbeyLMac4vawDPf"
        ///     }
        /// 
        /// </remarks>
        [AllowAnonymous]
        [HttpPost("RefreshToken")]
        public IActionResult RefreshToken(RefreshTokenRequest model)
        {
            var refreshToken = model.RefreshToken; //Request.Cookies["refreshToken"];

            if (string.IsNullOrEmpty(refreshToken))
                return Ok(new Response<AuthenticateResponse>()
                {
                    Code = ((int)ErrorCodeDetail.InvalidToken).ErrorCodeFormat(),
                    Message = _distributeCache.GetErrCodeMessage((int)ErrorCodeDetail.InvalidToken, Channel.Back.ToEnumDescription(), Language.Vi.ToEnumDescription()),
                    Data = null
                });

            var response = _authService.RefreshToken(refreshToken, GetDetectionInfo());

            return Ok(response);
        }

        /// <summary>
        /// Revoke a refresh token.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/RevokeToken
        ///     {
        ///         "refreshToken": "Wx2vs9H4mlw0JPbHvmLwSy4fHGcsbS0FQsCX2egj0MFTzACrqMoGN3RbeyLMac4vawDPf"
        ///     }
        /// 
        /// </remarks>
        [TokenBlackList]
        [HttpPost("RevokeToken")]
        public IActionResult RevokeToken(RefreshTokenRequest model)
        {
            var token = model.RefreshToken;
            if (string.IsNullOrEmpty(token))
                return Ok(new Response<AuthenticateResponse>()
                {
                    Code = ((int)ErrorCodeDetail.TokenRequired).ErrorCodeFormat(),
                    Message = _distributeCache.GetErrCodeMessage((int)ErrorCodeDetail.TokenRequired, Channel.Back.ToEnumDescription(), Language.Vi.ToEnumDescription()),
                    Data = null
                });

            var response = _authService.RevokeRefreshToken(token, GetIpAddress());

            if (!response)
                return Ok(new Response<AuthenticateResponse>()
                {
                    Code = ((int)ErrorCodeDetail.TokenNotFound).ErrorCodeFormat(),
                    Message = _distributeCache.GetErrCodeMessage((int)ErrorCodeDetail.TokenNotFound, Channel.Back.ToEnumDescription(), Language.Vi.ToEnumDescription()),
                    Data = null
                });

            return Ok(new Response<AuthenticateResponse>()
            {
                Code = $"{(int)ErrorCodeDetail.Success}",
                Message = _distributeCache.GetErrCodeMessage((int)ErrorCodeDetail.Success, Channel.Back.ToEnumDescription(), Language.Vi.ToEnumDescription()),
                Data = null
            });
        }

        /// <summary>
        /// Returns a list of all refresh tokens (active and revoked) of the user with the specified id.
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/RefreshTokens/demo
        /// 
        /// </remarks>
        [TokenBlackList]
        [HttpGet("RefreshTokens/{Username}")]
        public IActionResult GetRefreshTokens(string Username)
        {
            var response = _authService.GetRefreshTokenByUsername(Username);
            return Ok(response);
        }

        /// <summary>
        /// Returns the details of the user with the specified id.
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/UserInfo/demo
        /// 
        /// </remarks>
        [TokenBlackList]
        [HttpGet("UserInfo/{Username}")]
        public IActionResult GetUserById(string Username)
        {
            var user = _authService.GetUserByUsername(Username);
            return Ok(user);
        }

        /// <summary>
        /// Returns a list of all the users in the application
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/Auth/GetAll
        /// 
        /// </remarks>
        [TokenBlackList]
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var users = _authService.GetAll();
            return Ok(users);
        }
    }
}
