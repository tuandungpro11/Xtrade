using TVSI.XTRADE.BO.API.Models.Model.Request.AccountManage;
using TVSI.XTRADE.BO.API.Models.Model.Response.AccountManage;
using static TVSI.XTRADE.BO.API.Models.Enums.ErrorCodeDetail;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class AccountManageService : BaseService<AccountManageService>, IAccountManageService
{
    private readonly IDapperHelper _dapper;
    private readonly string _innoTradeConn;
    private readonly int _sqlTimeout;
    private readonly string _systemNotiConn;
    private readonly string _websiteConn;

    public AccountManageService(ILogger<AccountManageService> logger, IConfiguration config, IDapperHelper dapper)
        : base(logger, config)
    {
        _dapper = dapper;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        var connStr = _config.GetConnectionString("InnoTrade");
        _innoTradeConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;

        var connWebsiteStr = _config.GetConnectionString("WebsiteDB");
        _websiteConn = env != "Development"
            ? connWebsiteStr.GetConnectString(CommonConstants.EncryptionKeys)
            : connWebsiteStr;

        var systemNotiStr = _config.GetConnectionString("SystemNotiDB");
        _systemNotiConn = env != "Development"
            ? systemNotiStr.GetConnectString(CommonConstants.EncryptionKeys)
            : systemNotiStr;

        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);
    }

    public async Task<Response<T>> GetCustomerAccountListAsync<T>(CustomerAccountListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@BranchId", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerType", model.CustomerType, DbType.Int32, ParameterDirection.Input);
            param.Add("@CustomerGroupId", model.CustomerGroupId, DbType.Int32, ParameterDirection.Input);
            param.Add("@IsLike", model.IsLike, DbType.Byte, ParameterDirection.Input);
            param.Add("@Begindate", model.BeginDate, DbType.String, ParameterDirection.Input);
            param.Add("@Enddate", model.EndDate, DbType.String, ParameterDirection.Input);
            param.Add("@ByUser", model.ByUser, DbType.String, ParameterDirection.Input);
            param.Add("@Identitycard", model.IdentityCard, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerName", model.CustomerName, DbType.String, ParameterDirection.Input);
            param.Add("@Phone", model.Phone, DbType.String, ParameterDirection.Input);
            param.Add("@Email", model.Email, DbType.String, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<T>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<T>(_innoTradeConn, "SPXT_SEL_CustomerBO", param, _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<T>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<ResponseSingle<T>> GetCustomerInfoByIdAsync<T>(string customerId)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustomerID", customerId, DbType.String, ParameterDirection.Input);

            return new ResponseSingle<T>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = await _dapper.GetAsync<T>(_innoTradeConn, "SPXT_SEL_CUSTOMER_BO_BYID", param,
                    _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new ResponseSingle<T>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<ResponseSingle<T>> GetCustomerInfoByAccountNoAsync<T>(string accountNo)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@AccountNo", accountNo, DbType.String, ParameterDirection.Input);

            return new ResponseSingle<T>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = await _dapper.GetAsync<T>(_innoTradeConn, "SPXT_SEL_CUSTOMER_BO_BY_ACCOUNTNO", param,
                    _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new ResponseSingle<T>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<T>> GetAccountListAsync<T>(AccountListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CUSTOMERID", model.CustomerId, DbType.String, ParameterDirection.Input);

            return new Response<T>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<T>(_innoTradeConn, "SPXT_SEL_BO_GET_ALLACCOUNTS", param,
                    _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<T>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<T>> GetTvsiBranchListAsync<T>(BranchListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@BRANCHID", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@Active", model.Active, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<T>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<T>(_innoTradeConn, "SPXT_SEL_BRANCH", param, _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<T>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<int>> UpdateCustomerAccountAsync(CustomerAccountRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerNo", model.CustomerNo, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerName", model.CustomerName, DbType.String, ParameterDirection.Input);
            param.Add("@AuthType", model.AuthType, DbType.Int32, ParameterDirection.Input);
            param.Add("@IdentityCard", model.IdentityCard, DbType.String, ParameterDirection.Input);
            param.Add("@Address", model.Address, DbType.String, ParameterDirection.Input);
            param.Add("@Email", model.Email, DbType.String, ParameterDirection.Input);
            param.Add("@Phone", model.Phone, DbType.String, ParameterDirection.Input);
            param.Add("@CellPhone", model.CellPhone, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@AgentType", model.CustomerType, DbType.Int32, ParameterDirection.Input);
            param.Add("@CustomerType", model.CustomerType, DbType.Int32, ParameterDirection.Input);
            param.Add("@CustomerGroupID", model.CustomerGroupId, DbType.Int32, ParameterDirection.Input);
            param.Add("@TotalPoint", model.TotalPoint, DbType.Decimal, ParameterDirection.Input);
            param.Add("@UserID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@BranchID", model.BranchId, DbType.String, ParameterDirection.Input);
            param.Add("@ContactEmail", model.ContactEmail, DbType.String, ParameterDirection.Input);
            param.Add("@ContactPhone", model.ContactPhone, DbType.Int32, ParameterDirection.Input);
            param.Add("@IsDefault", model.IsDefault, DbType.Byte, ParameterDirection.Input);
            param.Add("@DefaultAccount", model.DefaultAccount, DbType.String, ParameterDirection.Input);
            param.Add("@PickAccount", model.PickAccount, DbType.String, ParameterDirection.Input);
            param.Add("@Custodian", model.Custodian, DbType.String, ParameterDirection.Input);
            param.Add("@MktId", model.MktId, DbType.String, ParameterDirection.Input);
            param.Add("@PcFlag", model.PcFlag, DbType.String, ParameterDirection.Input);
            param.Add("@Creditype", model.CreditType, DbType.String, ParameterDirection.Input);
            param.Add("@BirthDay", model.BirthDay, DbType.DateTime, ParameterDirection.Input);
            param.Add("@Sex", model.Sex, DbType.String, ParameterDirection.Input);
            param.Add("@CardIssue", model.CardIssue, DbType.DateTime, ParameterDirection.Input);
            param.Add("@PlaceIssue", model.PlaceIssue, DbType.String, ParameterDirection.Input);
            param.Add("@Occupation", model.Occupation, DbType.String, ParameterDirection.Input);
            param.Add("@Nationality", model.Nationality, DbType.String, ParameterDirection.Input);
            param.Add("@Remark", model.Remark, DbType.String, ParameterDirection.Input);
            param.Add("@TaxCode", model.TaxCode, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UDP_Customer", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int?>("@Result");
            var message = param.Get<string>("@Message");
            return new Response<int>
            {
                Code = (result is (int)Success
                    ? (int)Success
                    : (int)Failed).ErrorCodeFormat(),
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

    public async Task<Response<int>> ChangeActiveCustomerAccountAsync(AccountChangeActiveRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserId", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UDP_CustomerActiveInActive", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int?>("@Result");
            var message = param.Get<string>("@Message");
            return new Response<int>
            {
                Code = (result is (int)Success
                    ? (int)Success
                    : (int)Failed).ErrorCodeFormat(),
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

    public async Task<Response<T>> GetCustomerEmailListAsync<T>(CustomerEmailListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@IsActive", model.IsActive, DbType.Int32, ParameterDirection.Input);
            param.Add("@email", model.Email, DbType.String, ParameterDirection.Input);
            param.Add("@fromdate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@todate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@pageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<T>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<T>(_innoTradeConn, "SPXT_SEL_BO_AM_AI_CUSTOMEREMAIL", param,
                    _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<T>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<int>> RegisterEmailServiceAsync(RegisterEmailServiceRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@email", model.Email, DbType.String, ParameterDirection.Input);
            param.Add("@isSMS", model.IsKQGD, DbType.Byte, ParameterDirection.Input);
            param.Add("@isCC", model.IsQC, DbType.Byte, ParameterDirection.Input);
            param.Add("@isActive", model.IsActive, DbType.Byte, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_AM_AI_UPD_CUSTOMEREMAIL", param, _sqlTimeout);

            var result = param.Get<int>("@result");
            var message = param.Get<string>("@message");
            return new Response<int>
            {
                Code = (result is (int)Success
                    ? (int)Success
                    : (int)Failed).ErrorCodeFormat(),
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

    public async Task<Response<int>> DeleteCustomerEmailAsync(int id)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@id", id, DbType.Int32, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount =
                await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_AM_AI_DEL_CUSTOMEREMAIL", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@result");
            var message = param.Get<string>("@message");
            return new Response<int>
            {
                Code = (result is (int)Success
                    ? (int)Success
                    : (int)Failed).ErrorCodeFormat(),
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

    public async Task<Response<T>> GetCustomerPhoneListAsync<T>(CustomerPhoneListRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@IsActive", model.IsActive, DbType.Int32, ParameterDirection.Input);
            param.Add("@phone", model.Phone, DbType.String, ParameterDirection.Input);
            param.Add("@fromdate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@todate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@pageIndex", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@pageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<T>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<T>(_innoTradeConn, "SPXT_BO_AM_AI_SEL_CUSTOMERPHONE", param,
                    _sqlTimeout)
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return new Response<T>
            {
                Code = ((int)ErrorCodeDetail.Exception).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Exception.ToEnumDescription()
            };
        }
    }

    public async Task<Response<int>> RegisterPhoneServiceAsync(RegisterPhoneServiceRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@customerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@phone", model.Phone, DbType.String, ParameterDirection.Input);
            param.Add("@isSMS", model.IsSMS, DbType.Byte, ParameterDirection.Input);
            param.Add("@isCC", model.IsCC, DbType.Byte, ParameterDirection.Input);
            param.Add("@isActive", model.IsActive, DbType.Byte, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_AM_AI_UPD_CUSTOMERPHONE", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@result");
            var message = param.Get<string>("@message");
            return new Response<int>
            {
                Code = (result is (int)Success
                    ? (int)Success
                    : (int)Failed).ErrorCodeFormat(),
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

    public async Task<Response<int>> DeleteCustomerPhoneAsync(int id)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@id", id, DbType.Int32, ParameterDirection.Input);
            param.Add("@result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount =
                await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_BO_AM_AI_DEL_CUSTOMERPHONE", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@result");
            var message = param.Get<string>("@message");
            return new Response<int>
            {
                Code = (result is (int)Success
                    ? (int)Success
                    : (int)Failed).ErrorCodeFormat(),
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
                Message = ErrorCodeDetail.Exception.ToEnumDescription(),
                Data = null
            };
        }
    }

    public async Task<ResponseSingle<dynamic>> ResetPinPasswordAsync(ResetPinPasswordRequest model)
    {
        try
        {
            //Check thông tin Khách hàng 
            var cust = await GetCustomerInfoByIdAsync<CustomerResponse>(model.CustomerId);
            if (cust.Code != ((int)Success).ToString())
                return new ResponseSingle<dynamic>
                {
                    Code = cust.Code,
                    Message = cust.Message
                };

            if (cust.Data == null)
                return new ResponseSingle<dynamic>
                {
                    Code = ((int)CustomerNoDataFound).ErrorCodeFormat(),
                    Message = CustomerNoDataFound.ToEnumDescription()
                };

            //Cần mã hóa theo mã hóa của Inno
            var rnd = new Random();
            var newPassWord = rnd.Next(10000000, 99999999).ToString(); // creates a 8 digit random no.
            var newPin = rnd.Next(10000000, 99999999).ToString(); // creates a 8 digit random no.
            var newPassWordEncode = newPassWord.Md5EncodePassword();
            var newPinEncode = newPin.Md5EncodePassword();

            var param = new DynamicParameters();
            param.Add("@CustomerId", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@Password", newPassWordEncode, DbType.String, ParameterDirection.Input);
            param.Add("@Pin", newPinEncode, DbType.String, ParameterDirection.Input);
            param.Add("@IsValidate", 1, DbType.String, ParameterDirection.Input);
            param.Add("@ChangeType", model.ChangeType, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            var rowCount =
                await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UDP_CUSTOMER_PWD_PIN_BO", param, _sqlTimeout);

            //0: success, 1: failed
            var result = param.Get<int>("@Result");
            var message = param.Get<string>("@Message");
            if (result is not (int)Success)
                return new ResponseSingle<dynamic>
                {
                    Code = ((int)Failed).ErrorCodeFormat(),
                    Message = message
                };

            var isShow = false;
            switch (model.SendSMS)
            {
                case 1 when !string.IsNullOrEmpty(cust.Data.CONTACTPHONE):
                {
                    //send SMS
                    var sContent = model.ChangeType switch
                    {
                        0 => $"TVSI kinh gui Quy khach mat khau Itrade-Home. TK: {model.CustomerId} Pass: {newPassWord} Chi tiet lien he 19001885",
                        1 => $"TVSI kinh gui Quy khach mat khau Itrade-Home. TK: {model.CustomerId} Pin: {newPin} Chi tiet lien he 19001885",
                        2 => $"TVSI kinh gui Quy khach mat khau Itrade-Home. TK: {model.CustomerId} Pass: {newPassWord} Pin: {newPin} Chi tiet lien he 19001885",
                        _ => @""
                    };

                        await PushSmsToQueue(cust.Data.CONTACTPHONE, sContent);
                    break;
                }
                case 0 when !string.IsNullOrEmpty(cust.Data.CONTACTEMAIL):
                {
                        //Send mail
                        var eContent = model.ChangeType switch
                        {
                            0 => new
                            {
                                Subject= "Thông báo Cấp lại mật khẩu đăng nhập", 
                                TempPath = $"{_config["Template:Email:ResetPwd"]}",
                                Password = newPassWord,
                                Pin = string.Empty
                            },
                            1 => new {
                                Subject = "Thông báo Cấp lại mã Pin giao dịch",
                                TempPath = $"{_config["Template:Email:ResetPin"]}",
                                Password = string.Empty,
                                Pin = newPin
                            },
                            2 => new {
                                Subject = "Thông báo Cấp lại mật khẩu đăng nhập và mã Pin giao dịch",
                                TempPath = $"{_config["Template:Email:ResetPinPwd"]}",
                                Password = newPassWord,
                                Pin = newPin
                            },
                            _ => new {
                                Subject = string.Empty,
                                TempPath = string.Empty,
                                Password = string.Empty,
                                Pin = string.Empty
                            }
                        };

                    await PushEmailToQueue(model.CustomerId, cust.Data.CUSTOMERNAME, cust.Data.CONTACTEMAIL,
                        eContent.Password, eContent.Pin, eContent.Subject, eContent.TempPath);
                    break;
                }
                default:
                    isShow = true;
                    break;
            }

            var mesgShow = "Đã gửi";

            var data = model.ChangeType switch
            {
                0 => new { model.CustomerId, Password = isShow ? newPassWord : mesgShow, Pin = string.Empty },
                1 => new { model.CustomerId, Password = string.Empty, Pin = isShow ? newPin : mesgShow },
                2 => new { model.CustomerId, Password = isShow ? newPassWord : mesgShow, Pin = isShow ? newPin : mesgShow },
                _ => new { model.CustomerId, Password = string.Empty, Pin = string.Empty }
            };

            return new ResponseSingle<dynamic>
            {
                Code = ((int)Success).ErrorCodeFormat(),
                Message = Success.ToEnumDescription(),
                Data = data 
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

    [Obsolete("Obsolete")]
    public async Task<Response<int>> ReactiveCustomerAsync(ReactiveCustomerRequest model)
    {
        try
        {
            if (string.IsNullOrEmpty(model.Email))
                return new Response<int>
                {
                    Code = ((int)Failed).ErrorCodeFormat(),
                    Message = $"Thông tin Email của tài khoản {model.CustomerId} không có.",
                    Data = null
                };

            //var newPassWord = 8.RandomNumber();
            //var newPin = 8.RandomNumber(); // creates a 8 digit random no.

            var rnd = new Random();
            var newPassWord = rnd.Next(10000000, 99999999).ToString(); // creates a 8 digit random no.
            var newPin = rnd.Next(10000000, 99999999).ToString(); // creates a 8 digit random no.
            var newPassWordEncode = newPassWord.Md5EncodePassword();
            var newPinEncode = newPin.Md5EncodePassword();

            _logger.LogInformation($"{JsonConvert.SerializeObject(model)} - {newPin} - {newPassWord}");

            var param = new DynamicParameters();
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@Password", newPassWordEncode, DbType.String, ParameterDirection.Input);
            param.Add("@Pin", newPinEncode, DbType.String, ParameterDirection.Input);
            param.Add("@Result", null, DbType.Int32, ParameterDirection.Output);
            param.Add("@Message", null, DbType.String, ParameterDirection.Output, 250);

            await _dapper.ExecuteAsync(_innoTradeConn, "SPXT_UDP_ReActiveCustomer_V2", param, _sqlTimeout);

            var result = param.Get<int?>("@Result");
            var message = param.Get<string>("@Message");

            if (result is not (int)Success)
                return new Response<int>
                {
                    Code = (result is (int)Success or null
                        ? (int)Success
                        : (int)Failed).ErrorCodeFormat(),
                    Message = message,
                    Data = null
                };

            //Send mail
            const string subject = "Thông báo kích hoạt lại tài khoản";
            var templateMailFile = $"{_config["Template:Email:ResetPinPwd"]}";
            await PushEmailToQueue(model.CustomerId, model.FullName, model.Email, newPassWord, newPin, subject,
                templateMailFile);

            //0: success, 1: failed
            return new Response<int>
            {
                Code = (result is (int)Success or null
                    ? (int)Success
                    : (int)Failed).ErrorCodeFormat(),
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
                Message = ErrorCodeDetail.Exception.ToEnumDescription(),
                Data = null
            };
        }
    }

    #region Helper method

    private async Task<int> PushEmailToQueue(string customerId, string fullname, string email, string newPassWord,
        string newPin, string subject, string templateMailFile)
    {
        try
        {
            string content;
            using (var readFile =
                   new FileStream(templateMailFile, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (var readFileStr = new StreamReader(readFile))
                {
                    content = await readFileStr.ReadToEndAsync();
                }
            }

            content = ReplaceEmailContent(content, customerId, newPassWord, newPin, fullname);

            var paramSendMail = new DynamicParameters();
            paramSendMail.Add("@tieu_de", subject, DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@noi_dung", content, DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@danh_muc_dich_vu", 14, DbType.Int32, ParameterDirection.Input);
            paramSendMail.Add("@trang_thai", 1, DbType.Int32, ParameterDirection.Input);
            paramSendMail.Add("@nguoi_tao", "XtradeBoApi", DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@ngay_tao", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            paramSendMail.Add("@nguoi_cap_nhat", "XtradeBoApi", DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@ngay_cap_nhat", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            paramSendMail.Add("@thoi_gian_nhan", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            paramSendMail.Add("@thoi_gian_gui", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            paramSendMail.Add("@nhom_email", 0, DbType.Int32, ParameterDirection.Input);
            paramSendMail.Add("@dia_chi_email", email, DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@trang_thai1", 0, DbType.Int32, ParameterDirection.Input);
            paramSendMail.Add("@thoi_gian_gui1", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            paramSendMail.Add("@thoi_gian_nhan1", DateTime.Now, DbType.DateTime, ParameterDirection.Input);
            paramSendMail.Add("@code", "", DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@so_tai_khoan", customerId, DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@ma_danh_muc", 14, DbType.Int32, ParameterDirection.Input);
            paramSendMail.Add("@sequence_id", 99, DbType.Int32, ParameterDirection.Input);

            return await _dapper.ExecuteAsync(_websiteConn, "TVSI_sQEM_NOI_DUNG_EMAIL_AND_LOG_EMAIL_INSERT",
                paramSendMail, _sqlTimeout);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return -1;
        }
    }

    private async Task<int> PushSmsToQueue(string mobile, string content, int status = 0)
    {
        try
        {
            var paramSendMail = new DynamicParameters();
            paramSendMail.Add("@noi_dung", content, DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@so_dien_thoai", mobile, DbType.String, ParameterDirection.Input);
            paramSendMail.Add("@trang_thai", status, DbType.Int32, ParameterDirection.Input);

            return await _dapper.ExecuteAsync(_systemNotiConn, "TVSI_sHANG_DOI_SMS_INSERT",
                paramSendMail, _sqlTimeout);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return -1;
        }
    }

    private static string ReplaceEmailContent(string content, string custId, string newPass, string newPin,
        string custName)
    {
        content = content.Replace("{CustId}", custId);
        content = content.Replace("{NewPass}", newPass);
        content = content.Replace("{NewPin}", newPin);
        content = content.Replace("{EffDate}", DateTime.Now.ToString("dd/MM/yyyy"));
        content = content.Replace("{CustName}", custName);
        return content;
    }

    #endregion Helper method
}