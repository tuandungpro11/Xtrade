using TVSI.XTRADE.BO.API.Models.Model.Request.CustomerGroup;

namespace TVSI.XTRADE.BO.API.Services.Interfaces.Business;

public interface ICustomerGroupService
{
    Task<Response<dynamic>?> GetCustomerGroupListAsync(CustomerGroupListRequest model);
    Task<Response<int>> CreateCustomerGroupAsync(CustomerGroupRequest model);
    Task<Response<int>> UpdateCustomerGroupAsync(CustomerGroupRequest model);
    Task<Response<int>> DeleteCustomerGroupAsync(int groupId);
}