using TVSI.XTRADE.BO.API.Models.Model.Request.ManageOrder;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class ManageOrderController : BaseController<ManageOrderController>
    {
        private readonly IManageOrderService _manageOrderService;

        public ManageOrderController(ILogger<ManageOrderController> logger, IConfiguration config,
            IDetectionService detection, IManageOrderService manageOrderService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _manageOrderService = manageOrderService;
        }

        /// <summary>
        ///     Lấy danh sách lệnh trong ngày từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetInsideOrderList
        ///     {
        ///         "UserId": "000131",
        ///         "Accounts": "0611751",
        ///         "Channel": "",
        ///         "Status": "",
        ///         "SecSymbols": "",
        ///         "FisOrderIds": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        ///
        ///     Status:
        ///         1: 
        ///         2: 
        ///         3: 
        ///         4: Lệnh đang chờ tại TVSI
        ///         5: Lệnh đang chờ khớp tại sàn
        ///         6: 
        ///         7: 
        ///         8: Lệnh đã được hủy (hủy toàn bộ)
        ///         9: Lệnh bị từ chối tại TVSI
        /// </remarks>
        [HttpPost("GetInsideOrderList")]
        public async Task<IActionResult> GetInsideOrderListAsync(OrderListRequest model)
        {
            var response = await _manageOrderService.GetInsideOrderListAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }


        /// <summary>
        ///     Lấy danh sách lệnh ngoài giờ từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOutsideOrderList
        ///     {
        ///         "UserId": "000131",
        ///         "Accounts": "0611751",
        ///         "Channel": "",
        ///         "Status": "",
        ///         "SecSymbols": "",
        ///         "FisOrderIds": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        ///
        ///     Status:
        ///         1: 
        ///         2: 
        ///         3: 
        ///         4: Lệnh đang chờ tại TVSI
        ///         5: Lệnh đang chờ khớp tại sàn
        ///         6: 
        ///         7: 
        ///         8: Lệnh đã được hủy (hủy toàn bộ)
        ///         9: Lệnh bị từ chối tại TVSI
        /// </remarks>
        [HttpPost("GetOutsideOrderList")]
        public async Task<IActionResult> GetOutsideOrderListAsync(OrderListRequest model)
        {
            var response = await _manageOrderService.GetOutsideOrderListAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Đẩy lại lệnh ngoài giờ và trong giờ Pasiot Api
        /// </summary>
        /// <param name="ids"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     Đẩy các lệnh được chọn
        ///     POST /api/ManageOrder/RePushOutsideOrder
        ///     [
        ///         "1","3","4","6","8"
        ///     ]
        /// 
        ///     Đẩy tất cả các lệnh được phép repush
        ///     POST /api/ManageOrder/RePushOutsideOrder
        ///     [
        ///         "all"
        ///     ]
        ///
        /// </remarks>
        [HttpPost("RePushOutsideOrder")]
        public async Task<IActionResult> RePushOutsideOrderAsync(string[] ids)
        {
            var response = await _manageOrderService.RePushOutsideOrderAsync(ids);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy chi tiết lệnh từ Pasiot Api
        /// </summary>
        /// <param name="id"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetDetailOrder/62b94a3b775f897373f0941c
        /// </remarks>
        [HttpPost("GetDetailOrder/{id}")]
        public async Task<IActionResult> GetOrderDetailAsync(string id)
        {
            var response = await _manageOrderService.GetOrderDetailAsync(id);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy lịch sử đặt lệnh từ ngày - đến ngày từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderHist
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "",
        ///         "customerID": "",
        ///         "Symbol": "",
        ///         "OrderStatus": -1,
        ///         "OrderChannel": "",
        ///         "BeginDate": "16/03/2000",
        ///         "EndDate": "07/01/2022",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        ///
        ///     Status:
        ///         1: 
        ///         2: 
        ///         3: 
        ///         4: Lệnh đang chờ tại TVSI
        ///         5: Lệnh đang chờ khớp tại sàn
        ///         6: 
        ///         7: 
        ///         8: Lệnh đã được hủy (hủy toàn bộ)
        ///         9: Lệnh bị từ chối tại TVSI
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>
        [HttpPost("GetOrderHist")]
        public async Task<IActionResult> GetOrderHistAsync(OrderHistRequest model)
        {
            var response = await _manageOrderService.GetOrderHistAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy danh sách rổ lệnh từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderBasketList
        ///     {
        ///         "BranchId": "",
        ///         "CustomerID" : "",
        ///         "AccountNo": "1558661",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// </remarks>
        [HttpPost("GetOrderBasketList")]
        public async Task<IActionResult> GetOrderBasketListAsync(OrderBasketRequest model)
        {
            var response = await _manageOrderService.GetOrderBasketListAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy danh sách lệnh trong rổ lệnh từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderBasketInfo
        ///     {
        ///         "BranchId": "",
        ///         "CustomerID" : "",
        ///         "AccountNo": "1558661",
        ///         "BasketID": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// </remarks>
        [HttpPost("GetOrderBasketInfo")]
        public async Task<IActionResult> GetOrderBasketInfoAsync(OrderBasketInfoRequest model)
        {
            var response = await _manageOrderService.GetOrderBasketInfoAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy danh sách lệnh điều kiện - Thời gian (GTD) từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderConditionGTDList
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "7979391",
        ///         "Source" : "",
        ///         "FromDate": "23/01/2000",
        ///         "ToDate":"23/01/2022", 
        ///         "Status": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>
        [HttpPost("GetOrderConditionGTDList")]
        public async Task<IActionResult> GetOrderGTDListAsync(OrderConditionGTDRequest model)
        {
            var response = await _manageOrderService.GetOrderGTDListAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy thông tin chi tiết lệnh điều kiện - Thời gian (GTD) từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderConditionGTDDetail
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "7979391",
        ///         "Id" : 21,
        ///     }
        /// </remarks>
        [HttpPost("GetOrderConditionGTDDetail")]
        public async Task<IActionResult> GetOrderGTDDetailAsync(OrderConditionGTDDetailRequest model)
        {
            var response = await _manageOrderService.GetOrderGTDDetailAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy danh sách lệnh điều kiện - Chốt lời/Cắt lỗ (ST) từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderConditionSTList
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "1558661",
        ///         "Source" : "",
        ///         "FromDate": "12/01/2000",
        ///         "ToDate":"07/01/2022",
        ///         "Status" : -1,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>
        [HttpPost("GetOrderConditionSTList")]
        public async Task<IActionResult> GetOrderSTListAsync(OrderConditionSTRequest model)
        {
            var response = await _manageOrderService.GetOrderSTListAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy thông tin chi tiết lệnh điều kiện - Chốt lời/Cắt lỗ (ST) từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderConditionSTDetail
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "1558661",
        ///         "Id" : "",
        ///     }
        /// </remarks>
        [HttpPost("GetOrderConditionSTDetail")]
        public async Task<IActionResult> GetOrderSTDetailAsync(OrderConditionSTDetailRequest model)
        {
            var response = await _manageOrderService.GetOrderSTDetailAsync(model);
            return Content(JsonConvert.SerializeObject(response), "application/json", Encoding.UTF8);
        }

        /// <summary>
        ///     Lấy danh sách lệnh điều kiện từ iTrade-Home (innoDB)
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/GetOrderConditionList
        ///     {
        ///         "UserId": "hungnd",
        ///         "CooId": -1,
        ///         "CustomerId": "",
        ///         "AccountNo": "",
        ///         "Symbol" : "",
        ///         "CooType": -1,
        ///         "OrderStatus": -1,
        ///         "Side": " ",
        ///         "FromDate": "20000624",
        ///         "ToDate":"20220701",
        ///         "IsExpired": 0,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     CooType:
        ///         -1: Search all
        ///         1: Lệnh bình thường
        ///         2: Lệnh ĐK thời gian
        ///         3: Lệnh tranh mua bán
        ///         4: Lệnh dừng
        ///         5: Lệnh xu hướng
        /// 
        ///     Side:
        ///         " ": Search all
        ///         "B": Mua
        ///         "S": Bán
        /// 
        ///     OrderStatus:
        ///         -1: Search all
        ///         1: Đang chờ thảo ĐK
        ///         2: Chờ gửi lệnh vào sàn
        ///         3: Đã gửi lệnh vào sàn
        ///         4: Khớp 1 phần/Hủy 1 phần
        ///         5: Khớp 1 phần/Chờ khớp đủ
        ///         6: Đã Khớp
        ///         7: Đã Hủy
        ///
        ///     Format Date: yyyyMMdd
        /// </remarks>
        [HttpPost("GetOrderConditionList")]
        public async Task<IActionResult> GetOrderConditionListAsync(OrderConditionRequest model)
        {
            var response = await _manageOrderService.GetOrderConditionListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Export danh sách lệnh trong ngày từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/ExportInsideOrderList
        ///     {
        ///         "UserId": "000131",
        ///         "Accounts": "0611751",
        ///         "Channel": "",
        ///         "Status": "",
        ///         "SecSymbols": "",
        ///         "FisOrderIds": ""
        ///     }
        ///
        ///     Status:
        ///         1: 
        ///         2: 
        ///         3: 
        ///         4: Lệnh đang chờ tại TVSI
        ///         5: Lệnh đang chờ khớp tại sàn
        ///         6: 
        ///         7: 
        ///         8: Lệnh đã được hủy (hủy toàn bộ)
        ///         9: Lệnh bị từ chối tại TVSI
        /// </remarks>
        [HttpPost("ExportInsideOrderList")]
        public async Task<IActionResult> ExportInsideOrderListAsync(OrderListExportRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"DS_LENH_TRONG_NGAY_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _manageOrderService.ExportInsideOrderListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }

        /// <summary>
        ///     Export lịch sử đặt lệnh từ ngày - đến ngày từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/ExportOrderHist
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "",
        ///         "customerID": "",
        ///         "Symbol": "",
        ///         "OrderStatus": -1,
        ///         "OrderChannel": "",
        ///         "BeginDate": "16/03/2000",
        ///         "EndDate": "07/01/2022"
        ///     }
        ///
        ///     Status:
        ///         1: 
        ///         2: 
        ///         3: 
        ///         4: Lệnh đang chờ tại TVSI
        ///         5: Lệnh đang chờ khớp tại sàn
        ///         6: 
        ///         7: 
        ///         8: Lệnh đã được hủy (hủy toàn bộ)
        ///         9: Lệnh bị từ chối tại TVSI
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>
        [HttpPost("ExportOrderHist")]
        public async Task<IActionResult> ExportOrderHistAsync(OrderHistExportRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"LICH_SU_LENH_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _manageOrderService.ExportOrderHistAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }
        
        /// <summary>
        ///     Export danh sách lệnh điều kiện - Thời gian (GTD) từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/ExportOrderConditionGTDList
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "7979391",
        ///         "Source" : "",
        ///         "FromDate": "23/01/2000",
        ///         "ToDate":"23/01/2022", 
        ///         "Status": ""
        ///     }
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>
        [HttpPost("ExportOrderConditionGTDList")]
        public async Task<IActionResult> ExportOrderGTDListAsync(OrderConditionGTDExportRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"LENH_DK_THOI_GIAN_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _manageOrderService.ExportOrderGTDListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }

        /// <summary>
        ///     Export danh sách lệnh điều kiện - Chốt lời/Cắt lỗ (ST) từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/ExportOrderConditionSTList
        ///     {
        ///         "BranchId": "",
        ///         "AccountNo": "1558661",
        ///         "Source" : "",
        ///         "FromDate": "12/01/2000",
        ///         "ToDate":"07/01/2022",
        ///         "Status" : -1,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Format Date: dd/MM/yyyy
        /// </remarks>
        [HttpPost("ExportOrderConditionSTList")]
        public async Task<IActionResult> ExportOrderSTListAsync(OrderConditionSTRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"LENH_DK_VE_GIA_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _manageOrderService.ExportOrderSTListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }

        /// <summary>
        ///     Export danh sách lệnh ngoài giờ từ Pasiot Api
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ManageOrder/ExportOutsideOrderList
        ///     {
        ///         "UserId": "000131",
        ///         "Accounts": "0611751",
        ///         "Channel": "",
        ///         "Status": "",
        ///         "SecSymbols": "",
        ///         "FisOrderIds": ""
        ///     }
        ///
        ///     Status:
        ///         1: 
        ///         2: 
        ///         3: 
        ///         4: Lệnh đang chờ tại TVSI
        ///         5: Lệnh đang chờ khớp tại sàn
        ///         6: 
        ///         7: 
        ///         8: Lệnh đã được hủy (hủy toàn bộ)
        ///         9: Lệnh bị từ chối tại TVSI
        /// </remarks>
        [HttpPost("ExportOutsideOrderList")]
        public async Task<IActionResult> ExportOutsideOrderListAsync(OrderListRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"LENH_TRUOC_NGAY_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _manageOrderService.ExportOutsideOrderListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }
    }
}
