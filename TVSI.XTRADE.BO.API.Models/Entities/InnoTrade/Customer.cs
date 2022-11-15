namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class Customer
    {
        public Customer()
        {
            Agentcustomers = new HashSet<Agentcustomer>();
            Synctokenhistories = new HashSet<Synctokenhistory>();
        }

        public string Customerid { get; set; } = null!;
        public string? Customerno { get; set; }
        public string? Customername { get; set; }
        public string? Password { get; set; }
        public string? Pin { get; set; }
        public int? Authtype { get; set; }
        public string? Identitycard { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Cellphone { get; set; }
        public DateTime? Activedate { get; set; }
        /// <summary>
        /// Binh thuong 0; bi khoa/ tam ngung GD do broker 1; Bi khoa do dang nhap sai pass 2; Bi tam ngung gd do nhap sai ma pin 3
        /// </summary>
        public int? Status { get; set; }
        public int? Customergroupid { get; set; }
        public decimal? Totalpoint { get; set; }
        public string? Userid { get; set; }
        public string? Branchid { get; set; }
        public bool? Repeatpass { get; set; }
        public string? Contactemail { get; set; }
        public string? Contactphone { get; set; }
        /// <summary>
        /// Xac dinh tai khoan mac dinh cho ContactPhone
        /// </summary>
        public bool? Isdefault { get; set; }
        /// <summary>
        /// Code de xac nhan active account
        /// </summary>
        public string? Confirmcode { get; set; }
        public string? Credittype { get; set; }
        public string? Defaultaccount { get; set; }
        public string? Pinconfirmcode { get; set; }
        public int? Customertype { get; set; }
        public string? Pcflag { get; set; }
        public string? Custodian { get; set; }
        public string? Mktid { get; set; }
        public string? Pickaccount { get; set; }
        public bool? EpEnable { get; set; }
        public string? EpPassword { get; set; }
        public bool? EpFirstLogon { get; set; }
        public int? ValidatePass { get; set; }
        public int? ValidatePin { get; set; }
        public string? Otp { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Sex { get; set; }
        public DateTime? Cardissue { get; set; }
        public string? Placeissue { get; set; }
        public string? Occupation { get; set; }
        public string? Nationality { get; set; }
        public string? Paymenttype { get; set; }
        public string? Remark { get; set; }
        public DateTime? Modificationdate { get; set; }
        public string? TaxCode { get; set; }
        public DateTime? ModifiedDatePass { get; set; }
        public DateTime? ModifiedDatePin { get; set; }
        public int? BuySellSameDay { get; set; }

        public virtual ICollection<Agentcustomer> Agentcustomers { get; set; }
        public virtual ICollection<Synctokenhistory> Synctokenhistories { get; set; }
    }
}
