using AutoMapper;
using TVSI.XTRADE.BO.API.Models.Model.Response.APIPasiot.ManageOrder;

namespace TVSI.XTRADE.BO.API.Services.Impls.Business;

public class ManageOrderService : BaseForApiCallerService<ManageOrderService>, IManageOrderService
{
    private readonly IDapperHelper _dapper;
    private readonly IFileService _fileService;

    private readonly string _innoTradeConn;
    public readonly IMapper _mapper;
    private readonly string _pasiotApiTrading;
    private readonly int _sqlTimeout;

    public ManageOrderService(ILogger<ManageOrderService> logger, IConfiguration config, IDapperHelper dapper,
        IApiCallerService apiCaller, IMapper mapper, IFileService fileService)
        : base(logger, config, apiCaller)
    {
        _dapper = dapper;
        _mapper = mapper;
        _fileService = fileService;

        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var connStr = _config.GetConnectionString("InnoTrade");
        _innoTradeConn = env != "Development" ? connStr.GetConnectString(CommonConstants.EncryptionKeys) : connStr;

        _sqlTimeout = _config["Timeout:Database"] == null
            ? CommonConstants.SqlServerTimeout
            : int.Parse(_config["Timeout:Database"]);

        _pasiotApiTrading = _config["PasiotApi:Trading"];
    }

    public async Task<ResponsePartner> GetInsideOrderListAsync(OrderListRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Inside"]}";
        var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);

