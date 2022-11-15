using TVSI.XTRADE.BO.API.Models.Model.Request.Asset;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class AssetService : BaseForApiCallerService<AssetService>, IAssetService
{
    private readonly string _pasiotApiTrading;

    public AssetService(ILogger<AssetService> logger, IConfiguration config, IDapperHelper dapper,
        IApiCallerService apiCaller)
        : base(logger, config, apiCaller)
    {
        _pasiotApiTrading = _config["PasiotApi:Trading"];
    }

    public async Task<ResponsePartner> GetAssetDetailAsync(AssetDetailRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:Asset:Detail"]}";
        return await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
    }

    public async Task<ResponsePartner> GetLastestAssetHistoryAsync(AssetHistoryRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:Asset:History"]}";
        return await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
    }
}