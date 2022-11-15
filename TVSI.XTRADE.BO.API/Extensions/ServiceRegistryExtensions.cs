namespace TVSI.XTRADE.BO.API.Extensions
{
    public static class ServiceRegistryExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            #region Core Service

            services.AddScoped<IDapperHelper, DapperHelper>();
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerOptions>();
            services.AddScoped<IApiCallerService, ApiCallerService>();
            services.AddScoped<IRedisService, RedisService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IDistributeCacheService, DistributeCacheService>();

            #endregion Core Service

            #region Business service

            services.AddScoped<ISysConfigService, SysConfigService>();
            services.AddScoped<IAccountManageService, AccountManageService>();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<IBankBranchService, BankBranchService>();
            services.AddScoped<IBankAccountService, BankAccountService>();
            services.AddScoped<IExTraderService, ExTraderService>();
            services.AddScoped<IOverdraftIncludeStockService, OverdraftIncludeStockService>();
            services.AddScoped<IOverdraftService, OverdraftService>();
            services.AddScoped<IOverdraftAccountService, OverdraftAccountService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IExceptionStockService, ExceptionStockService>();
            services.AddScoped<ICustomerGroupService, CustomerGroupService>();
            services.AddScoped<IInternalAccountService, InternalAccountService>();
            services.AddScoped<ILoggingService, LoggingService>();
            services.AddScoped<IManageOrderService, ManageOrderService>();
            services.AddScoped<IRightRegistrationService, RightRegistrationService>();
            services.AddScoped<INextPriceService, NextPriceService>();
            services.AddScoped<ISupperAccountService, SupperAccountService>();
            services.AddScoped<IWhiteListService, WhiteListService>();
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<ITrialAccountService, TrialAccountService>();
            services.AddScoped<IAgentService, AgentService>();
            services.AddScoped<IFileAttachService, FileAttachService>();

            #endregion Business service

            return services;
        }
    }
}