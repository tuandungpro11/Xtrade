using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.InternalAccount;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class InternalAccountController : BaseController<InternalAccountController>
    {
        private readonly IInternalAccountService _interAccService;

        public InternalAccountController(ILogger<InternalAccountController> logger, IConfiguration config,
            IDetectionService detection, IInternalAccountService interAccService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _interAccService = interAccService;
        }

        /// <summary>
        ///     Lấy danh sách tài khoản chuyển tiền nội bộ
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/InternalAccount/GetInternalAccountList
        ///     {
        ///         "UserId": "Admin",
        ///         "CustomerId": "000515",
        ///         "Status": -2,
        ///         "BeginDate": "",
        ///         "EndDate": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Status:
        ///         -2: Search All
        ///         -1: Chờ Duyệt
        ///         2: Chờ HO xác nhận
        ///         3: CHờ KH xác nhận
        ///         1: KH đã kích hoạt
        ///         0: Ngừng sử dụng  --> kích hoạt lại thì chuyển sang trạng thái -1 để bắt đầu lại quy trình duyệt
        ///         4: Từ chối
        ///         5: KH hủy --> Chuyển từ trạng thái 3 nếu Từ chối
        /// 
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("GetInternalAccountList")]
        public async Task<IActionResult> GetInternalAccountListAsync(InterAccListRequest model)
        {
            var response = await _interAccService.GetInternalAccountListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy thông tin tài khoản chuyển tiền nội bộ
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/InternalAccount/GetInternalAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "InternalAccountNo": "0005161"
        ///     }
        /// </remarks>
        
        [HttpPost("GetInternalAccount")]
        public async Task<IActionResult> GetInternalAccountDetailAsync(InterAccDelRequest model)
        {
            var response = await _interAccService.GetInternalAccountDetailAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Thêm thông tin tài khoản chuyển tiền nội bộ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/InternalAccount/CreateInternalAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "InternalAccountNo": "",
        ///         "NewInternalAccountNo": "0005166",
        ///         "InternalCustomerId": "000516",
        ///         "InternalCustomerName": "Ms Nguyễn Thị Hưng",
        ///         "InternalCustomerNo": "044C000516",
        ///         "InternalIdentityCard": "010067671",
        ///         "InternalAddress": "Tây Hồ",
        ///         "InternalStatus": -1,
        ///         "InternalScanURL": "",
        ///         "Remark": "",
        ///         "Reason": "create new info",
        ///         "Date": "20220622",
        ///         "UserId": "hungnd"
        ///     }
        /// 
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("CreateInternalAccount")]
        public async Task<IActionResult> CreateInternalAccountAsync(InterAccRequest model)
        {
            var response = await _interAccService.ModifyInternalAccountAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Cập nhật thông tin tài khoản chuyển tiền nội bộ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/InternalAccount/UpdateInternalAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "InternalAccountNo": "0005166",
        ///         "NewInternalAccountNo": "0005161",
        ///         "InternalCustomerId": "000516",
        ///         "InternalCustomerName": "Ms Nguyễn Thị Hưng",
        ///         "InternalCustomerNo": "",
        ///         "InternalIdentityCard": "",
        ///         "InternalAddress": "",
        ///         "InternalStatus": -1,
        ///         "InternalScanURL": "",
        ///         "Remark": "",
        ///         "Reason": "",
        ///         "Date": "20220623",
        ///         "UserId": "cuongnv3"
        ///     }
        /// 
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("UpdateInternalAccount")]
        public async Task<IActionResult> UpdateInternalAccountAsync(InterAccRequest model)
        {
            var response = await _interAccService.ModifyInternalAccountAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Phê duyệt thông tin tài khoản chuyển tiền nội bộ
        /// </summary>
        /// 
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/InternalAccount/ChangeStatusInternalAccount
        ///     {
        ///         "CustomerId": "000515",
        ///         "InternalAccountNo": "0005161",
        ///         "InternalStatus" : 3,
        ///         "Reason" : "",
        ///         "UpdatedBy" : "cuongnv3"
        ///     }
        /// </remarks>
        
        [HttpPost("ChangeStatusInternalAccount")]
        public async Task<IActionResult> ChangeStatusInternalAccountAsync(InterAccStatusRequest model)
        {
            var response = await _interAccService.ChangeStatusInternalAccountAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy danh sách tài khoản chuyển tiền nội bộ
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/InternalAccount/ExportInternalAccountList
        ///     {
        ///         "UserId": "Admin",
        ///         "CustomerId": "000515",
        ///         "Status": -2,
        ///         "BeginDate": "",
        ///         "EndDate": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Status:
        ///         -2: Search All
        ///         -1: Chờ Duyệt
        ///         2: Chờ HO xác nhận
        ///         3: CHờ KH xác nhận
        ///         1: KH đã kích hoạt
        ///         0: Ngừng sử dụng  --> kích hoạt lại thì chuyển sang trạng thái -1 để bắt đầu lại quy trình duyệt
        ///         4: Từ chối
        ///         5: KH hủy --> Chuyển từ trạng thái 3 nếu Từ chối
        /// 
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("ExportInternalAccountList")]
        public async Task<IActionResult> ExportInternalAccountListAsync(InterAccListExportRequest model)
        {
            var rootPath = _hostEnv.ContentRootPath;
            var folderExportPath = Path.Combine(rootPath, _config["File:ExportPath"]);
            if (!Directory.Exists(folderExportPath))
            {
                Directory.CreateDirectory(folderExportPath);
            }
            var fileName = $"DS_TAI_KHOAN_CHUYEN_TIEN_NB_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _interAccService.ExportInternalAccountListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }
    }
}
