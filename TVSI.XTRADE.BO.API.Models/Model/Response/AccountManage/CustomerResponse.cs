namespace TVSI.XTRADE.BO.API.Models.Model.Response.AccountManage;

public class CustomerResponse
{
    public string CUSTOMERID { get; set; }
    public string CUSTOMERNO { get; set; }
    public string CUSTOMERNAME { get; set; }
    public string PASSWORD { get; set; }
    public string PIN { get; set; }
    public int AUTHTYPE { get; set; }
    public string IDENTITYCARD { get; set; }
    public string ADDRESS { get; set; }
    public string EMAIL { get; set; }
    public string PHONE { get; set; }
    public string CELLPHONE { get; set; }
    public DateTime ACTIVEDATE { get; set; }
    public int STATUS { get; set; }
    public string STATUS_TEXT { get; set; }
    public int CUSTOMERGROUPID { get; set; }
    public float TOTALPOINT { get; set; }
    public object USERID { get; set; }
    public string BRANCHID { get; set; }
    public object REPEATPASS { get; set; }
    public string CONTACTEMAIL { get; set; }
    public string CONTACTPHONE { get; set; }
    public bool ISDEFAULT { get; set; }
    public object CONFIRMCODE { get; set; }
    public string CREDITTYPE { get; set; }
    public object DEFAULTACCOUNT { get; set; }
    public object PINCONFIRMCODE { get; set; }
    public int CUSTOMERTYPE { get; set; }
    public string CUSTOMERTYPE_TEXT { get; set; }
    public string PCFLAG { get; set; }
    public string CUSTODIAN { get; set; }
    public string MKTID { get; set; }
    public string PICKACCOUNT { get; set; }
    public object EP_Enable { get; set; }
    public object EP_Password { get; set; }
    public object EP_FirstLogon { get; set; }
    public int ValidatePass { get; set; }
    public int ValidatePin { get; set; }
    public object OTP { get; set; }
    public DateTime BIRTHDAY { get; set; }
    public string SEX { get; set; }
    public DateTime CARDISSUE { get; set; }
    public string PLACEISSUE { get; set; }
    public string OCCUPATION { get; set; }
    public string NATIONALITY { get; set; }
    public object PAYMENTTYPE { get; set; }
    public string REMARK { get; set; }
    public DateTime MODIFICATIONDATE { get; set; }
    public object AGENTTYPE { get; set; }
    public string BRANCHNAME { get; set; }
    public string CustomerGroup { get; set; }
    public object UserName { get; set; }
    public string TaxCode { get; set; }
}