namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class InternalAccountService : BaseService<InternalAccountService>, IInternalAccountService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public InternalAccountService(ILogger<InternalAccountService> logger, IConfiguration config, IDapperHelper dapper, IFileService fileService)
        : base(logger, config)
    {
        _dapper = dapper;
        _fileService = fileService;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var connStr = _config.GetConnectionString("InnoTrade");
        _innoTradeConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;

        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);
    }

    public async Task<Response<dynamic>> GetInternalAccountListAsync(InterAccListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@userID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@beginDate", model.BeginDate, DbType.String, ParameterDirection.Input);
            param.Add("@endDate", model.EndDate, DbType.String, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_BO_INTERNALACCOUNT", param,
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

    public async Task<ResponseSingle<dynamic>> GetInternalAccountDetailAsync(InterAccDelRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@internalAccountNo", model.InternalAccountNo, DbType.String, ParameterDirection.Input);

            return new ResponseSingle<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.GetAsync<dynamic>(_innoTradeConn, "SPXT_SEL_BO_INTERNALACCOUNT_BYID", param,
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

    public async Task<Response<int>> ModifyInternalAccountAsync(InterAccRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@internalAccountNo", model.InternalAccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@newInternalAccountNo", model.NewInternalAccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@internalCustomerId", model.InternalCustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@internalCustomerName", model.InternalCustomerName, DbType.String, ParameterDirection.Input);
            param.Add("@internalCustomerNo", model.InternalCustomerNo, DbType.String, ParameterDirection.Input);
            param.Add("@InternalIdentityCard", model.InternalIdentityCard, DbType.String, ParameterDirection.Input);
            param.Add("@InternalAddress", model.InternalAddress, DbType.String, ParameterDirection.Input);
            param.Add("@internalStatus", model.InternalStatus, DbType.Int32, ParameterDirection.Input);
            param.Add("@internalScanURL", model.InternalScanURL, DbType.String, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@Reason", model.Reason, DbType.String, ParameterDirection.Input);
            param.Add("@date", model.Date, DbType.String, ParameterDirection.Input);
            param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UPD_INTERNALACCOUNT_TVSI", param, _sqlTimeout);

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

    public async Task<Response<int>> DeleteInternalAccountAsync(InterAccDelRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@internalAccountNo", model.InternalAccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_DEL_INTERNALACCOUNT", param, _sqlTimeout);

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

    public async Task<Response<int>> ChangeStatusInternalAccountAsync(InterAccStatusRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@internalAccountNo", model.InternalAccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@internalStatus", model.InternalStatus, DbType.Int32, ParameterDirection.Input);
            param.Add("@reason", model.Reason, DbType.String, ParameterDirection.Input);
            param.Add("@modifiedBy", model.ModifiedBy, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_APP_BO_INTERNALACCOUNT", param, _sqlTimeout);

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

    public async Task<FileStream> ExportInternalAccountListAsync(InterAccListExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var param = new DynamicParameters();
            param.Add("@userID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@beginDate", model.BeginDate, DbType.String, ParameterDirection.Input);
            param.Add("@endDate", model.EndDate, DbType.String, ParameterDirection.Input);

            var data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_EXP_BO_INTERNALACCOUNT", param,
                _sqlTimeout);

            var dt = JsonConvert.SerializeObject(data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:InternalAccount"]}";
            _fileService.ExportDataToFileTemplate(fileExportPath, tempFile, ds, new[] { "{", "}" });

            return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");

            _fileService.ExportErrorMessageToFile(fileExportPath, ex.Message);
            return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
        }
    }
}