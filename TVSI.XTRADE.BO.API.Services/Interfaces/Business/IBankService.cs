namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business
{
    public interface IBankService
    {
        Task<Response<dynamic>?> GetBankListAsync(BankListRequest model);
        Task<ResponseSingle<dynamic>?> GetBankDetailAsync(int id);
        Task<Response<int>> ModifyBankAsync(BankRequest model);
        Task<Response<int>> DeleteBankAsync(BankDelRequest model);
        Task<FileStream> ExportBankListAsync(BankExportRequest model, string fileExportPath);
    }
}
