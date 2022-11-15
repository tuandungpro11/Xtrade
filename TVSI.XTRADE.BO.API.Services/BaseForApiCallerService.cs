

namespace TVSI.XTRADE.BO.API.Services;

public abstract class BaseForApiCallerService<T> where T : class
{
    protected readonly IConfiguration _config;
    protected readonly ILogger<T> _logger;
    protected readonly IApiCallerService _apiCaller;

    protected BaseForApiCallerService(ILogger<T> logger, IConfiguration config, IApiCallerService apiCaller)
    {
        _logger = logger;
        _config = config;
        _apiCaller = apiCaller;
    }

    #region Helper method

    public async Task<ResponsePartner> PasiotApiCallerHelper(string url, string payload,
        Dictionary<string, string> headers, ApiMethod apiMethod)
    {
        try
        {
            var (resCode, resMesg, resData) = await _apiCaller.ApiCaller(url, payload, apiMethod, headers);
            if (resCode != (int)ErrorCodeApi.Success)
                return new ResponsePartner
                {
                    Code = ((int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                    Message = resMesg
                };

            var apiResponse = JsonConvert.DeserializeObject<PasiotResponse>(resData);
            if (apiResponse is { retCode: "000" })
                return new ResponsePartner
                {
                    Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                    Message = ErrorCodeDetail.Success.ToEnumDescription(),
                    Data = apiResponse.retData
                };

            return new ResponsePartner
            {
                Code = ((int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = $"PasiotApi-{apiResponse?.retMsg}"
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new ResponsePartner
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }
    #endregion Helper method
}