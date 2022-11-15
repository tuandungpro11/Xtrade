using TVSI.XTRADE.BO.API.Models.Model.Request.BankAccount;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class BankAccountService : BaseService<BankAccountService>, IBankAccountService
{
    private readonly IDapperHelper _dapper;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public BankAccountService(ILogger<BankAccountService> logger, IConfiguration config, IDapperHelper dapper)
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

    public async Task<Response<dynamic>> GetBankAccountListAsync(BankAccountListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@BankAccountId", model.BankAccountId, DbType.Int64, ParameterDirection.Input);
            param.Add("@BankAccount", model.BankAccount, DbType.String, ParameterDirection.Input);
            param.Add("@isLike", model.IsLike, DbType.Byte, ParameterDirection.Input);
            param.Add("@status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@FromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@ToDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@PageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_BankAccount_BO", param,
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

    public async Task<ResponseSingle<dynamic>> GetBankAccountDetailAsync(long bankAccountId)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@BankAccountId", bankAccountId, DbType.Int64, ParameterDirection.Input);

            return new ResponseSingle<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.GetAsync<dynamic>(_innoTradeConn, "SPXT_SEL_BANKACCOUNT_BO_BYID", param,
                    _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new ResponseSingle<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<int>> CreateBankAccountAsync(BankAccountCreateRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@BankAccount", model.BankAccount, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@Beneficiary", model.Beneficiary, DbType.String, ParameterDirection.Input);
            param.Add("@BankName", model.BankName, DbType.String, ParameterDirection.Input);
            param.Add("@Province", model.Province, DbType.String, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@Priority", model.Priority, DbType.Int32, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@URLPath", model.URLPath, DbType.String, ParameterDirection.Input);
            param.Add("@BankNo", model.BankNo, DbType.String, ParameterDirection.Input);
            param.Add("@BranchNo", model.BranchNo, DbType.String, ParameterDirection.Input);
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@bankType", model.BankType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_INS_BankAccount", param, _sqlTimeout);

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

    public async Task<Response<int>> UpdateBankAccountAsync(BankAccountUpdateRequest model)
    {
        try
        {
            var param = new DynamicParameters();

            param.Add("@BankAccountID", model.BankAccountId, DbType.Int64, ParameterDirection.Input);
            param.Add("@Reason", model.Reason, DbType.String, ParameterDirection.Input);
            param.Add("@BankAccount", model.BankAccount, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@Beneficiary", model.Beneficiary, DbType.String, ParameterDirection.Input);
            param.Add("@BankName", model.BankName, DbType.String, ParameterDirection.Input);
            param.Add("@Province", model.Province, DbType.String, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@Priority", model.Priority, DbType.Int32, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@URLPath", model.URLPath, DbType.String, ParameterDirection.Input);
            param.Add("@BankNo", model.BankNo, DbType.String, ParameterDirection.Input);
            param.Add("@BranchNo", model.BranchNo, DbType.String, ParameterDirection.Input);
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@bankType", model.BankType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UDP_BankAccount", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int?>("@Result");
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

    public async Task<Response<int>> ChangeStatusBankAccountAsync(BankAccountStatusRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@BankAccountId", model.BankAccountId, DbType.Int64, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Reason", model.Reason, DbType.String, ParameterDirection.Input);
            param.Add("@ModifiedBy", model.ModifiedBy, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_APP_BO_BANKACCOUNT", param, _sqlTimeout);
            
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
}