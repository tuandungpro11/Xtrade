using TVSI.XTRADE.BO.API.Models.Model.Request.CustomerGroup;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class CustomerGroupService : BaseService<CustomerGroupService>, ICustomerGroupService
{
    private readonly IDapperHelper _dapper;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public CustomerGroupService(ILogger<CustomerGroupService> logger, IConfiguration config, IDapperHelper dapper)
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

    public async Task<Response<dynamic>?> GetCustomerGroupListAsync(CustomerGroupListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@ID", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@AccountType", model.AccountType, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_CUSTOMERGROUP", param, _sqlTimeout)
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

    public async Task<Response<int>> CreateCustomerGroupAsync(CustomerGroupRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@NAME", model.Name, DbType.String, ParameterDirection.Input);
            param.Add("@DESCRIPTION", model.Description, DbType.String, ParameterDirection.Input);
            param.Add("@ACCOUNTYPE", model.AccountType, DbType.Int32, ParameterDirection.Input);
            param.Add("@ACTIVE", model.Active, DbType.Byte, ParameterDirection.Input);
            param.Add("@CREATEDATE", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            param.Add("@LEVEL", model.Level, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_INS_CUSTOMERGROUP", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@Result");
            var message = param.Get<string>("@Message");
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

    public async Task<Response<int>> UpdateCustomerGroupAsync(CustomerGroupRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@ID", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@NAME", model.Name, DbType.String, ParameterDirection.Input);
            param.Add("@DESCRIPTION", model.Description, DbType.String, ParameterDirection.Input);
            param.Add("@ACCOUNTYPE", model.AccountType, DbType.Int32, ParameterDirection.Input);
            param.Add("@ACTIVE", model.Active, DbType.Byte, ParameterDirection.Input);
            param.Add("@CREATEDATE", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            param.Add("@LEVEL", model.Level, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UDP_CUSTOMERGROUP", param, _sqlTimeout);

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

    public async Task<Response<int>> DeleteCustomerGroupAsync(int groupId)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@GroupID", groupId, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_DEL_CUSTOMERGROUP", param, _sqlTimeout);

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
}