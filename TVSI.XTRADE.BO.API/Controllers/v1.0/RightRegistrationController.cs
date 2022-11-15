using TVSI.XTRADE.BO.API.Models.Model.Request.RightRegistration;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class RightRegistrationController : BaseController<RightRegistrationController>
    {
        private readonly IRightRegistrationService _rightRegistrationService;

        public RightRegistrationController(ILogger<RightRegistrationController> logger, IConfiguration config,
            IDetectionService detection, IRightRegistrationService rightRegistrationService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _rightRegistrationService = rightRegistrationService;
        }

        /// <summary>
        ///     Lấy danh sách đăng ký quyền mua
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/RightRegistration/GetRightRegistrationList
        ///     {
        ///         "UserId": "cuongnv3",
        ///         "CustomerId": "",
        ///         "AccountNo": "",
        ///         "ContractNo": "",
        ///         "RightDateFrom": "",
        ///         "RightDateTo": "",
        ///         "Status": -1,
        ///         "Symbol": "",
        ///         "UserIdEdit": "",
        ///         "BranchId": "",
        ///         "CustomerType": -1,
        ///         "PendingStatusId": -1,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Status:
        ///         -1: Search All
        ///         1: Chờ xử lý
        ///         2: Đang xử lý
        ///         3: Đã xử lý
        ///         4: Bị từ chối
        ///         5: Hủy
        ///
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("GetRightRegistrationList")]
        public async Task<IActionResult> GetRightRegistrationListAsync(RightRegistrationListRequest model)
        {
            var response = await _rightRegistrationService.GetRightRegistrationListAsync(model);
            return Ok(response);
        }
        
        /// <summary>
        ///     Lấy danh sách lịch sử đăng ký quyền mua
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/RightRegistration/GetRightRegistrationHist
        ///     {
        ///         "UserId": "cuongnv3",
        ///         "CustomerId": "",
        ///         "AccountNo": "",
        ///         "ContractNo": "",
        ///         "RightDateFrom": "",
        ///         "RightDateTo": "",
        ///         "Status": -1,
        ///         "XType": -1,
        ///         "Symbol": "",
        ///         "UserIdEdit": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     Status:
        ///         -1: Search All
        ///         1: Chờ xử lý
        ///         2: Đang xử lý
        ///         3: Đã xử lý
        ///         4: Bị từ chối
        ///         5: Hủy
        /// 
        ///     XType:
        ///         -1: Search All
        ///         0: Quyền mua cổ phiếu/trái phiếu
        ///         1: Cổ tức bằng cổ phiếu
        ///         2: Cổ phiếu thưởng
        ///         3: Cổ tức bằng tiền
        ///         4: Chuyển nhượng
        ///
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("GetRightRegistrationHist")]
        public async Task<IActionResult> GetRightRegistrationHistAsync(RightRegistrationHistRequest model)
        {
            var response = await _rightRegistrationService.GetRightRegistrationHistAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy chi tiết quyền mua
        /// </summary>
        /// <param name="id"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/RightRegistration/GetRightRegistrationById/10147
        /// </remarks>
        
        [HttpPost("GetRightRegistrationById/{id:long}")]
        public async Task<IActionResult> GetRightRegistrationDetailAsync(long id)
        {
            var response = await _rightRegistrationService.GetRightRegistrationDetailAsync(id);
            return Ok(response);
        }

        /// <summary>
        ///     Lấy danh sách cổ phiếu hưởng quyền
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/RightRegistration/GetRightStockList
        ///     {
        ///         "XType": -1,
        ///         "Symbol": "",
        ///         "RightDateFrom": "",
        ///         "RightDateTo": "",
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// 
        ///     XType:
        ///         -1: Search All
        ///         0: Quyền mua cổ phiếu/trái phiếu
        ///         1: Cổ tức bằng cổ phiếu
        ///         2: Cổ phiếu thưởng
        ///         3: Cổ tức bằng tiền
        ///         4: Chuyển nhượng
        ///
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("GetRightStockList")]
        public async Task<IActionResult> GetRightStockListAsync(RightStockListRequest model)
        {
            var response = await _rightRegistrationService.GetRightStockListAsync(model);
            return Ok(response);
        }

        /// <summary>
        ///     Thay đổi trạng thái thông tin đăng ký quyền mua
        /// </summary>
        /// 
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/RightRegistration/ChangeStatusRightRegistration
        ///     {
        ///         "Id": 1105,
        ///         "Status" : 3 
        ///         "Reason" : ""
        ///         "UpdatedBy" : "cuongnv3"
        ///     }
        /// 
        /// 
        ///     Status:
        ///         1: Chờ xử lý : Chờ xử lý -> Đang xử lý, Chờ xử lý -> Bị từ chối
        ///         2: Đang xử lý : Đang xử lý -> Đã xử lý, Đang xử lý -> Chờ xử lý, Đang xử lý -> Bị Từ Chối
        ///         3: Đã xử lý : Đã xử lý -> Hủy
        ///         4: Bị từ chối
        ///         5: Hủy
        /// </remarks>
        
        [HttpPost("ChangeStatusRightRegistration")]
        public async Task<IActionResult> ChangeStatusRightRegistrationAsync(RightRegistrationStatusRequest model)
        {
            var response = await _rightRegistrationService.ChangeStatusRightRegistrationAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Export danh sách đăng ký quyền mua
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/RightRegistration/ExportRightRegistrationList
        ///     {
        ///         "UserId": "cuongnv3",
        ///         "CustomerId": "",
        ///         "AccountNo": "",
        ///         "ContractNo": "",
        ///         "RightDateFrom": "",
        ///         "RightDateTo": "",
        ///         "Status": -1,
        ///         "Symbol": "",
        ///         "UserIdEdit": "",
        ///         "BranchId": "",
        ///         "CustomerType": -1,
        ///         "PendingStatusId": -1
        ///     }
        /// 
        ///     Status:
        ///         -1: Search All
        ///         1: Chờ xử lý
        ///         2: Đang xử lý
        ///         3: Đã xử lý
        ///         4: Bị từ chối
        ///         5: Hủy
        ///
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("ExportRightRegistrationList")]
        public async Task<IActionResult> ExportRightRegistrationListAsync(RightRegistrationListExportRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"DANG_KY_QUYEN_MUA_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _rightRegistrationService.ExportRightRegistrationListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }

        /// <summary>
        ///     Export danh sách lịch sử đăng ký quyền mua
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/RightRegistration/ExportRightRegistrationHist
        ///     {
        ///         "UserId": "cuongnv3",
        ///         "CustomerId": "",
        ///         "AccountNo": "",
        ///         "ContractNo": "",
        ///         "RightDateFrom": "",
        ///         "RightDateTo": "",
        ///         "Status": -1,
        ///         "XType": -1,
        ///         "Symbol": "",
        ///         "UserIdEdit": ""
        ///     }
        /// 
        ///     Status:
        ///         -1: Search All
        ///         1: Chờ xử lý
        ///         2: Đang xử lý
        ///         3: Đã xử lý
        ///         4: Bị từ chối
        ///         5: Hủy
        /// 
        ///     XType:
        ///         -1: Search All
        ///         0: Quyền mua cổ phiếu/trái phiếu
        ///         1: Cổ tức bằng cổ phiếu
        ///         2: Cổ phiếu thưởng
        ///         3: Cổ tức bằng tiền
        ///         4: Chuyển nhượng
        ///
        ///     Format Date: yyyyMMdd
        /// </remarks>
        
        [HttpPost("ExportRightRegistrationHist")]
        public async Task<IActionResult> ExportRightRegistrationHistAsync(RightRegistrationHistExportRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"LICH_SU_DANG_KY_QUYEN_MUA_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _rightRegistrationService.ExportRightRegistrationHistAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }

    }
}