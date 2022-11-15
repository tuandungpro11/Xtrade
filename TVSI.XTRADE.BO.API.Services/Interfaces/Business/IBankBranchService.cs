using TVSI.XTRADE.BO.API.Models.Model.Request.BankBranch;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface IBankBranchService
    {
        Task<Response<dynamic>?> GetBankBranchListAsync(BankBranchListRequest model);
        Task<Response<int>> ModifyBankBranchAsync(BankBranchRequest model);
        Task<Response<int>> DeleteBankBranchAsync(BankBranchDelRequest model);
    }
}
