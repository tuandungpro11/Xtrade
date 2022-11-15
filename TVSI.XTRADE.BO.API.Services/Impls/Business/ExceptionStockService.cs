using Microsoft.AspNetCore.Http;
using TVSI.XTRADE.BO.API.Models.Model.Request.NextPrice;
using TVSI.XTRADE.BO.API.Models.Model.Request.Stock;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class ExceptionStockService : BaseService<ExceptionStockService>, IExceptionStockService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly string _xtradeInnoTradeConn;
    private readonly int _sqlTimeout;

    public ExceptionStockService(ILogger<ExceptionStockService> logger, IConfiguration config, IDapperHelper dapper, IFileService fileService)
        : base(logger, config)
    {
        _dapper = dapper;
        _fileService = fileService;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var connStr = _config.GetConnectionString("xTradeInnoTradeDB");
        _xtradeInnoTradeConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;


        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);
    }

    public async Task<Response<dynamic>?> GetExceptionStockListAsync(ExceptionStockListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@fromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@toDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@langId", model.LangId, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);


            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_GET_EXCEPTIONSTOCKLIST",
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

    public async Task<Response<dynamic>?> GetStockInfoDetailAsync(StockInfoRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@languageId", model.LanguageId, DbType.Int32, ParameterDirection.Input);


            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_xtradeInnoTradeConn, "SPXT_BO_AD_SC_GETSTOCKINFO_BYID", param,
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


    public async Task<Response<int>> CreateExceptionStockAsync(ModifyExceptionStock model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@date", model.Date, DbType.String, ParameterDirection.Input);
            param.Add("@market", model.Market, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_INS_EXCEPTIONSTOCK", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@result");
            var message = param.Get<string>("@message");
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
    public async Task<Response<int>> UpdateExceptionStockAsync(ModifyExceptionStock model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@date", model.Date, DbType.String, ParameterDirection.Input);
            param.Add("@market", model.Market, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_UPD_EXCEPTIONSTOCK", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@result");
            var message = param.Get<string>("@message");
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
    public async Task<Response<int>> DeleteExceptionStockAsync(DeleteExceptionStockRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@fromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@toDate", model.ToDate, DbType.String, ParameterDirection.Input);

            var rowCount = await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_DEL_EXCEPTIONSTOCK", param,
                _sqlTimeout);

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
    public async Task<Response<ModifyExceptionStock>> ImportExceptionStockFromFileExcelAsync(IFormFile formFile, CancellationToken cancellationToken)
    {
        var msg = string.Empty;
        try
        {
            if (formFile is not { Length: > 0 })
                return new Response<ModifyExceptionStock>
                {
                    Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                    Message = "File cannot be empty."
                };

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase)
                && !Path.GetExtension(formFile.FileName).Equals(".xls", StringComparison.OrdinalIgnoreCase))
                return new Response<ModifyExceptionStock>
                {
                    Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                    Message = "Only support file extension .xls and .xlsx."
                };

            var exceptionStocks = new List<ModifyExceptionStock>();
            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream, cancellationToken);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    exceptionStocks = _fileService.GetList<ModifyExceptionStock>(worksheet, ref msg);
                }
            }

            _logger.LogInformation($"nextPrices: {JsonConvert.SerializeObject(exceptionStocks)}");

            var paramSync = new DynamicParameters();
            paramSync.Add("@JsonData", JsonConvert.SerializeObject(exceptionStocks), DbType.String, ParameterDirection.Input);
            paramSync.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            paramSync.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_IMP_EXCEPTIONSTOCK", paramSync, _sqlTimeout);

            //0: success, -1: failed
            var result = paramSync.Get<int>("@Result");
            var message = paramSync.Get<string>("@Message");

            return new Response<ModifyExceptionStock>
            {
                Code = (result is (int)ErrorCodeDetail.Success
                    ? (int)ErrorCodeDetail.Success
                    : (int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = message,
                Data = exceptionStocks
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<ModifyExceptionStock>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = !string.IsNullOrEmpty(msg) ? msg : ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }
    public async Task<FileStream> ExportExceptionStockListAsync(ExceptionStockListExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@fromDate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@toDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@langId", model.LangId, DbType.Int32, ParameterDirection.Input);

            var data = await _dapper.SelectAsync<dynamic>(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_EXP_EXCEPTIONSTOCKLIST", param,
                _sqlTimeout);

            var dt = JsonConvert.SerializeObject(data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:ExceptionStock"]}";
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