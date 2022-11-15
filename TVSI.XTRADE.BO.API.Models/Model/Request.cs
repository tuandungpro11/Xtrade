namespace TVSI.XTRADE.BO.API.Models.Model;

public class Request<T> where T : class
{
    public T? ParaInfo { get; set; }
}