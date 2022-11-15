using Microsoft.EntityFrameworkCore;

namespace TVSI.XTRADE.BO.API.Services.Impls.Core
{
    public class DistributeCacheService : BaseService<DistributeCacheService>, IDistributeCacheService
    {
        private readonly DemoDbContext _dbContext;
        private readonly IRedisService _redisCache;
        private readonly int _timeout;

        public DistributeCacheService(IRedisService redisCache,
            ILogger<DistributeCacheService> logger, DemoDbContext dbContext, IConfiguration config)
            : base(logger, config)
        {
            _dbContext = dbContext;
            _redisCache = redisCache;
            _timeout = 0; //seconds
        }

        //implement methods has been define in interface
        public async Task LoadDataToCache()
        {
            await LoadErrCodeToCache();
        }

        #region ErrorCode

        private async Task LoadErrCodeToCache()
        {
            var key = CacheKeys.SysErrCode;
            var data = await GetSysErrCode();
            _redisCache.SetKey(key, data, _timeout);
        }

        private List<ErrorCode> GetListErrCodeFromCache()
        {
            var key = CacheKeys.SysErrCode;
            return _redisCache.GetKey<List<ErrorCode>>(key);
        }

        public string? GetErrCodeMessage(int errCode, string channel, string lang)
        {
            var errInfo = GetListErrCodeFromCache()
                .FirstOrDefault(m => m.ErrCode == errCode.ToString() && m.Active == true && (m.Channel == Channel.All.ToEnumDescription() || ("," + m.Channel + ",").Contains("," + channel + ",")));
            return lang == Language.Vi.ToEnumDescription() ? errInfo?.ErrMsgVi : errInfo?.ErrMsgEn;
        }

        #endregion ErrorCode

        #region Get Data async from DB

        private async Task<List<ErrorCode>> GetSysErrCode()
        {
            try
            {
                return await _dbContext.ErrorCodes.ToListAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                _logger.LogError($"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
                return null;
            }
        }
        #endregion Get Data async from DB
    }
}