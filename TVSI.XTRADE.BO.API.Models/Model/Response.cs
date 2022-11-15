namespace TVSI.XTRADE.BO.API.Models.Model;

public class ResponsePartner
{
    public string Code { get; set; } = "-1";
    public string? Message { get; set; }
    public object? Data { get; set; } = null;
}

public class Response<T>
{
    public string Code { get; set; } = "-1";
    public string? Message { get; set; }
    public IEnumerable<T>? Data { get; set; } = null;
}

public class ResponseSingle<T>
{
    public string Code { get; set; } = "-1";
    public string? Message { get; set; }
    public T? Data { get; set; } = default;
}