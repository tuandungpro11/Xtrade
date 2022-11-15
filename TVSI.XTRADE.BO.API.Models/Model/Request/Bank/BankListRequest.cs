namespace TVSI.XTRADE.BO.API.Models.Model.Request.Bank
{
    public class BankListRequest : BankExportRequest
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
