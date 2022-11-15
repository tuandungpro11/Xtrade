namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class RightRegistrationService : BaseService<RightRegistrationService>, IRightRegistrationService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public RightRegistrationService(ILogger<RightRegistrationService> logger, IConfiguration config, IDapperHelper dapper, IFileService fileService)
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

    public async Task<Response<dynamic>> GetRightRegistrationListAsync(RightRegistrationListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@AccountNo", model.AccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@ContractNo", model.ContractNo, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateFrom", model.RightDateFrom, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateTo", model.RightDateTo, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@UserIDEdit", model.UserIdEdit, DbType.String, ParameterDirection.Input);
            param.Add("@BranchID", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerType", model.CustomerType, DbType.Int32, ParameterDirection.Input);
            param.Add("@PendingStatusID", model.PendingStatusId, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_RIR_BO_STATUS", param,
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

    public async Task<Response<dynamic>> GetRightRegistrationHistAsync(RightRegistrationHistRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@AccountNo", model.AccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@ContractNo", model.ContractNo, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateFrom", model.RightDateFrom, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateTo", model.RightDateTo, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@XType", model.XType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@UserIDEdit", model.UserIdEdit, DbType.String, ParameterDirection.Input);
            param.Add("@PageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_RIR_BO_HISTORY", param,
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
    public async Task<Response<dynamic>> GetRightStockListAsync(RightStockListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@XType", model.XType, DbType.Int32, ParameterDirection.Input);
            param.Add("@RightDateFrom", model.RightDateFrom, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateTo", model.RightDateTo, DbType.String, ParameterDirection.Input);
            param.Add("@PageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_RIGHTREGISTRATION_ALERT", param,
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

    public async Task<ResponseSingle<dynamic>> GetRightRegistrationDetailAsync(long id)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", id, DbType.Int64, ParameterDirection.Input);

            return new ResponseSingle<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.GetAsync<dynamic>(_innoTradeConn, "SPXT_SEL_RIR_BO_STATUS_BYID", param,
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

    public async Task<Response<int>> ChangeStatusRightRegistrationAsync(RightRegistrationStatusRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Reason", model.Reason, DbType.String, ParameterDirection.Input);
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_APP_RIR_BO_STATUS", param, _sqlTimeout);

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

    public async Task<FileStream> ExportRightRegistrationListAsync(RightRegistrationListExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@AccountNo", model.AccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@ContractNo", model.ContractNo, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateFrom", model.RightDateFrom, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateTo", model.RightDateTo, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@UserIDEdit", model.UserIdEdit, DbType.String, ParameterDirection.Input);
            param.Add("@BranchID", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerType", model.CustomerType, DbType.Int32, ParameterDirection.Input);
            param.Add("@PendingStatusID", model.PendingStatusId, DbType.Int32, ParameterDirection.Input);

            var data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_EXP_RIR_BO_STATUS", param,
                _sqlTimeout);

            var dt = JsonConvert.SerializeObject(data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:RightStatus"]}";
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

    public async Task<FileStream> ExportRightRegistrationHistAsync(RightRegistrationHistExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@AccountNo", model.AccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@ContractNo", model.ContractNo, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateFrom", model.RightDateFrom, DbType.String, ParameterDirection.Input);
            param.Add("@RightDateTo", model.RightDateTo, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@XType", model.XType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@UserIDEdit", model.UserIdEdit, DbType.String, ParameterDirection.Input);

            var data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_EXP_RIR_BO_HISTORY", param,
                _sqlTimeout);

            var dt = JsonConvert.SerializeObject(data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:RightHist"]}";
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