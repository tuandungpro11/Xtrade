using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftAccount;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class OverdraftAccountService : BaseService<OverdraftAccountService>, IOverdraftAccountService
{
    private readonly IDapperHelper _dapper;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public OverdraftAccountService(ILogger<OverdraftAccountService> logger, IConfiguration config,
        IDapperHelper dapper)
        : base(logger, config)
    {
        _dapper = dapper;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var connStr = _config.GetConnectionString("InnoTrade");
        _innoTradeConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;

        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);
    }

    public async Task<Response<dynamic>?> GetOverdraftAccountListAsync(OverdraftAccountListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@ServiceName", model.ServiceName, DbType.String, ParameterDirection.Input);
            param.Add("@AccountID", model.AccountId, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int16, ParameterDirection.Input);
            param.Add("@FromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@ToDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_BO_UF_ODF_SEL_OverdraftAccountList", param,
                    _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<int>> ModifyOverdraftAccountAsync(OverdraftAccountRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@AccountID", model.AccountId, DbType.String, ParameterDirection.Input);
            param.Add("@OverdraftServiceID", model.OverdraftServiceId, DbType.Int64, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@EffectDate", model.EffectDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@ExpireDate", model.ExpireDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_UF_ODF_INSUPD_OverdraftAccountList", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int?>("@result");
            var message = param.Get<string>("@message");
            return new Response<int>
            {
                Code = (result is (int)ErrorCodeDetail.Success or null
                    ? (int)ErrorCodeDetail.Success
                    : (int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = message,
                Data = null
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<int>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<int>> DeleteOverdraftAccountAsync(int id)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@id", id, DbType.Int32, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_UF_ODF_DEL_OverdraftAccountList", param,
                _sqlTimeout);

            var result = param.Get<int?>("@result");
            var message = param.Get<string>("@message");
            return new Response<int>
            {
                Code = (result is (int)ErrorCodeDetail.Success or null
                    ? (int)ErrorCodeDetail.Success
                    : (int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = message,
                Data = null
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<int>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }
}