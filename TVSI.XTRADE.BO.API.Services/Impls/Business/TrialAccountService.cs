namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class TrialAccountService : BaseService<TrialAccountService>, ITrialAccountService
{
    private readonly string _commonDbConn;
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly int _sqlTimeout;

    public TrialAccountService(ILogger<TrialAccountService> logger, IConfiguration config, IDapperHelper dapper,
        IFileService fileService)
        : base(logger, config)
    {
        _dapper = dapper;

        _fileService = fileService;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var connStr = _config.GetConnectionString("CommonDB");
        _commonDbConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;

        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);
    }

    public async Task<Response<dynamic>?> GetTrialAccountListAsync(string? custCode, int status)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@custCode", custCode, DbType.String, ParameterDirection.Input);
            param.Add("@status", status, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_commonDbConn, "SPXT_DANH_SACH_XTRADE_LIST", param,
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

    public async Task<ResponseSingle<dynamic>?> GetTrialAccountDetailAsync(string custCode)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@custCode", custCode, DbType.String, ParameterDirection.Input);

            return new ResponseSingle<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_commonDbConn, "SPXT_DANH_SACH_XTRADE_DETAIL", param,
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


    public async Task<Response<int>> AddTrialAccountAsync(string custCode)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustCode", custCode, DbType.String, ParameterDirection.Input);
            param.Add("@CreatedBy", "system", DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_commonDbConn, "SPXT_DANH_SACH_XTRADE_ADD", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@Result");
            var message = param.Get<string>("@Message");

            return new Response<int>
            {
                Code = (result > 0
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

    public async Task<Response<int>> ChangeActiveTrialAccountAsync(string custCode, int status)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustCode", custCode, DbType.String, ParameterDirection.Input);
            param.Add("@Status", status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_commonDbConn, "SPXT_DANH_SACH_XTRADE_CHANGE_ACTIVE", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@Result");
            var message = param.Get<string>("@Message");

            return new Response<int>
            {
                Code = (result > 0
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

    public async Task<FileStream> ExportTrialAccountListAsync(string? custCode, int status, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var response = await GetTrialAccountListAsync(custCode, status);
            if (response?.Code != ((int)ErrorCodeDetail.Success).ErrorCodeFormat())
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, response);
                return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            }

            var dt = JsonConvert.SerializeObject(response.Data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:TrialAccount"]}";
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