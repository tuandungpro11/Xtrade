namespace TVSI.XTRADE.BO.API.Models.Model.Request.SysConfig
{
    public class FeeTaxChannelRequest
    {
        public int Id { get; set; }
        public decimal FeeRatio { get; set; }
        public decimal MinFee { get; set; }
    }
}
