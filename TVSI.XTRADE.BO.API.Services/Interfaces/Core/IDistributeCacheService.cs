namespace TVSI.XTRADE.BO.API.Services.Interfaces.Core
{
    public interface IDistributeCacheService
    {
        //define methods for load data from database and save to cache
        Task LoadDataToCache();
        string? GetErrCodeMessage(int errCode, string channel, string lang);
    }
}