using TVSI.XTRADE.BO.API.Models.Model.Request.ExTrader;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class ExTraderService : BaseService<ExTraderService>, IExTraderService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public ExTraderService(ILogger<ExTraderService> logger, IConfiguration config, IDapperHelper dapper, IFileService fileService)
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

    public async Task<Response<dynamic>> GetExTraderListAsync(ExTraderListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@ExTraderID", model.ExTraderId, DbType.Int64, ParameterDirection.Input);
            param.Add("@TraderID", model.TraderId, DbType.String, ParameterDirection.Input);
            param.Add("@Branch", model.Branch, DbType.String, ParameterDirection.Input);
            param.Add("@TraderType", model.TraderType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@FromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@ToDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_BO_UF_OC_ExTrader_GetList", param,
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

    public async Task<Response<int>> CreateExTraderAsync(ExTraderCreateRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@TraderID", model.TraderId, DbType.String, ParameterDirection.Input);
            param.Add("@TraderType", model.TraderType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int16, ParameterDirection.Input);
            param.Add("@EffDate", model.EffDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@ExpDate", model.ExpDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_UF_OC_ExTrader_Create", param, _sqlTimeout);

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


    public async Task<Response<int>> UpdateExTraderAsync(ExTraderUpdateRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@ExTraderID", model.ExTraderId, DbType.Int64, ParameterDirection.Input);
            param.Add("@TraderID", model.TraderId, DbType.String, ParameterDirection.Input);
            param.Add("@TraderType", model.TraderType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int16, ParameterDirection.Input);
            param.Add("@EffDate", model.EffDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@ExpDate", model.ExpDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_UF_OC_ExTrader_Update", param, _sqlTimeout);

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


    public async Task<Response<int>> DeleteExTraderAsync(long traderId)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@ExTraderID", traderId, DbType.Int64, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_UF_OC_ExTrader_Delete", param, _sqlTimeout);

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

    public async Task<Response<dynamic>> CheckExTraderAsync(ExTraderCheckRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@AgentId", model.AgentId, DbType.String, ParameterDirection.Input);
            param.Add("@AgentType", model.AgentType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Islike", model.IsLike, DbType.Byte, ParameterDirection.Input);
            param.Add("@PageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SP_SEL_AGENT", param, _sqlTimeout)
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


    public async Task<Response<int>> CreateLogExTraderAsync(ExTraderLogRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@UserID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@ActionType", model.ActionType, DbType.Int16, ParameterDirection.Input);
            param.Add("@OldInfo", model.OldInfo, DbType.String, ParameterDirection.Input);
            param.Add("@NewInfo", model.NewInfo, DbType.String, ParameterDirection.Input);
            param.Add("@IP", model.IP, DbType.String, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@Module", model.Module, DbType.String, ParameterDirection.Input);

            await _dapper.ExecuteAsync(_innoTradeConn, "SP_INS_LogInfo_Insert", param, _sqlTimeout);

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

    public async Task<FileStream> ExportExTraderListAsync(ExTraderListExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var param = new DynamicParameters();
            param.Add("@ExTraderID", model.ExTraderId, DbType.Int64, ParameterDirection.Input);
            param.Add("@TraderID", model.TraderId, DbType.String, ParameterDirection.Input);
            param.Add("@Branch", model.Branch, DbType.String, ParameterDirection.Input);
            param.Add("@TraderType", model.TraderType, DbType.Int32, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@FromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@ToDate", model.ToDate, DbType.String, ParameterDirection.Input);


            var data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_BO_UF_OC_EXP_ExTrader_GetList", param,
                _sqlTimeout);

            var dt = JsonConvert.SerializeObject(data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:ExTraderId"]}";
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