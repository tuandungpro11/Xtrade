namespace TVSI.XTRADE.BO.API.Middlewares;

public class LoggingMiddleware
{
    private readonly IConfiguration _config;
    private readonly ILogger _logger;
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IConfiguration config)
    {
        _next = next;
        _logger = loggerFactory.CreateLogger<LoggingMiddleware>();
        _config = config;
    }

    public async Task Invoke(HttpContext context)
    {
        var processId = Guid.NewGuid().ToString().Replace("-", "");
        await LogRequest(context, processId);
        await LogResponse(context, processId);
    }

    private async Task LogRequest(HttpContext context, string processId)
    {
        try
        {
            var text = string.Empty;
            context.Request.EnableBuffering();

            var value = context.Request.Path.Value?.Split("/");
            var valCode = (value?.LastOrDefault() ?? string.Empty).ToUpper();

            var ignore = _config["LogIgnore:Request"] ?? string.Empty;
            var arrIgnore = ignore.Split("|");
            var i = 0;
            foreach (var item in arrIgnore)
            {
                if (!valCode.Contains(item))
                    continue;
                text = $"{item} đã được tiếp nhận.";
                i++;
                break;
            }

            if (i == 0)
            {
                await using var requestStream = new MemoryStream();
                await context.Request.Body.CopyToAsync(requestStream);
                text = ReadStream(requestStream);
            }

            _logger.LogInformation($"REQUEST Id:{processId}\n" +
                                   $"{context.Request.Method} {context.Request.Scheme}://{context.Request.Host.Value}{context.Request.Path.Value}{context.Request.QueryString} \n" +
                                   $"Body: {text}");
            context.Request.Body.Position = 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
        }
    }

    private async Task LogResponse(HttpContext context, string processId)
    {
        try
        {
            var text = string.Empty;
            var originalBodyStream = context.Response.Body;

            await using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;

            await _next(context);

            context.Response.Body.Seek(0, SeekOrigin.Begin);
            text = await new StreamReader(context.Response.Body).ReadToEndAsync();
            context.Response.Body.Seek(0, SeekOrigin.Begin);

            var value = context.Request.Path.Value?.Split("/");
            var valCode = (value?.LastOrDefault() ?? string.Empty).ToUpper();

            var ignore = _config["LogIgnore:Response"] ?? string.Empty;
            var arrIgnore = ignore.Split("|");

            foreach (var item in arrIgnore)
            {
                if (!valCode.Contains(item))
                    continue;
                text = $"{item} đã hoàn thành.";
                break;
            }

            _logger.LogInformation($"RESPONSE Id:{processId}\n" +
                                   $"StatusCode: {context.Response.StatusCode}\n" +
                                   $"Body: {text}");

            await responseBody.CopyToAsync(originalBodyStream);
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
        }
    }

    private string ReadStream(Stream stream)
    {
        try
        {
            const int bufferLength = 4096;
            stream.Seek(0, SeekOrigin.Begin);
            using var textWriter = new StringWriter();
            using var reader = new StreamReader(stream);
            var buffer = new char[bufferLength];
            int readCount;
            do
            {
                readCount = reader.ReadBlock(buffer, 0, bufferLength);
                textWriter.Write(buffer, 0, readCount);
            } while (readCount > 0);

            var body = textWriter.ToString();
            return body.IsJsonObject() ? body.WriteLogNonePassword().ToString() : body;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                $"{MethodBase.GetCurrentMethod()?.Name}: {ex.Message} - {ex.InnerException} - {ex.StackTrace}");
            return string.Empty;
        }
    }
}