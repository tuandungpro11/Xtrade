namespace TVSI.XTRADE.BO.API.Filters.SwaggerFilter
{
    public class SwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public SwaggerOptions(IApiVersionDescriptionProvider provider) => _provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateApiVersion(description));
            }
        }

        private static OpenApiInfo CreateApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = $"{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")} - TVSI X-TRADE BO API",
                Description = $"API for X-Trade BO",
                Version = description.ApiVersion.ToString(),
                Contact = new OpenApiContact
                {
                    Name = "TVSI Securities",
                    Url = new Uri("https://www.tvsi.com.vn"),
                }
            };

            if (description.IsDeprecated)
            {
                info.Description += " - This API version has been deprecated.";
            }

            return info;
        }
    }
}