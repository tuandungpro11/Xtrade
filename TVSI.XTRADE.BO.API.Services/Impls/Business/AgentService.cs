using TVSI.XTRADE.BO.API.Models.Model.Request.Agent;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class AgentService : BaseService<AgentService>, IAgentService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public AgentService(ILogger<AgentService> logger, IConfiguration config, IDapperHelper dapper, IFileService fileService)
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

    public async Task<Response<dynamic>?> GetAgentListAsync(AgentListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@AgentId", model.AgentId, DbType.String, ParameterDirection.Input);
            param.Add("@AgentType", model.AgentType, DbType.String, ParameterDirection.Input);
            param.Add("@Islike", model.IsLike, DbType.Byte, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_AGENT", param, _sqlTimeout)
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


    public async Task<Response<int>> ModifyAgentAsync(AgentRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@AgentId", model.AgentId, DbType.String, ParameterDirection.Input);
            param.Add("@AgentType", model.AgentType, DbType.String, ParameterDirection.Input);
            param.Add("@BonusReserve", model.BonusReserve, DbType.Decimal, ParameterDirection.Input);
            param.Add("@Commission", model.Commission, DbType.Int32, ParameterDirection.Input);
            param.Add("@TraderId", model.TraderId, DbType.String, ParameterDirection.Input);
            param.Add("@Supervisorid", model.SupervisorId, DbType.Int32, ParameterDirection.Input);
            param.Add("@AgentGroupId", model.AgentGroupId, DbType.String, ParameterDirection.Input);
            param.Add("@KeyOrdZone", model.KeyOrdZone, DbType.String, ParameterDirection.Input);
            param.Add("@Description", model.Description, DbType.String, ParameterDirection.Input);
            param.Add("@ModifiedBy", model.ModifiedBy, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_INS_UDP_AGENT", param, _sqlTimeout);

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

    public async Task<Response<int>> DeleteAgentAsync(string agentId)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@AgentId", agentId, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_DEL_AGENT", param, _sqlTimeout);

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