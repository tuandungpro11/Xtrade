using Microsoft.AspNetCore.Http;
using TVSI.XTRADE.BO.API.Models.Model.Request.NextPrice;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class NextPriceService : BaseService<NextPriceService>, INextPriceService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly int _sqlTimeout;
    private readonly string _xtradeInnoTradeConn;

    public NextPriceService(ILogger<NextPriceService> logger, IConfiguration config, IDapperHelper dapper,
        IFileService fileService)
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

    public async Task<Response<dynamic>?> GetNextPriceListAsync(NextPriceListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@langId", model.LangId, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_xtradeInnoTradeConn,
                    "SPXT_INNOTRADE_BO_GET_NEXTPRICEDAYLIST", param,
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

    public async Task<Response<int>> CreateNextPriceAsync(NextPriceRequest model, string loginName)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@floorPrice", model.FloorPrice, DbType.Single, ParameterDirection.Input);
            param.Add("@cellingPrice", model.CellingPrice, DbType.Single, ParameterDirection.Input);
            param.Add("@refPrice", model.RefPrice, DbType.Single, ParameterDirection.Input);
            param.Add("@market", model.Market, DbType.String, ParameterDirection.Input);
            param.Add("@modifiedBy", loginName, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_INS_NEXTPRICEDAY", param, _sqlTimeout);

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

    public async Task<Response<int>> UpdateNextPriceAsync(NextPriceRequest model, string loginName)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@floorPrice", model.FloorPrice, DbType.Single, ParameterDirection.Input);
            param.Add("@cellingPrice", model.CellingPrice, DbType.Single, ParameterDirection.Input);
            param.Add("@refPrice", model.RefPrice, DbType.Single, ParameterDirection.Input);
            param.Add("@market", model.Market, DbType.String, ParameterDirection.Input);
            param.Add("@modifiedBy", loginName, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_UPD_NEXTPRICEDAY", param, _sqlTimeout);

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

    public async Task<Response<int>> DeleteNextPriceAsync(string symbol)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", symbol, DbType.String, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_DEL_NEXTPRICEDAY", param, _sqlTimeout);

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

    public async Task<Response<int>> CalculateAgainNextPriceAsync(CalculateNextPriceRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@HOSEPercentage", model.HosePercent, DbType.Decimal, ParameterDirection.Input);
            param.Add("@HNXPercentage", model.HnxPercent, DbType.Decimal, ParameterDirection.Input);
            param.Add("@UPCOMPercentage", model.UpcomPercent, DbType.Decimal, ParameterDirection.Input);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SP_InnoTrade_Calculate_NextDayPriceAll", param,
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

    public async Task<Response<NextPriceRequest>> ImportNextPriceFromFileExcelAsync(IFormFile formFile, CancellationToken cancellationToken, string loginName)
    {
        var msg = string.Empty;
        try
        {
            if (formFile is not { Length: > 0 })
                return new Response<NextPriceRequest>
                {
                    Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                    Message = "File cannot be empty."
                };

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase)
                && !Path.GetExtension(formFile.FileName).Equals(".xls", StringComparison.OrdinalIgnoreCase))
                return new Response<NextPriceRequest>
                {
                    Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                    Message = "Only support file extension .xls and .xlsx."
                };

            var nextPrices = new List<NextPriceRequest?>();
            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream, cancellationToken);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    nextPrices = _fileService.GetList<NextPriceRequest>(worksheet, ref msg);
                }
            }

            _logger.LogInformation($"nextPrices: {JsonConvert.SerializeObject(nextPrices)}");

            var paramSync = new DynamicParameters();
            paramSync.Add("@JsonData", JsonConvert.SerializeObject(nextPrices), DbType.String, ParameterDirection.Input);
            paramSync.Add("@modifiedBy", loginName, DbType.String, ParameterDirection.Input);
            paramSync.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            paramSync.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_xtradeInnoTradeConn, "SPXT_INNOTRADE_BO_IMP_NEXTPRICEDAYLIST", paramSync, _sqlTimeout);

            //0: success, -1: failed
            var result = paramSync.Get<int>("@Result");
            var message = paramSync.Get<string>("@Message");

            return new Response<NextPriceRequest>
            {
                Code = (result is (int)ErrorCodeDetail.Success
                ? (int)ErrorCodeDetail.Success
                : (int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = message,
                Data = nextPrices
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<NextPriceRequest>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = !string.IsNullOrEmpty(msg) ? msg : ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<FileStream> ExportNextPriceListAsync(NextPriceListExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var param = new DynamicParameters();
            param.Add("@symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@langId", model.LangId, DbType.Int32, ParameterDirection.Input);


            var data = await _dapper.SelectAsync<dynamic>(_xtradeInnoTradeConn,
                "SPXT_INNOTRADE_BO_EXP_NEXTPRICEDAYLIST", param,
                _sqlTimeout);

            var dt = JsonConvert.SerializeObject(data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:NextPrice"]}";
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