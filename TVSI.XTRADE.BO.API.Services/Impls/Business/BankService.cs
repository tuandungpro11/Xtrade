namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class BankService : BaseService<BankService>, IBankService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public BankService(ILogger<BankService> logger, IConfiguration config, IDapperHelper dapper, IFileService fileService)
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

    public async Task<Response<dynamic>?> GetBankListAsync(BankListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@BankNo", model.BankNo, DbType.String, ParameterDirection.Input);
            param.Add("@BankName", model.BankName, DbType.String, ParameterDirection.Input);
            param.Add("@BankName_E", model.BankNameEn, DbType.String, ParameterDirection.Input);
            param.Add("@ShortName", model.ShortName, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@bankcheqcode", model.Bankcheqcode, DbType.String, ParameterDirection.Input);
            param.Add("@SecCode", model.SecCode, DbType.String, ParameterDirection.Input);
            param.Add("@secCodeBranch", model.SecCodeBranch, DbType.String, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPTX_BO_AM_AI_SEL_BANKLIST", param, _sqlTimeout)
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

    public async Task<ResponseSingle<dynamic>?> GetBankDetailAsync(int id)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

            return new ResponseSingle<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.GetAsync<dynamic>(_innoTradeConn, "SPTX_BO_AM_AI_SEL_BANK_DETAIL", param, _sqlTimeout)
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


    public async Task<Response<int>> ModifyBankAsync(BankRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@BankNo", model.BankNo, DbType.String, ParameterDirection.Input);
            param.Add("@BankName", model.BankName, DbType.String, ParameterDirection.Input);
            param.Add("@BankName_E", model.BankNameEn, DbType.String, ParameterDirection.Input);
            param.Add("@ShortName", model.ShortName, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@bankcheqcode", model.Bankcheqcode, DbType.String, ParameterDirection.Input);
            param.Add("@SecCode", model.SecCode, DbType.String, ParameterDirection.Input);
            param.Add("@secCodeBranch", model.SecCodeBranch, DbType.String, ParameterDirection.Input);
            param.Add("@WithdrawAccount", model.WithdrawAccount, DbType.String, ParameterDirection.Input);
            param.Add("@DepositAccount", model.DepositAccount, DbType.String, ParameterDirection.Input);
            param.Add("@min_trading_cash", model.MinTradingCash, DbType.Decimal, ParameterDirection.Input);
            param.Add("@max_trading_cash", model.MaxTradingCash, DbType.Decimal, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@transferFee", model.TransferFee, DbType.Decimal, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPTX_BO_AM_AI_INSUPD_BANKLIST", param, _sqlTimeout);

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

    public async Task<Response<int>> DeleteBankAsync(BankDelRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@BankNo", model.BankNo, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPTX_BO_AM_AI_DEL_BANKLIST", param, _sqlTimeout);

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

    public async Task<FileStream> ExportBankListAsync(BankExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var param = new DynamicParameters();
            param.Add("@BankNo", model.BankNo, DbType.String, ParameterDirection.Input);
            param.Add("@BankName", model.BankName, DbType.String, ParameterDirection.Input);
            param.Add("@BankName_E", model.BankNameEn, DbType.String, ParameterDirection.Input);
            param.Add("@ShortName", model.ShortName, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@bankcheqcode", model.Bankcheqcode, DbType.String, ParameterDirection.Input);
            param.Add("@SecCode", model.SecCode, DbType.String, ParameterDirection.Input);
            param.Add("@secCodeBranch", model.SecCodeBranch, DbType.String, ParameterDirection.Input);

            var data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPTX_BO_AM_AI_EXP_BANKLIST", param,
            _sqlTimeout);
        
            var dt = JsonConvert.SerializeObject(data).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:Bank"]}";
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