namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Insertstatuslog
    {
        public long Instlogid { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Begininstdate { get; set; }
        public DateTime? Endinstdate { get; set; }
        /// <summary>
        /// Started/Updating/Failed/Finished
        /// </summary>
        public string? Statusstate { get; set; }
        /// <summary>
        /// 0/1/2/3
        /// </summary>
        public int? Statuscode { get; set; }
        public string? Statusmessage { get; set; }
        public int? Numofrecord { get; set; }
        public string? Table { get; set; }
        public int? Currentnumofrecord { get; set; }
    }
}
