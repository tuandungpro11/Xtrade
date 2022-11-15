namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Loginfo
    {
        public long Loginfoid { get; set; }
        public string? Customerid { get; set; }
        public string? Agentid { get; set; }
        public string? Userid { get; set; }
        /// <summary>
        /// USER_LOGON = 1,
        /// USER_LOGOUT = 2,
        /// CUSTOMER_LOGON = 3,
        /// CUSTOMER_LOGOUT = 4,
        /// NEW_CUSTOMER = 5,
        /// DISABLE_CUSTOMER = 6,
        /// DELETE_CUSTOMER = 7,
        /// CHANGE_ETEMAIL = 8,
        /// CHANGE_CCMOBILE = 9,
        /// CHANGE_BANK_ACCOUNT = 10,
        /// CHANGE_PASSWORD = 11,
        /// FORGOT_PASSWORD = 12,
        /// SYNC_TOKEN = 13,
        /// AGENT_NEW = 14,
        /// AGENT_ADD_CUST = 15,
        /// AGENT_CHANGE = 16,
        /// AGENT_REM_CUST = 17,
        /// AGENT_CHANGE_RIGHT  =18,
        /// TOKEN2PIN = 19,
        /// PIN2TOKEN =20,
        /// CHANGE_PIN = 21,
        /// CHANGE_CONFIG = 22
        /// </summary>
        public int? Actiontype { get; set; }
        public DateTime? Actiontime { get; set; }
        public string? Oldinfo { get; set; }
        public string? Newinfo { get; set; }
        public string? Ip { get; set; }
        public string? Remark { get; set; }
        public string? Module { get; set; }
    }
}
