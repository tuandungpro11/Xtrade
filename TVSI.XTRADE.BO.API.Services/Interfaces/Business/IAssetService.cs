using TVSI.XTRADE.BO.API.Models.Model.Request.Asset;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IAssetService
{
    Task<ResponsePartner> GetAssetDetailAsync(AssetDetailRequest model);
    Task<ResponsePartner> GetLastestAssetHistoryAsync(AssetHistoryRequest model);
}