using TVSI.XTRADE.BO.API.Models.Model.Request.SysConfig;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface ISysConfigService
{
    Task<Response<dynamic>?> GetSysConfigListAsync(SysConfigListRequest model);
    Task<Response<dynamic>?> GetConfigurationListAsync(ConfigurationListRequest model);
    Task<Response<int>?> UpdateConfigurationListAsync(string? json); 
    Task<Response<dynamic>?> GetAllChannelAsync();
    Task<Response<int>?> UpdateFeeTaxChannelAsync(FeeTaxChannelRequest model);
    Task<Response<dynamic>?> GetNotifierListAsync(NotifierListRequest model);
}