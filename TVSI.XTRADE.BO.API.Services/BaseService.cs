namespace TVSI.XTRADE.BO.API.Services;

public abstract class BaseService<T> where T : class
{
    protected readonly IConfiguration _config;
    protected readonly ILogger<T> _logger;

    protected BaseService(ILogger<T> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }
}