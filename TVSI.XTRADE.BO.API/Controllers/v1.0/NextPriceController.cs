using Microsoft.AspNetCore.Mvc;
using TVSI.XTRADE.BO.API.Models.Model.Request.NextPrice;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TVSI.XTRADE.BO.API.Controllers.v1._0
{
    [ApiVersion("1.0")]
    public class NextPriceController : BaseController<NextPriceController>
    {
        private readonly INextPriceService _nextPriceService;

        public NextPriceController(ILogger<NextPriceController> logger, IConfiguration config,
            IDetectionService detection, INextPriceService nextPriceService, IFileService fileService, IHostingEnvironment hostEnv)
            : base(logger, config, detection, fileService, hostEnv)
        {
            _nextPriceService = nextPriceService;
        }

        /// <summary>
        ///     Lấy danh sách giá trước ngày
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/NextPrice/GetNextPriceList
        ///     {
        ///         "Symbol": "",
        ///         "LangId": 1,
        ///         "PageIndex": 1,
        ///         "PageSize": 20
        ///     }
        /// </remarks>
        
        [HttpPost("GetNextPriceList")]
        public async Task<IActionResult> GetNextPriceListAsync(NextPriceListRequest model)
        {
            var response = await _nextPriceService.GetNextPriceListAsync(model);
            return Ok(response);
        }


        /// <summary>
        ///     Thêm thông tin giá trước ngày
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/NextPrice/CreateNextPrice
        ///     {
        ///         "Symbol": "SSI",
        ///         "FloorPrice": 18.25,
        ///         "CellingPrice": 20.95,
        ///         "RefPrice": 19.60,
        ///         "Market": "HOSE"
        ///     }
        /// </remarks>
        
        [HttpPost("CreateNextPrice")]
        public async Task<IActionResult> CreateNextPriceAsync(NextPriceRequest model)
        {
            var response = await _nextPriceService.CreateNextPriceAsync(model, GetLoginName());
            return Ok(response);
        }


        /// <summary>
        ///     Cập nhật thông tin giá trước ngày
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/NextPrice/UpdateNextPrice
        ///     {
        ///         "Symbol": "SSI",
        ///         "FloorPrice": 18.25,
        ///         "CellingPrice": 20.95,
        ///         "RefPrice": 19.60,
        ///         "Market": "HOSE"
        ///     }
        /// </remarks>
        
        [HttpPost("UpdateNextPrice")]
        public async Task<IActionResult> UpdateNextPriceAsync(NextPriceRequest model)
        {
            var response = await _nextPriceService.UpdateNextPriceAsync(model, GetLoginName());
            return Ok(response);
        }

        /// <summary>
        ///     Xóa thông tin giá trước ngày
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/NextPrice/DeleteNextPrice/SSI
        /// </remarks>

        [HttpPost("DeleteNextPrice/{symbol}")]
        public async Task<IActionResult> DeleteNextPriceAsync(string symbol)
        {
            var response = await _nextPriceService.DeleteNextPriceAsync(symbol);
            return Ok(response);
        }

        /// <summary>
        ///     Tính lại giá trước ngày
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/NextPrice/CalculateAgainNextPrice
        ///     {
        ///         "HOSEPercent": 10.5,
        ///         "HNXPercent": 7.2,
        ///         "UPCOMPercent": 20.1
        ///     }
        /// </remarks>
        
        [HttpPost("CalculateAgainNextPrice")]
        public async Task<IActionResult> CalculateAgainNextPriceAsync(CalculateNextPriceRequest model)
        {
            //var response = await _nextPriceService.CalculateAgainNextPriceAsync(model);
            //return Ok(response);
            return NotFound(CommonConstants.ApiDeprecated);
        }

        /// <summary>
        /// Lấy template file Import.
        /// </summary>
        /// <returns></returns>
        
        [HttpPost("DownloadTemplateImportNextPrice")]
        public async Task<IActionResult> DownloadTemplateImportNextPriceAsync()
        {
            var rootPath = _hostEnv.ContentRootPath;
            const string fileName = "ImportNextPrice.xlsx";
            var memoryStream = await _fileService.DownloadFileAsync(rootPath, "Template/Import", fileName);

            return File(memoryStream, "application/octet-stream", fileName);
        }

        /// <summary>
        /// Import data from excel file.
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        
        [HttpPost("ImportNextPriceList")]
        public async Task<IActionResult> ImportNextPriceFromFileExcelAsync(IFormFile formFile, CancellationToken cancellationToken)
        {
            var response = await _nextPriceService.ImportNextPriceFromFileExcelAsync(formFile, cancellationToken, GetLoginName());
            return Ok(response);
        }

        /// <summary>
        ///     Export danh sách giá trước ngày
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/NextPrice/ExportNextPriceList
        ///     {
        ///         "Symbol": "",
        ///         "LangId": 1
        ///     }
        /// </remarks>
        
        [HttpPost("ExportNextPriceList")]
        public async Task<IActionResult> ExportNextPriceListAsync(NextPriceListExportRequest model)
        {
            var folderExportPath = GetFolderExportPath();
            var fileName = $"DS_GIA_TRUOC_NGAY_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";
            var fileExportPath = Path.Combine(folderExportPath, fileName);

            var fs = await _nextPriceService.ExportNextPriceListAsync(model, fileExportPath);
            return File(fs, "application/octet-stream", fileName);
        }

    }
}
