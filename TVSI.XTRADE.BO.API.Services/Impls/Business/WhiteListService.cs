namespace TVSI.XTRADE.BO.API.Services.Impls.Business
{
    public class WhiteListService : BaseService<WhiteListService>, IWhiteListService
    {
        private readonly IDapperHelper _dapper;
        private readonly string _innoTradeConn;
        private readonly int _sqlTimeout;

        public WhiteListService(ILogger<WhiteListService> logger, IConfiguration config, IDapperHelper dapper)
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

        public async Task<Response<dynamic>?> GetWhiteListAsync(WhiteListRequest model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
                param.Add("@accountNo", model.AccountNo, DbType.String, ParameterDirection.Input);
                param.Add("@agentType", model.AgentType, DbType.Int32, ParameterDirection.Input);
                param.Add("@agentId", model.AgentId, DbType.String, ParameterDirection.Input);
                param.Add("@fromDate", model.FromDate, DbType.String, ParameterDirection.Input);
                param.Add("@toDate", model.ToDate, DbType.String, ParameterDirection.Input);
                param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
                param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

                return new Response<dynamic>
                {
                    Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                    Message = ErrorCodeDetail.Success.ToEnumDescription(),
                    Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPTX_BO_AM_AM_SEL_WhiteList", param,
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

        public async Task<Response<int>> ModifyWhiteListAsync(WhiteListModifyRequest model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
                param.Add("@agentId", model.AgentId, DbType.String, ParameterDirection.Input);
                param.Add("@agentType", model.AgentType, DbType.Int32, ParameterDirection.Input);
                param.Add("@accountNo", model.AccountNo, DbType.String, ParameterDirection.Input);
                param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
                param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
                param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

                await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_AM_AM_INSUPD_WhiteList", param, _sqlTimeout);

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

        public async Task<Response<int>> DeleteWhiteListAsync(WhiteListDelRequest model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
                param.Add("@userId", model.UserId, DbType.String, ParameterDirection.Input);
                param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
                param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

                await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_AM_AM_Del_WhiteList", param, _sqlTimeout);

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
    }
}