using AutoMapper;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerUI;
using TVSI.XTRADE.BO.API.Extensions;
using TVSI.XTRADE.BO.API.Models.AutoMapper;
using TVSI.XTRADE.BO.API.Models.Entities.Demo;

var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var logging = builder.Logging;
var services = builder.Services;

#region AppSetting

configuration
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{env}.json", true, true)
    .AddEnvironmentVariables();

#endregion AppSetting

#region Log4net

logging
    .SetMinimumLevel(LogLevel.Trace)
    .AddLog4Net("log4net.config");

#endregion Log4net

// Add services to the container.

#region Detection

services.AddDetection();
services.AddDetectionCore().AddBrowser();
services.AddDetectionCore().AddPlatform();
services.AddDetectionCore().AddEngine();
services.AddDetectionCore().AddDevice();

#endregion Detection

#region Database

#endregion Database

#region Cache

var redisPass = configuration["Redis:Pwd"];
if (env != "Development")
    redisPass = Crypto.Decrypt(redisPass, CommonConstants.EncryptionKeys);
var redisConf = $"{configuration["Redis:Ip"]},password={redisPass}";

services.AddStackExchangeRedisCache(options => { options.Configuration = redisConf; });

var cm = ConnectionMultiplexer.Connect(redisConf);
services.AddSingleton<IConnectionMultiplexer>(cm);

#endregion Cache

#region ApiVersioning

services.AddApiVersioning(config =>
{
    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.AssumeDefaultVersionWhenUnspecified = true;
    config.ReportApiVersions = true;
    config.ApiVersionReader = ApiVersionReader.Combine(
        new HeaderApiVersionReader("x-api-version"),
        new QueryStringApiVersionReader("v"));
});

services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

#endregion ApiVersioning

#region Authentication

var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Secret"]));
var tokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidIssuer = configuration["Jwt:Issuer"],
    ValidateAudience = true,
    ValidAudience = configuration["Jwt:Audience"],
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = signingKey,
    RequireExpirationTime = false,
    ValidateLifetime = true,
    ClockSkew = TimeSpan.Zero
};

services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = tokenValidationParameters;
});

#endregion Authentication

#region Swagger

services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
{
    c.OperationFilter<OperationFilter>();

    var xmlPath = Path.Combine(AppContext.BaseDirectory, "ApiDocument.xml");
    if (File.Exists(xmlPath))
        c.IncludeXmlComments(xmlPath);

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description =
            "Add to request header with Authorization key and value format 'Bearer' [space] 'your jwt token'.\r\n\r\nExample: \"Bearer 24AB855E-CA1F-4098-8DCF-12F7AA9BCB82\""
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

#endregion Swagger

#region AutoMapper

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MapperProfiles());
});
var mapper = config.CreateMapper();
services.AddSingleton(mapper);

#endregion AutoMapper

services.AddServices();
services.AddControllers().AddNewtonsoftJson(options =>{options.SerializerSettings.ContractResolver = new DefaultContractResolver();});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        var apiVersionDescriptions
            = app.Services.GetService<IApiVersionDescriptionProvider>()?.ApiVersionDescriptions;
        if (apiVersionDescriptions == null) return;
        foreach (var description in apiVersionDescriptions)
        {
            c.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName);
            c.DocExpansion(DocExpansion.None);
        }
    });
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCustomMiddleware();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpMetrics();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/",
        async context => { await context.Response.WriteAsync("TVSI - X-TradeBo API"); });
});

app.MapControllers();

app.Run();