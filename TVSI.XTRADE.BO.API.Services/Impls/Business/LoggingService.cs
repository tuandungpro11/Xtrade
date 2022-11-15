using AutoMapper;
using TVSI.XTRADE.BO.API.Models.Model.Request.Logging;
using TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot.Logging;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class LoggingService : BaseForApiCallerService<LoggingService>, ILoggingService
{
    private readonly IDapperHelper _dapper;
    public readonly IMapper _mapper;
    private readonly IFileService _fileService;
    private readonly string _innoTradeConn;

    private readonly string _pasiotApiTrading;
    private readonly int _sqlTimeout;

    public LoggingService(ILogger<LoggingService> logger, IConfiguration config, IDapperHelper dapper,
        IApiCallerService apiCaller, IFileService fileService, IMapper mapper)
        : base(logger, config, apiCaller)
    {
        _dapper = dapper;
        _mapper = mapper;
        _fileService = fileService;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var connStr = _config.GetConnectionString("InnoTrade");
        _innoTradeConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;

        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);

        _pasiotApiTrading = _config["PasiotApi:Trading"];
    }

    public async Task<Response<dynamic>> GetLogLoginITradeHomeListAsync(LogLoginInnoRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Channel", model.Channel, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@BeginDate", model.BeginDate, DbType.String, ParameterDirection.Input);
            param.Add("@EndDate", model.EndDate, DbType.String, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_LOGINLOG", param, _sqlTimeout)
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

    public async Task<ResponsePartner> GetLogLoginListAsync(LogLoginPasiotRequest model)
    {
        model.ControllerName = string.IsNullOrEmpty(model.ControllerName) ? "system" : model.ControllerName;
        model.ActionName = string.IsNullOrEmpty(model.ActionName) ? "login" : model.ActionName;

        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:Log:Search"]}";
        return await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
    }

    public async Task<ResponsePartner> GetLogLoginDetailAsync(string traceId)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:Log:Detail"]}/?traceId={traceId}";
        return await PasiotApiCallerHelper(url, null, null, ApiMethod.GET);
    }

    public async Task<FileStream> ExportLogLoginListAsync(LogLoginPasiotExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            model.ControllerName = string.IsNullOrEmpty(model.ControllerName) ? "system" : model.ControllerName;
            model.ActionName = string.IsNullOrEmpty(model.ActionName) ? "login" : model.ActionName;

            var postData = _mapper.Map<LogLoginPasiotRequest>(model);
            var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:Log:Search"]}";
            var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(postData), null, ApiMethod.GET);

            if (data.Code != ((int)ErrorCodeDetail.Success).ErrorCodeFormat())
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, data);
                return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            }

            var jObj = JObject.Parse(data.Data?.ToString() ?? string.Empty);
            var listItems = jObj["items"];
            var dataConvert = JsonConvert.DeserializeObject<List<LogLoginResponse>>(listItems.ToString());
            var dt = JsonConvert.SerializeObject(dataConvert).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:PasiotLog"]}";
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

    public async Task<Response<dynamic>> GetLogSystemListAsync(LogSystemRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@USERID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CUSTOMERID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@ACTIONTYPE", model.ActionType, DbType.Int32, ParameterDirection.Input);
            param.Add("@BranchId", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@BeginDate", model.BeginDate, DbType.String, ParameterDirection.Input);
            param.Add("@EndDate", model.EndDate, DbType.String, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SP_SEL_SystemLogEX", param, _sqlTimeout)
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