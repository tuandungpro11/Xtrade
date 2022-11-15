using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSI.XTRADE.BO.API.Models.Model.Request.FileAttach;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business
{
    public class FileAttachService : BaseService<FileAttachService>, IFileAttachService
    {
        private readonly IDapperHelper _dapper;
        private readonly IFileService _fileService;
        private readonly string _innoTradeConn;
        private readonly int _sqlTimeout;

        public FileAttachService(ILogger<FileAttachService> logger, IConfiguration config, IDapperHelper dapper,
            IFileService fileService)
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

        public async Task<Response<dynamic>?> GetFileAttachListAsync(FileAttachListRequest model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
                param.Add("@businessType", model.BusinessType, DbType.String, ParameterDirection.Input);
                param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
                param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

                return new Response<dynamic>
                {
                    Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                    Message = ErrorCodeDetail.Success.ToEnumDescription(),
                    Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPTX_BO_SEL_FILEATTACHLIST", param,
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

        public async Task<Response<long>> DeleteFileAttachAsync(long fileId, string loginName)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@fileId", fileId, DbType.Int64, ParameterDirection.Input);
                param.Add("@modifyBy", loginName, DbType.String, ParameterDirection.Input);
                param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
                param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

                var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPTX_BO_DEL_FILEATTACH", param,
                    _sqlTimeout);

                //0: success, 1: failed
                var result = param.Get<int>("@result");
                var message = param.Get<string>("@message");
                return new Response<long>
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
                return new Response<long>
                {
                    Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                    Message = ErrorCodeDetail.Exception.ToEnumDescription()
                };
            }
        }

        public async Task<Response<long>> UploadFileAttachAsync(string customerId,string businessType, string files, string loginName)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@customerId", customerId, DbType.String, ParameterDirection.Input);
                param.Add("@businessType", businessType, DbType.String, ParameterDirection.Input);
                param.Add("@files", files, DbType.String, ParameterDirection.Input);
                param.Add("@modifyBy", loginName, DbType.String, ParameterDirection.Input);
                param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
                param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

                var rowCount = await _dapper.ExecuteAsync(_innoTradeConn, "SPTX_BO_UPL_FILEATTACH", param,
                    _sqlTimeout);

                //0: success, 1: failed
                var result = param.Get<int>("@result");
                var message = param.Get<string>("@message");
                return new Response<long>
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
                return new Response<long>
                {
                    Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                    Message = ErrorCodeDetail.Exception.ToEnumDescription()
                };
            }
        }
    }
}