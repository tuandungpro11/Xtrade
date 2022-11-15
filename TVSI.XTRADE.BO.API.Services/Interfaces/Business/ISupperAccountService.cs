namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface ISupperAccountService
{
    Task<Response<dynamic>> GetSupperAccountListAsync(SupperAccountListRequest model);
    Task<ResponseSingle<dynamic>> GetSupperAccountDetailAsync(long id);
    Task<Response<int>> CreateSupperAccountAsync(SupperAccountCreateRequest model);
    Task<Response<int>> UpdateSupperAccountAsync(SupperAccountUpdateRequest model);
    Task<Response<int>> DeleteSupperAccountAsync(SupperAccountDelRequest model);
    Task<Response<int>> ChangeActiveSupperAccountAsync(SupperAccountActiveRequest model);

}