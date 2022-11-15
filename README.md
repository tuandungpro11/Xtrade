# Helper library

Helper library là thư viện core hỗ trợ:
- Kết nối database sử dụng Dapper
- Redis cache
- Api Caller (hỗ trợ HttpWebRequest và HttlClient)
- Cryto (Mã hóa AES)
- Extensions:
  + CryptoExtensions: Hashing, salting, md5, checkSum
  + ObjectExtensions: Convert data to new Object
  + ...

## Prerequisites
 - [x] .Net 6
 - [x] Dapper >= v2.0.123
 - [x] System.Data.Client >= v4.8.3
 - [x] StackExchange.Redis >= v2.6.48
 - [x] Microsoft.Extensions.Caching.StackExchangeRedis >= v6.0.7
 - [x] Microsoft.Extensions.Log4Net.AspNetCore >= v6.1.0
 - [x] Newtonsoft.Json >= v13.0.1

## Installation
 - Nuget
```bash
dotnet add package Dapper --version 2.0.123
```
 - NET CLI
```bash
Install-Package Dapper -Version 2.0.123
```

## Usage

```csharp
public class SupperAccountService : BaseService<SupperAccountService>, ISupperAccountService
{
    private readonly IDapperHelper _dapper;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;

    public SupperAccountService(ILogger<SupperAccountService> logger, IConfiguration config, IDapperHelper dapper)
        : base(logger, config)
    {
        _dapper = dapper;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var connStr = _config.GetConnectionString("InnoTrade");
        _innoTradeConn = env != "Development" ? Crypto.Decrypt(connStr, CommonConstants.EncryptionKeys) : connStr;

        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);
    }

    public async Task<Response<dynamic>> GetSupperAccountListAsync(SupperAccountListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@BranchId", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_BO_GETSUPPERACCOUNT", param,
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

    public async Task<ResponseSingle<dynamic>> GetSupperAccountDetailAsync(long id)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", id, DbType.Int64, ParameterDirection.Input);

            return new ResponseSingle<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.GetAsync<dynamic>(_innoTradeConn, "SPXT_SEL_BO_SUPPERACCOUNT_BYID", param,
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

    public async Task<Response<int>> ModifySupperAccountAsync(SupperAccountRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@BranchIDList", model.BranchIdList, DbType.String, ParameterDirection.Input);

            await _dapper.ExecuteAsync(_innoTradeConn, "SP_INS_BO_SUPPERACCOUNT", param, _sqlTimeout);
            
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

    public async Task<Response<int>> DeleteSupperAccountAsync(SupperAccountDelRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@BranchId", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);

            await _dapper.ExecuteAsync(_innoTradeConn, "SP_DEL_BO_SUPPERACCOUNT", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int?>("@Result");
            return new Response<int>
            {
                Code = (result is (int)ErrorCodeDetail.Success or null
                    ? (int)ErrorCodeDetail.Success
                    : (int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = result is (int)ErrorCodeDetail.Success or null
                    ? ErrorCodeDetail.Success.ToEnumDescription()
                    : ErrorCodeDetail.Failed.ToEnumDescription(),
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

    public async Task<Response<int>> ChangeActiveSupperAccountAsync(SupperAccountActiveRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@BranchId", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);

            await _dapper.ExecuteAsync(_innoTradeConn, "SP_UDP_BO_ACTIVESUPPERACCOUNT", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int?>("@Result");
            return new Response<int>
            {
                Code = (result is (int)ErrorCodeDetail.Success or null
                    ? (int)ErrorCodeDetail.Success
                    : (int)ErrorCodeDetail.Failed).ErrorCodeFormat(),
                Message = result is (int)ErrorCodeDetail.Success or null
                    ? ErrorCodeDetail.Success.ToEnumDescription()
                    : ErrorCodeDetail.Failed.ToEnumDescription(),
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
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)