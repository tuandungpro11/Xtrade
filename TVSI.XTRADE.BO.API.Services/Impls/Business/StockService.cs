using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSI.XTRADE.BO.API.Models.Model.Request.Stock;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business
{
    public class StockService : BaseService<StockService>, IStockService
    {
        private readonly IDapperHelper _dapper;
        private readonly string _innoStockConn;
        private readonly int _sqlTimeout;

        public StockService(ILogger<StockService> logger, IConfiguration config, IDapperHelper dapper)
            : base(logger, config)
        {
            _dapper = dapper;

            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var connStr = _config.GetConnectionString("InnoTrade");
            _innoStockConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;


            _sqlTimeout = _config["Timeout:Database"] == null
                ? CommonConstants.SqlServerTimeout
                : int.Parse(_config["Timeout:Database"]);
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
                    Data = await _dapper.SelectAsync<dynamic>(_innoStockConn, "SPXT_BO_AD_SC_GETSTOCKINFO_BYID", param,
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
    }
}