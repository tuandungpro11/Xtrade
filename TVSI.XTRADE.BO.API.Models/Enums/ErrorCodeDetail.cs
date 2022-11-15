namespace TVSI.XTRADE.BO.API.Models.Enums
{
    //Get description from database
    public enum ErrorCodeDetail
    {
        [Description("Thành công.")]
        Success = 0,
        [Description("Thao tác không thành công.")]
        Failed = -1,
        [Description("Hệ thống bị gián đoạn. Vui lòng liên hệ 19001885 để được hỗ trợ!")]
        Exception = -99999,

        #region Code for Authen
        
        AccountHasBeenLocked = 69901,
        IncorrectInfoLogin = 69902,
        NotAllowedToAccessApplication = 69903,
        NotAllowedToAccessAction = 69904,
        TokenRequired = 69905,
        TokenNotFound = 69906,
        InvalidToken = 69907,
        NoDataFound = 69908,
        InvalidUserInfo = 69909,

        #endregion Code for Authen

        #region Code for Bussiness
        
        [Description("Không tìm thấy thông tin khách hàng.")]
        CustomerNoDataFound = 50001,

        #endregion Code for Bussiness
    }
}