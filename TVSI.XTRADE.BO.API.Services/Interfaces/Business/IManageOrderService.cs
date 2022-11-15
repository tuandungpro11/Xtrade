namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface IManageOrderService
{
    Task<ResponsePartner> GetInsideOrderListAsync(OrderListRequest model);
    Task<ResponsePartner> GetOutsideOrderListAsync(OrderListRequest model);
    Task<ResponsePartner> RePushOutsideOrderAsync(string[] ids);
    Task<ResponsePartner> GetOrderDetailAsync(string id);
    Task<ResponsePartner> GetOrderHistAsync(OrderHistRequest model);
    Task<ResponsePartner> GetOrderBasketListAsync(OrderBasketRequest model);
    Task<ResponsePartner> GetOrderBasketInfoAsync(OrderBasketInfoRequest model);
    Task<ResponsePartner> GetOrderGTDListAsync(OrderConditionGTDRequest model);
    Task<ResponsePartner> GetOrderGTDDetailAsync(OrderConditionGTDDetailRequest model);
    Task<ResponsePartner> GetOrderSTListAsync(OrderConditionSTRequest model);
    Task<ResponsePartner> GetOrderSTDetailAsync(OrderConditionSTDetailRequest model);
    Task<Response<dynamic>> GetOrderConditionListAsync(OrderConditionRequest model);
    Task<FileStream> ExportInsideOrderListAsync(OrderListExportRequest model, string fileExportPath);
    Task<FileStream> ExportOutsideOrderListAsync(OrderListExportRequest model, string fileExportPath);
    Task<FileStream> ExportOrderHistAsync(OrderHistExportRequest model, string fileExportPath);
    Task<FileStream> ExportOrderGTDListAsync(OrderConditionGTDExportRequest model, string fileExportPath);
    Task<FileStream> ExportOrderSTListAsync(OrderConditionSTExportRequest model, string fileExportPath);
}