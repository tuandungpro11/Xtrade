namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class CustomerMarketAlert
    {
        public long Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public int AlertType { get; set; }
        public string AlertSymbol { get; set; } = null!;
        public decimal? PointGreaterThan { get; set; }
        public decimal? PointLessThan { get; set; }
        public long? VolumeGreaterThan { get; set; }
        public long? VolumeLessThan { get; set; }
        public bool IsAlertCeilingPrice { get; set; }
        public bool IsAlertFloorPrice { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = null!;
        public int Status { get; set; }
    }
}
