namespace TVSI.XTRADE.BO.API.Models.Model.Request.Stock
{
    public class ModifyExceptionStock
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Date { get; set; }
        public string Market { get; set; }
    }
}
