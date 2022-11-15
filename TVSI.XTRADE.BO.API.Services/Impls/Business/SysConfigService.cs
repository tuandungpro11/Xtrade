using TVSI.XTRADE.BO.API.Models.Model.Request.SysConfig;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class SysConfigService : BaseService<SysConfigService>, ISysConfigService
{
    private readonly IDapperHelper _dapper;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public SysConfigService(ILogger<SysConfigService> logger, IConfiguration config, IDapperHelper dapper)
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

    public async Task<Response<dynamic>?> GetSysConfigListAsync(SysConfigListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@category", model.Category, DbType.String, ParameterDirection.Input);
            param.Add("@group", model.Group, DbType.String, ParameterDirection.Input);
            param.Add("@code", model.Code, DbType.String, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_SYSCONFIG", param,
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

    public async Task<Response<dynamic>?> GetConfigurationListAsync(ConfigurationListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@name", model.Name, DbType.String, ParameterDirection.Input);
            param.Add("@pageindex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@pagesize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SP_SEL_Configuration_BO", param,
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

    public async Task<Response<int>?> UpdateConfigurationListAsync(string? json)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@json", json, DbType.String, ParameterDirection.Input);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UDP_LIST_CONFIGURATION", param, _sqlTimeout);

            return new Response<int>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
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

    public async Task<Response<dynamic>?> GetAllChannelAsync()
    {
        try
        {
            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SP_SEL_OrderSource", null!,
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

    public async Task<Response<int>?> UpdateFeeTaxChannelAsync(FeeTaxChannelRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@ID", model.Id, DbType.String, ParameterDirection.Input);
            param.Add("@FEERATIO", model.FeeRatio, DbType.String, ParameterDirection.Input);
            param.Add("@MinFee", model.MinFee, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);

            await _dapper.ExecuteAsync(_innoTradeConn, "SP_UDP_BO_ORDERSOURCE", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int?>("@Result");
            return new Response<int>
            {
                Code = (result is (int)ErrorCodeDetail.Success or null
                    ? (int)ErrorCodeDetail.Success
                    : (int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = result is (int)ErrorCodeDetail.Success or null
                    ? ErrorCodeDetail.Success.ToEnumDescription()
                    : ErrorCodeDetail.Failed.ToEnumDescription(),
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

    public async Task<Response<dynamic>?> GetNotifierListAsync(NotifierListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@AccountNo", model.AccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@NotifyAction", model.NotifyAction, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);
            param.Add("@RowCount", null, DbType.Int32, ParameterDirection.Output);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SP_SEL_BO_NOTIFIER", param,
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
}