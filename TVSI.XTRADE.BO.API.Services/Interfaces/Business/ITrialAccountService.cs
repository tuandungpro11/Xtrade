using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface ITrialAccountService
    {
        Task<Response<dynamic>?> GetTrialAccountListAsync(string? custCode, int status);
        Task<ResponseSingle<dynamic>?> GetTrialAccountDetailAsync(string custCode);
        Task<Response<int>> AddTrialAccountAsync(string custCode);
        Task<Response<int>> ChangeActiveTrialAccountAsync(string custCode, int status);
        Task<FileStream> ExportTrialAccountListAsync(string? custCode, int status, string fileExportPath);
    }
}
