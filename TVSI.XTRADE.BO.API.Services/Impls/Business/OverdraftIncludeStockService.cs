using TVSI.XTRADE.BO.API.Models.Model.Request.OverdraftIncludeStock;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class OverdraftIncludeStockService : BaseService<OverdraftIncludeStockService>, IOverdraftIncludeStockService
{
    private readonly IDapperHelper _dapper;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public OverdraftIncludeStockService(ILogger<OverdraftIncludeStockService> logger, IConfiguration config,
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

    public async Task<Response<dynamic>?> GetOverdraftIncludeStockListAsync(OverdraftIncludeStockListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@FromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@ToDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_BO_UF_ODF_SEL_OverdraftIncludeStock", param,
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


    public async Task<Response<int>> ModifyOverdraftIncludeStockAsync(OverdraftIncludeStockRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int16, ParameterDirection.Input);
            param.Add("@EffectDate", model.EffectDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@ExpireDate", model.ExpireDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_UF_ODF_INSUPD_OverdraftIncludeStock", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@result");
            var message = param.Get<string>("@message");
            return new Response<int>
            {
                Code = (result is  (int)ErrorCodeDetail.Success
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

    public async Task<Response<int>> DeleteOverdraftIncludeStockAsync(int id)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", id, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_UF_ODF_DEL_OverdraftIncludeStock", param,
                _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@Result");
            var message = param.Get<string>("@Message");
            return new Response<int>
            {
                Code = (result is (int)ErrorCodeDetail.Success
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

    public async Task<Response<dynamic>?> GetOverdraftIncludeStockHistoryListAsync(
        OverdraftIncludeStockListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@FromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@ToDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_BO_UF_ODF_SEL_OverdraftIncludeStockHistory",
                    param, _sqlTimeout)
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