        var dataConvert =
            (JsonConvert.DeserializeObject<InsideOrdersResponse>(data.Data?.ToString() ?? string.Empty) ?? new InsideOrdersResponse());
        return new ResponsePartner
        {
            Code = data.Code,
            Message = data.Message,
            Data = dataConvert
        };
    }

    public async Task<ResponsePartner> GetOutsideOrderListAsync(OrderListRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Outside"]}";
        var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
        var dataConvert =
            (JsonConvert.DeserializeObject<OutsideOrdersResponse>(data.Data?.ToString() ?? string.Empty)
             ?? new OutsideOrdersResponse());
        return new ResponsePartner
        {
            Code = data.Code,
            Message = data.Message,
            Data = dataConvert
        };
    }

    public async Task<ResponsePartner> RePushOutsideOrderAsync(string[] ids)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:RePushOutside"]}";
        var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(ids), null, ApiMethod.POST);
        return new ResponsePartner
        {
            Code = data.Code,
            Message = data.Message,
            Data = data.Data,
        };
    }

    public async Task<ResponsePartner> GetOrderDetailAsync(string id)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Detail"]}/?id={id}";
        return await PasiotApiCallerHelper(url, null, null, ApiMethod.GET);
    }

    public async Task<ResponsePartner> GetOrderHistAsync(OrderHistRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Hist"]}";
        var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
        var dataConvert =
            (JsonConvert.DeserializeObject<List<OrdersHistResponse>>(data.Data?.ToString() ?? string.Empty)
             ?? new List<OrdersHistResponse>()).OrderByDescending(m => m.effectedDate).ThenByDescending(m => m.orderNo);
        return new ResponsePartner
        {
            Code = data.Code,
            Message = data.Message,
            Data = dataConvert
        };
    }

    public async Task<ResponsePartner> GetOrderBasketListAsync(OrderBasketRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Basket"]}";
        return await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
    }

    public async Task<ResponsePartner> GetOrderBasketInfoAsync(OrderBasketInfoRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:BasketInfo"]}";
        return await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
    }

    public async Task<ResponsePartner> GetOrderGTDListAsync(OrderConditionGTDRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:ConditionGTD"]}";
        var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
        var dataConvert =
            (JsonConvert.DeserializeObject<List<OrderGTDResponse>>(data.Data?.ToString() ?? string.Empty)
             ?? new List<OrderGTDResponse>()).OrderByDescending(m => m.createdDate);
        return new ResponsePartner
        {
            Code = data.Code,
            Message = data.Message,
            Data = dataConvert
        };
    }

    public async Task<ResponsePartner> GetOrderGTDDetailAsync(OrderConditionGTDDetailRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:ConditionGTDDetail"]}";
        return await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
    }

    public async Task<ResponsePartner> GetOrderSTListAsync(OrderConditionSTRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:ConditionST"]}";
        var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
        var dataConvert =
            (JsonConvert.DeserializeObject<List<OrderSTResponse>>(data.Data?.ToString() ?? string.Empty)
             ?? new List<OrderSTResponse>()).OrderByDescending(m => m.createdDate);
        return new ResponsePartner
        {
            Code = data.Code,
            Message = data.Message,
            Data = dataConvert
        };
    }

    public async Task<ResponsePartner> GetOrderSTDetailAsync(OrderConditionSTDetailRequest model)
    {
        var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:ConditionSTDetail"]}";
        return await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(model), null, ApiMethod.GET);
    }

    public async Task<Response<dynamic>> GetOrderConditionListAsync(OrderConditionRequest model)
    {
        try
        {
            var param = new DynamicParameters();
            param.Add("@UserID", model.UserId, DbType.String, ParameterDirection.Input);
            param.Add("@COO_ID", model.CooId, DbType.Int32, ParameterDirection.Input);
            param.Add("@CustomerID", model.CustomerId, DbType.String, ParameterDirection.Input);
            param.Add("@AccountNO", model.AccountNo, DbType.String, ParameterDirection.Input);
            param.Add("@Symbol", model.Symbol, DbType.String, ParameterDirection.Input);
            param.Add("@CooType", model.CooType, DbType.Int32, ParameterDirection.Input);
            param.Add("@OrderStatus", model.OrderStatus, DbType.Int32, ParameterDirection.Input);
            param.Add("@Side", model.Side, DbType.String, ParameterDirection.Input);
            param.Add("@Fromdate", model.FromDate, DbType.String, ParameterDirection.Input);
            param.Add("@ToDate", model.ToDate, DbType.String, ParameterDirection.Input);
            param.Add("@IsExpired", model.IsExpired, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageNumber", model.PageIndex, DbType.Int32, ParameterDirection.Input);
            param.Add("@PageSize", model.PageSize, DbType.Int32, ParameterDirection.Input);

            return new Response<dynamic>
            {
                Code = ((int)ErrorCodeDetail.Success).ErrorCodeFormat(),
                Message = ErrorCodeDetail.Success.ToEnumDescription(),
                Data = await _dapper.SelectAsync<dynamic>(_innoTradeConn, "SPXT_SEL_BO_COOINFO", param, _sqlTimeout)
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

    public async Task<FileStream> ExportInsideOrderListAsync(OrderListExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var postData = _mapper.Map<OrderListRequest>(model);
            var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Inside"]}";
            var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(postData), null, ApiMethod.GET);

            if (data.Code != ((int)ErrorCodeDetail.Success).ErrorCodeFormat())
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, data);
                return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            }

            var dataConvert =
                (JsonConvert.DeserializeObject<InsideOrdersResponse>(data.Data?.ToString() ?? string.Empty) ?? new InsideOrdersResponse());
            var dt = JsonConvert.SerializeObject(dataConvert.items).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:InsideOrder"]}";
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

    public async Task<FileStream> ExportOutsideOrderListAsync(OrderListExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var postData = _mapper.Map<OrderListRequest>(model);
            var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Outside"]}";
            var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(postData), null, ApiMethod.GET);

            if (data.Code != ((int)ErrorCodeDetail.Success).ErrorCodeFormat())
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, data);
                return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            }

            var dataConvert =
                (JsonConvert.DeserializeObject<OutsideOrdersResponse>(data.Data?.ToString() ?? string.Empty)
                 ?? new OutsideOrdersResponse());
            var dt = JsonConvert.SerializeObject(dataConvert.items).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:OutsideOrder"]}";
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

    public async Task<FileStream> ExportOrderHistAsync(OrderHistExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var postData = _mapper.Map<OrderHistRequest>(model);
            var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:Hist"]}";
            var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(postData), null, ApiMethod.GET);

            if (data.Code != ((int)ErrorCodeDetail.Success).ErrorCodeFormat())
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, data);
                return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            }

            var dataConvert =
                (JsonConvert.DeserializeObject<List<OrdersHistResponse>>(data.Data?.ToString() ?? string.Empty)
                 ?? new List<OrdersHistResponse>()).OrderByDescending(m => m.effectedDate)
                .ThenByDescending(m => m.orderNo);
            var dt = JsonConvert.SerializeObject(dataConvert).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:OrderHist"]}";
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

    public async Task<FileStream> ExportOrderGTDListAsync(OrderConditionGTDExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var postData = _mapper.Map<OrderConditionGTDRequest>(model);
            var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:ConditionGTD"]}";
            var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(postData), null, ApiMethod.GET);

            if (data.Code != ((int)ErrorCodeDetail.Success).ErrorCodeFormat())
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, data);
                return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            }

            var dataConvert =
                (JsonConvert.DeserializeObject<List<OrderGTDResponse>>(data.Data?.ToString() ?? string.Empty)
                 ?? new List<OrderGTDResponse>()).OrderByDescending(m => m.createdDate);
            var dt = JsonConvert.SerializeObject(dataConvert).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:OrderGTD"]}";
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

    public async Task<FileStream> ExportOrderSTListAsync(OrderConditionSTExportRequest model, string fileExportPath)
    {
        var ds = new DataSet();
        try
        {
            var postData = _mapper.Map<OrderConditionSTRequest>(model);
            var url = $"{_pasiotApiTrading}{_config["PasiotApi:Trading:ManageOrder:ConditionST"]}";
            var data = await PasiotApiCallerHelper(url, JsonConvert.SerializeObject(postData), null, ApiMethod.GET);

            if (data.Code != ((int)ErrorCodeDetail.Success).ErrorCodeFormat())
            {
                _fileService.ExportErrorMessageToFile(fileExportPath, data);
                return new FileStream(fileExportPath, FileMode.Open, FileAccess.Read);
            }

            var dataConvert =
                (JsonConvert.DeserializeObject<List<OrderSTResponse>>(data.Data?.ToString() ?? string.Empty)
                 ?? new List<OrderSTResponse>()).OrderByDescending(m => m.createdDate);
            var dt = JsonConvert.SerializeObject(dataConvert).ToDataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "DATA";

            var tempFile = $"{_config["Template:Export:OrderST"]}";
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