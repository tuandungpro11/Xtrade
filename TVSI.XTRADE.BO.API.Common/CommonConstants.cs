namespace TVSI.XTRADE.BO.API.Common
{
    public static class CommonConstants
    {
        #region Times

        public const int _1Day = 1;
        public const int _7Days = 7;
        public const int _30Days = 30;

        public const int _1Hours = 1;
        public const int _4Hours = 4;
        public const int _8Hours = 8;

        public const int _10Minutes = 10;
        public const int _15Minutes = 15;
        public const int _30Minutes = 30;
        public const int _60Minutes = 60;

        #endregion Times

        public const int SqlServerTimeout = 30; //seconds
        public const int ApiCallerTimeout = 10000; //milliseconds = 0.166666667 minutes 

        public const int AccessFailedCount = 5;
        public const int ShowCaptcha = 3;

        public const string EncryptionKeys = "!Tvsi@2022#$%^&*";
        public const string SchemaAuth = "Bearer ";

        public const string ErrPrefix = "";
        public const string PasswordChar = "********";

        public const string ApiDeprecated = "This API has been deprecated";
    }

    public static class CacheKeys
    {
        public const string RootPath = "AUTH:";
        public const string UserInfo = RootPath + "USER_INFO:";
        public const string AccessFailedCount = RootPath + "ACCESS_FAILED_COUNT:";
        public const string TokenRevoked = RootPath + "TOKEN_REVOKED:";
        public const string TokenCurrDevice = RootPath + "TOKEN_CURR_DEVICE:";


        public const string ServicePath = "XTRADEBO:";
        public const string SysConfigParam = ServicePath + "SYS:SYS_CONFIG_PARAM";
        public const string SysErrCode = ServicePath + "SYS:SYS_ERR_CODE";
    }
}