using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TVSI.XTRADE.BO.API.Models.Entities.InnoTrade
{
    public partial class TEST_InnoTradeDB_PROContext : DbContext
    {
        public TEST_InnoTradeDB_PROContext()
        {
        }

        public TEST_InnoTradeDB_PROContext(DbContextOptions<TEST_InnoTradeDB_PROContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Account20190912> Account20190912s { get; set; } = null!;
        public virtual DbSet<AccountCoregroup> AccountCoregroups { get; set; } = null!;
        public virtual DbSet<AccountNotifyType> AccountNotifyTypes { get; set; } = null!;
        public virtual DbSet<AccountSetting> AccountSettings { get; set; } = null!;
        public virtual DbSet<AccountTemp> AccountTemps { get; set; } = null!;
        public virtual DbSet<Accountagent> Accountagents { get; set; } = null!;
        public virtual DbSet<Accountpermission> Accountpermissions { get; set; } = null!;
        public virtual DbSet<AccountpermissionBackup0013471> AccountpermissionBackup0013471s { get; set; } = null!;
        public virtual DbSet<Accountpermissiontemp> Accountpermissiontemps { get; set; } = null!;
        public virtual DbSet<AccumulationPoint> AccumulationPoints { get; set; } = null!;
        public virtual DbSet<Action> Actions { get; set; } = null!;
        public virtual DbSet<Advance> Advances { get; set; } = null!;
        public virtual DbSet<AdvancePretest> AdvancePretests { get; set; } = null!;
        public virtual DbSet<Advancehistory> Advancehistories { get; set; } = null!;
        public virtual DbSet<Advancelog> Advancelogs { get; set; } = null!;
        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<AgentBrokerException> AgentBrokerExceptions { get; set; } = null!;
        public virtual DbSet<Agentcustomer> Agentcustomers { get; set; } = null!;
        public virtual DbSet<Agentgroup> Agentgroups { get; set; } = null!;
        public virtual DbSet<Agreement> Agreements { get; set; } = null!;
        public virtual DbSet<AgreementFeature> AgreementFeatures { get; set; } = null!;
        public virtual DbSet<AgreementRegistration> AgreementRegistrations { get; set; } = null!;
        public virtual DbSet<AgreementRegistrationBackup20210119> AgreementRegistrationBackup20210119s { get; set; } = null!;
        public virtual DbSet<AlertAction> AlertActions { get; set; } = null!;
        public virtual DbSet<AlertActionHistory> AlertActionHistories { get; set; } = null!;
        public virtual DbSet<AlertActionHistoryOld> AlertActionHistoryOlds { get; set; } = null!;
        public virtual DbSet<AlertActionOld> AlertActionOlds { get; set; } = null!;
        public virtual DbSet<AlertReg> AlertRegs { get; set; } = null!;
        public virtual DbSet<AlertRegHistory> AlertRegHistories { get; set; } = null!;
        public virtual DbSet<AuditAuthentication> AuditAuthentications { get; set; } = null!;
        public virtual DbSet<AuditAuthenticationHistory> AuditAuthenticationHistories { get; set; } = null!;
        public virtual DbSet<BankAccountBackup20170802> BankAccountBackup20170802s { get; set; } = null!;
        public virtual DbSet<Bankaccount> Bankaccounts { get; set; } = null!;
        public virtual DbSet<BankaccountBk20170210> BankaccountBk20170210s { get; set; } = null!;
        public virtual DbSet<Bankbalanceinfo> Bankbalanceinfos { get; set; } = null!;
        public virtual DbSet<Banklist> Banklists { get; set; } = null!;
        public virtual DbSet<Banklist20160916> Banklist20160916s { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<Branchnolist> Branchnolists { get; set; } = null!;
        public virtual DbSet<Branchnolist20160916> Branchnolist20160916s { get; set; } = null!;
        public virtual DbSet<Branchuser> Branchusers { get; set; } = null!;
        public virtual DbSet<Breakingnews> Breakingnews { get; set; } = null!;
        public virtual DbSet<Broker> Brokers { get; set; } = null!;
        public virtual DbSet<Brokerchangedlog> Brokerchangedlogs { get; set; } = null!;
        public virtual DbSet<Cashapisequence> Cashapisequences { get; set; } = null!;
        public virtual DbSet<Cashbalance> Cashbalances { get; set; } = null!;
        public virtual DbSet<Cashdueinfo> Cashdueinfos { get; set; } = null!;
        public virtual DbSet<CashdueinfoTplu> CashdueinfoTplus { get; set; } = null!;
        public virtual DbSet<CashdueinfoTplusHistory> CashdueinfoTplusHistories { get; set; } = null!;
        public virtual DbSet<Cashstatementrequest> Cashstatementrequests { get; set; } = null!;
        public virtual DbSet<Cashstatementrequesthistory> Cashstatementrequesthistories { get; set; } = null!;
        public virtual DbSet<Cashtran> Cashtrans { get; set; } = null!;
        public virtual DbSet<Cashtransfer> Cashtransfers { get; set; } = null!;
        public virtual DbSet<CashtransferPretest> CashtransferPretests { get; set; } = null!;
        public virtual DbSet<Cashtransferhistory> Cashtransferhistories { get; set; } = null!;
        public virtual DbSet<Ccinfo> Ccinfos { get; set; } = null!;
        public virtual DbSet<Changeaccountinfo> Changeaccountinfos { get; set; } = null!;
        public virtual DbSet<Commission> Commissions { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<ConfigurationAcp> ConfigurationAcps { get; set; } = null!;
        public virtual DbSet<ConfigurationBackup20210705> ConfigurationBackup20210705s { get; set; } = null!;
        public virtual DbSet<ConfigurationBackup20220506> ConfigurationBackup20220506s { get; set; } = null!;
        public virtual DbSet<ConnectionStatus> ConnectionStatuses { get; set; } = null!;
        public virtual DbSet<Coo> Coos { get; set; } = null!;
        public virtual DbSet<Coo2orderInfo> Coo2orderInfos { get; set; } = null!;
        public virtual DbSet<Coo2orderinfohistory> Coo2orderinfohistories { get; set; } = null!;
        public virtual DbSet<CooMptransaction> CooMptransactions { get; set; } = null!;
        public virtual DbSet<CooPretest> CooPretests { get; set; } = null!;
        public virtual DbSet<CooSt> CooSts { get; set; } = null!;
        public virtual DbSet<CooT> CooTs { get; set; } = null!;
        public virtual DbSet<CooTriggerPriceTransaction> CooTriggerPriceTransactions { get; set; } = null!;
        public virtual DbSet<Coobackup> Coobackups { get; set; } = null!;
        public virtual DbSet<Cooinfo> Cooinfos { get; set; } = null!;
        public virtual DbSet<Cooinfohistory> Cooinfohistories { get; set; } = null!;
        public virtual DbSet<Coolog> Coologs { get; set; } = null!;
        public virtual DbSet<Cooorderhistory> Cooorderhistories { get; set; } = null!;
        public virtual DbSet<Coreaccount> Coreaccounts { get; set; } = null!;
        public virtual DbSet<Coredelegate> Coredelegates { get; set; } = null!;
        public virtual DbSet<Coregroup> Coregroups { get; set; } = null!;
        public virtual DbSet<Coreuser> Coreusers { get; set; } = null!;
        public virtual DbSet<CoreuserCoreaccount> CoreuserCoreaccounts { get; set; } = null!;
        public virtual DbSet<Creditlinestocklist> Creditlinestocklists { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerAuthen> CustomerAuthens { get; set; } = null!;
        public virtual DbSet<CustomerBranch> CustomerBranches { get; set; } = null!;
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; } = null!;
        public virtual DbSet<CustomerMarketAlert> CustomerMarketAlerts { get; set; } = null!;
        public virtual DbSet<CustomerNotifySetting> CustomerNotifySettings { get; set; } = null!;
        public virtual DbSet<Customerchangedlog> Customerchangedlogs { get; set; } = null!;
        public virtual DbSet<Customerchangedloghistory> Customerchangedloghistories { get; set; } = null!;
        public virtual DbSet<Customeremail> Customeremails { get; set; } = null!;
        public virtual DbSet<Customergroup> Customergroups { get; set; } = null!;
        public virtual DbSet<Customerpermission> Customerpermissions { get; set; } = null!;
        public virtual DbSet<Customerpermissiont> Customerpermissionts { get; set; } = null!;
        public virtual DbSet<Customerphone> Customerphones { get; set; } = null!;
        public virtual DbSet<Dealhistory> Dealhistories { get; set; } = null!;
        public virtual DbSet<Dealhistory3d> Dealhistory3ds { get; set; } = null!;
        public virtual DbSet<DealhistoryBackup20191016> DealhistoryBackup20191016s { get; set; } = null!;
        public virtual DbSet<Dealhistorybackup> Dealhistorybackups { get; set; } = null!;
        public virtual DbSet<Dealinfo> Dealinfos { get; set; } = null!;
        public virtual DbSet<DealinfoPretest> DealinfoPretests { get; set; } = null!;
        public virtual DbSet<Dealinfobackup> Dealinfobackups { get; set; } = null!;
        public virtual DbSet<DelegatePermissionWhiteList> DelegatePermissionWhiteLists { get; set; } = null!;
        public virtual DbSet<Delegatepermission> Delegatepermissions { get; set; } = null!;
        public virtual DbSet<DelegatepermissionTemp> DelegatepermissionTemps { get; set; } = null!;
        public virtual DbSet<DerivativesInfo> DerivativesInfos { get; set; } = null!;
        public virtual DbSet<Dividendcash> Dividendcashes { get; set; } = null!;
        public virtual DbSet<Dividendstock> Dividendstocks { get; set; } = null!;
        public virtual DbSet<Emaillog> Emaillogs { get; set; } = null!;
        public virtual DbSet<EodProcessLog> EodProcessLogs { get; set; } = null!;
        public virtual DbSet<Exceptionstock> Exceptionstocks { get; set; } = null!;
        public virtual DbSet<FosCoo> FosCoos { get; set; } = null!;
        public virtual DbSet<FosCoobackup> FosCoobackups { get; set; } = null!;
        public virtual DbSet<FosDealinfo> FosDealinfos { get; set; } = null!;
        public virtual DbSet<FosDealinfobackup> FosDealinfobackups { get; set; } = null!;
        public virtual DbSet<FosOrderinfo> FosOrderinfos { get; set; } = null!;
        public virtual DbSet<FosOrderinfobackup> FosOrderinfobackups { get; set; } = null!;
        public virtual DbSet<Fullcoo2orderinfo> Fullcoo2orderinfos { get; set; } = null!;
        public virtual DbSet<Fullcooinfo> Fullcooinfos { get; set; } = null!;
        public virtual DbSet<Function> Functions { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<HolidayHistory> HolidayHistories { get; set; } = null!;
        public virtual DbSet<Insertstatuslog> Insertstatuslogs { get; set; } = null!;
        public virtual DbSet<Internalaccount> Internalaccounts { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<LoanMarginInterest> LoanMarginInterests { get; set; } = null!;
        public virtual DbSet<Loginfo> Loginfos { get; set; } = null!;
        public virtual DbSet<Loginfohistory> Loginfohistories { get; set; } = null!;
        public virtual DbSet<Loginlog> Loginlogs { get; set; } = null!;
        public virtual DbSet<Loginloghistory> Loginloghistories { get; set; } = null!;
        public virtual DbSet<Logtransaction> Logtransactions { get; set; } = null!;
        public virtual DbSet<Logtransactionshistory> Logtransactionshistories { get; set; } = null!;
        public virtual DbSet<Loyaltyrewardspoint> Loyaltyrewardspoints { get; set; } = null!;
        public virtual DbSet<Marginstocklist> Marginstocklists { get; set; } = null!;
        public virtual DbSet<MessageSequence> MessageSequences { get; set; } = null!;
        public virtual DbSet<Module> Modules { get; set; } = null!;
        public virtual DbSet<Module1> Modules1 { get; set; } = null!;
        public virtual DbSet<NearestWorkingDate> NearestWorkingDates { get; set; } = null!;
        public virtual DbSet<Newsletter> Newsletters { get; set; } = null!;
        public virtual DbSet<Newsletterscategory> Newsletterscategories { get; set; } = null!;
        public virtual DbSet<Newslettersregistration> Newslettersregistrations { get; set; } = null!;
        public virtual DbSet<Newsresearch> Newsresearches { get; set; } = null!;
        public virtual DbSet<Newsresearchcategory> Newsresearchcategories { get; set; } = null!;
        public virtual DbSet<Newsresearchcategory2Ext> Newsresearchcategory2Exts { get; set; } = null!;
        public virtual DbSet<NewsresearchcategoryExt> NewsresearchcategoryExts { get; set; } = null!;
        public virtual DbSet<Nexdayprice> Nexdayprices { get; set; } = null!;
        public virtual DbSet<NextDayPrice> NextDayPrices { get; set; } = null!;
        public virtual DbSet<NotifyDeviceId> NotifyDeviceIds { get; set; } = null!;
        public virtual DbSet<NotifyEvent> NotifyEvents { get; set; } = null!;
        public virtual DbSet<NotifyEventHistory> NotifyEventHistories { get; set; } = null!;
        public virtual DbSet<NotifyServicesType> NotifyServicesTypes { get; set; } = null!;
        public virtual DbSet<NotifyServicesTypeLanguage> NotifyServicesTypeLanguages { get; set; } = null!;
        public virtual DbSet<Oddslot> Oddslots { get; set; } = null!;
        public virtual DbSet<OddslotPretest> OddslotPretests { get; set; } = null!;
        public virtual DbSet<Oddslotconfig> Oddslotconfigs { get; set; } = null!;
        public virtual DbSet<Oddslotexceptstock> Oddslotexceptstocks { get; set; } = null!;
        public virtual DbSet<Oddslothistory> Oddslothistories { get; set; } = null!;
        public virtual DbSet<OrderAutoApproveList> OrderAutoApproveLists { get; set; } = null!;
        public virtual DbSet<OrderBasket> OrderBaskets { get; set; } = null!;
        public virtual DbSet<OrderBasketinfo> OrderBasketinfos { get; set; } = null!;
        public virtual DbSet<OrderConditionGtd> OrderConditionGtds { get; set; } = null!;
        public virtual DbSet<OrderConditionGtdsent> OrderConditionGtdsents { get; set; } = null!;
        public virtual DbSet<OrderConditionSt> OrderConditionSts { get; set; } = null!;
        public virtual DbSet<OrderConditionStsent> OrderConditionStsents { get; set; } = null!;
        public virtual DbSet<OrderConfirmation> OrderConfirmations { get; set; } = null!;
        public virtual DbSet<OrderConfirmationExcludeTraderid> OrderConfirmationExcludeTraderids { get; set; } = null!;
        public virtual DbSet<OrderConfirmationhistory> OrderConfirmationhistories { get; set; } = null!;
        public virtual DbSet<OrderConfirmationsummary> OrderConfirmationsummaries { get; set; } = null!;
        public virtual DbSet<OrderConfirmationsummaryHistory> OrderConfirmationsummaryHistories { get; set; } = null!;
        public virtual DbSet<OrderGroup> OrderGroups { get; set; } = null!;
        public virtual DbSet<OrderGtd> OrderGtds { get; set; } = null!;
        public virtual DbSet<OrderPrior> OrderPriors { get; set; } = null!;
        public virtual DbSet<OrderSplit> OrderSplits { get; set; } = null!;
        public virtual DbSet<OrderSt> OrderSts { get; set; } = null!;
        public virtual DbSet<OrderT> OrderTs { get; set; } = null!;
        public virtual DbSet<Orderhistory> Orderhistories { get; set; } = null!;
        public virtual DbSet<Orderhistory3d> Orderhistory3ds { get; set; } = null!;
        public virtual DbSet<Orderhistorybackup> Orderhistorybackups { get; set; } = null!;
        public virtual DbSet<Orderinfo> Orderinfos { get; set; } = null!;
        public virtual DbSet<Orderinfo20170302> Orderinfo20170302s { get; set; } = null!;
        public virtual DbSet<OrderinfoBackup20210703> OrderinfoBackup20210703s { get; set; } = null!;
        public virtual DbSet<OrderinfoBk20170304> OrderinfoBk20170304s { get; set; } = null!;
        public virtual DbSet<OrderinfoPretest> OrderinfoPretests { get; set; } = null!;
        public virtual DbSet<Orderinfobackup> Orderinfobackups { get; set; } = null!;
        public virtual DbSet<Ordersource> Ordersources { get; set; } = null!;
        public virtual DbSet<OrdersourceBackup20170802> OrdersourceBackup20170802s { get; set; } = null!;
        public virtual DbSet<Orderstatistic> Orderstatistics { get; set; } = null!;
        public virtual DbSet<OverdraftAccountList> OverdraftAccountLists { get; set; } = null!;
        public virtual DbSet<OverdraftAccountListHistory> OverdraftAccountListHistories { get; set; } = null!;
        public virtual DbSet<OverdraftIncludeStock> OverdraftIncludeStocks { get; set; } = null!;
        public virtual DbSet<OverdraftIncludeStockHistory> OverdraftIncludeStockHistories { get; set; } = null!;
        public virtual DbSet<OverdraftServiceList> OverdraftServiceLists { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Permission1> Permissions1 { get; set; } = null!;
        public virtual DbSet<Portfolio> Portfolios { get; set; } = null!;
        public virtual DbSet<Portfoliohistory> Portfoliohistories { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<PushNewsNotify> PushNewsNotifies { get; set; } = null!;
        public virtual DbSet<PushNewsNotifyHistory> PushNewsNotifyHistories { get; set; } = null!;
        public virtual DbSet<Realizegainloss> Realizegainlosses { get; set; } = null!;
        public virtual DbSet<Regcontactcenter> Regcontactcenters { get; set; } = null!;
        public virtual DbSet<Rejectcode> Rejectcodes { get; set; } = null!;
        public virtual DbSet<Rightalert> Rightalerts { get; set; } = null!;
        public virtual DbSet<Rightinfo> Rightinfos { get; set; } = null!;
        public virtual DbSet<Rightregistration> Rightregistrations { get; set; } = null!;
        public virtual DbSet<Rightrequesthistory> Rightrequesthistories { get; set; } = null!;
        public virtual DbSet<Rightstk> Rightstks { get; set; } = null!;
        public virtual DbSet<Rightstk20161003> Rightstk20161003s { get; set; } = null!;
        public virtual DbSet<RightstkPretest> RightstkPretests { get; set; } = null!;
        public virtual DbSet<Rightstkhistory> Rightstkhistories { get; set; } = null!;
        public virtual DbSet<SectorIndex> SectorIndices { get; set; } = null!;
        public virtual DbSet<SessionDataHistory> SessionDataHistories { get; set; } = null!;
        public virtual DbSet<SessionDatum> SessionData { get; set; } = null!;
        public virtual DbSet<SignOnlineRegistration> SignOnlineRegistrations { get; set; } = null!;
        public virtual DbSet<SignOnlineType> SignOnlineTypes { get; set; } = null!;
        public virtual DbSet<Smsregistration> Smsregistrations { get; set; } = null!;
        public virtual DbSet<Spr> Sprs { get; set; } = null!;
        public virtual DbSet<Sprhistory> Sprhistories { get; set; } = null!;
        public virtual DbSet<Sql> Sqls { get; set; } = null!;
        public virtual DbSet<StepPriceRange> StepPriceRanges { get; set; } = null!;
        public virtual DbSet<StepPriceRangeBackup20220506> StepPriceRangeBackup20220506s { get; set; } = null!;
        public virtual DbSet<Stockbalance> Stockbalances { get; set; } = null!;
        public virtual DbSet<Stockduehistory> Stockduehistories { get; set; } = null!;
        public virtual DbSet<Stockdueinfo> Stockdueinfos { get; set; } = null!;
        public virtual DbSet<Stockdueinfohistory> Stockdueinfohistories { get; set; } = null!;
        public virtual DbSet<Stockinfo> Stockinfos { get; set; } = null!;
        public virtual DbSet<StockinfoOddlot> StockinfoOddlots { get; set; } = null!;
        public virtual DbSet<Stocktran> Stocktrans { get; set; } = null!;
        public virtual DbSet<Stocktransfer> Stocktransfers { get; set; } = null!;
        public virtual DbSet<Stocktransferaccount> Stocktransferaccounts { get; set; } = null!;
        public virtual DbSet<Stocktransferhistory> Stocktransferhistories { get; set; } = null!;
        public virtual DbSet<Synctokenhistory> Synctokenhistories { get; set; } = null!;
        public virtual DbSet<Systemlog> Systemlogs { get; set; } = null!;
        public virtual DbSet<Tradetrnhist> Tradetrnhists { get; set; } = null!;
        public virtual DbSet<Tradetrnhistbackup> Tradetrnhistbackups { get; set; } = null!;
        public virtual DbSet<TvsiDanhSachDealLenhTrongNgay> TvsiDanhSachDealLenhTrongNgays { get; set; } = null!;
        public virtual DbSet<TvsiDanhSachLenhLichSu> TvsiDanhSachLenhLichSus { get; set; } = null!;
        public virtual DbSet<TvsiDanhSachLenhTrongNgay> TvsiDanhSachLenhTrongNgays { get; set; } = null!;
        public virtual DbSet<TvsiDuLieuXacNhanLenh> TvsiDuLieuXacNhanLenhs { get; set; } = null!;
        public virtual DbSet<TvsiThongTinSuaLenh> TvsiThongTinSuaLenhs { get; set; } = null!;
        public virtual DbSet<TvsiWatchList> TvsiWatchLists { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Usergroup> Usergroups { get; set; } = null!;
        public virtual DbSet<ViewBoAccountGetBranch> ViewBoAccountGetBranches { get; set; } = null!;
        public virtual DbSet<Workingday> Workingdays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=10.0.140.25;initial catalog=TEST_InnoTradeDB_PRO;user id=innootws;password=1nn0t3ch$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("ACCOUNT");

                entity.HasIndex(e => e.AccountNo, "IDX_Account_AcccountNo");

                entity.HasIndex(e => e.AccountNo, "IDX_Account_AccountNo");

                entity.HasIndex(e => e.AccountNo, "IX_ACCOUNT_AccountNo");

                entity.HasIndex(e => new { e.CustomerId, e.AccountNo }, "IX_ACCOUNT_CustomerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BelongDate).HasColumnType("datetime");

                entity.Property(e => e.CoreAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoreType).HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Account20190912>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACCOUNT_20190912");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BelongDate).HasColumnType("datetime");

                entity.Property(e => e.CoreAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountCoregroup>(entity =>
            {
                entity.ToTable("ACCOUNT_COREGROUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Coregroupid)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COREGROUPID");
            });

            modelBuilder.Entity<AccountNotifyType>(entity =>
            {
                entity.ToTable("ACCOUNT_NOTIFY_TYPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");
            });

            modelBuilder.Entity<AccountSetting>(entity =>
            {
                entity.Property(e => e.AccountNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasMaxLength(1000);
            });

            modelBuilder.Entity<AccountTemp>(entity =>
            {
                entity.ToTable("ACCOUNT_TEMP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BelongDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Accountagent>(entity =>
            {
                entity.HasKey(e => new { e.AccountNo, e.AgentId });

                entity.ToTable("ACCOUNTAGENT");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AgentID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Accountpermission>(entity =>
            {
                entity.HasKey(e => new { e.AccountNo, e.Permission, e.Channel })
                    .HasName("PK_ACCOUNTPERMISSION_1");

                entity.ToTable("ACCOUNTPERMISSION");

                entity.HasIndex(e => e.AccountNo, "IX_ACCOUNTPERMISSION_AccountNo");

                entity.HasIndex(e => e.Channel, "IX_ACCOUNTPERMISSION_Channel");

                entity.HasIndex(e => e.Permission, "IX_ACCOUNTPERMISSION_Permission");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Channel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountpermissionBackup0013471>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACCOUNTPERMISSION_Backup_0013471");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Channel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Accountpermissiontemp>(entity =>
            {
                entity.HasKey(e => new { e.AccountNo, e.Permission, e.Channel });

                entity.ToTable("ACCOUNTPERMISSIONTEMP");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Channel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AccumulationPoint>(entity =>
            {
                entity.ToTable("AccumulationPoint");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CalDate).HasColumnType("datetime");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentAccumulationPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NewAccumulationPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Action>(entity =>
            {
                entity.ToTable("ACTIONS");

                entity.Property(e => e.Actionid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONID");

                entity.Property(e => e.Actionname)
                    .HasMaxLength(250)
                    .HasColumnName("ACTIONNAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Functionid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTIONID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.Functionid)
                    .HasConstraintName("FK_ACTIONS_FUNCTIONS");
            });

            modelBuilder.Entity<Advance>(entity =>
            {
                entity.ToTable("ADVANCE");

                entity.HasIndex(e => e.Contractno, "IDX_Advance_ContractNo");

                entity.Property(e => e.Advanceid).HasColumnName("ADVANCEID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Advancedate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADVANCEDATE");

                entity.Property(e => e.Advancefee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADVANCEFEE");

                entity.Property(e => e.Advancestatus).HasColumnName("ADVANCESTATUS");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Cashamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CASHAMOUNT");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Grossadvance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GROSSADVANCE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Netadvance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NETADVANCE");

                entity.Property(e => e.PreferenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Tradetype).HasColumnName("TRADETYPE");

                entity.Property(e => e.Transrefer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSREFER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<AdvancePretest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADVANCE_PRETEST");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Advancedate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADVANCEDATE");

                entity.Property(e => e.Advancefee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADVANCEFEE");

                entity.Property(e => e.Advanceid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ADVANCEID");

                entity.Property(e => e.Advancestatus).HasColumnName("ADVANCESTATUS");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Cashamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CASHAMOUNT");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Grossadvance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GROSSADVANCE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Netadvance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NETADVANCE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Tradetype).HasColumnName("TRADETYPE");

                entity.Property(e => e.Transrefer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSREFER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Advancehistory>(entity =>
            {
                entity.HasKey(e => e.Advancehistoryid)
                    .IsClustered(false);

                entity.ToTable("ADVANCEHISTORY");

                entity.HasIndex(e => e.Accountno, "IX_ADVANCEHISTORY_ACCOUNTNO");

                entity.HasIndex(e => e.Advancedate, "IX_ADVANCEHISTORY_ADVANCEDATE");

                entity.HasIndex(e => e.Advancestatus, "IX_ADVANCEHISTORY_ADVANCESTATUS");

                entity.HasIndex(e => e.Customerid, "IX_ADVANCEHISTORY_CUSTOMERID");

                entity.Property(e => e.Advancehistoryid).HasColumnName("ADVANCEHISTORYID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Advancedate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADVANCEDATE");

                entity.Property(e => e.Advancefee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADVANCEFEE");

                entity.Property(e => e.Advancestatus).HasColumnName("ADVANCESTATUS");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Cashamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CASHAMOUNT");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Grossadvance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GROSSADVANCE");

                entity.Property(e => e.Netadvance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NETADVANCE");

                entity.Property(e => e.PreferenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.Tradetype).HasColumnName("TRADETYPE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Advancelog>(entity =>
            {
                entity.HasKey(e => e.Advancelogid)
                    .IsClustered(false);

                entity.ToTable("ADVANCELOG");

                entity.Property(e => e.Advancelogid)
                    .ValueGeneratedNever()
                    .HasColumnName("ADVANCELOGID");

                entity.Property(e => e.Actiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONDATE");

                entity.Property(e => e.Beginstatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BEGINSTATUS");

                entity.Property(e => e.Brokerid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BROKERID");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Laststatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LASTSTATUS");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.Agentid)
                    .IsClustered(false);

                entity.ToTable("AGENT");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Agentgroupid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AGENTGROUPID");

                entity.Property(e => e.Agenttype).HasColumnName("AGENTTYPE");

                entity.Property(e => e.Bonusreserve)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("BONUSRESERVE");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Bsdcid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BSDCID");

                entity.Property(e => e.Buyauthcr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BUYAUTHCR");

                entity.Property(e => e.Buylimit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BUYLIMIT");

                entity.Property(e => e.Canappall)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CANAPPALL");

                entity.Property(e => e.Cancelconfirm)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CANCELCONFIRM");

                entity.Property(e => e.Cancovershort)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CANCOVERSHORT");

                entity.Property(e => e.Canshort)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CANSHORT");

                entity.Property(e => e.Changeordzone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEORDZONE");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dayauthcr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DAYAUTHCR");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Expiredate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPIREDATE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Keyordzone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KEYORDZONE");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Ordentryseq)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ORDENTRYSEQ");

                entity.Property(e => e.Ordentrystyle)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ORDENTRYSTYLE");

                entity.Property(e => e.Percentapp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PERCENTAPP");

                entity.Property(e => e.Sellauthcr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SELLAUTHCR");

                entity.Property(e => e.Selllimit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SELLLIMIT");

                entity.Property(e => e.Setid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SETID");

                entity.Property(e => e.Supervisorid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISORID");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Tradertype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRADERTYPE");

                entity.Property(e => e.Typeapprove)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TYPEAPPROVE");

                entity.Property(e => e.Viewordseq)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("VIEWORDSEQ");

                entity.Property(e => e.Viewordzone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("VIEWORDZONE");
            });

            modelBuilder.Entity<AgentBrokerException>(entity =>
            {
                entity.ToTable("AgentBrokerException");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraderId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Agentcustomer>(entity =>
            {
                entity.ToTable("AGENTCUSTOMER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.Authorize).HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.OldNew)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Agentcustomers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENTCUSTOMER_CUSTOMER");
            });

            modelBuilder.Entity<Agentgroup>(entity =>
            {
                entity.HasKey(e => new { e.AgentGroup1, e.SuperGroup })
                    .HasName("PK_AgentGroup");

                entity.ToTable("AGENTGROUP");

                entity.Property(e => e.AgentGroup1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AgentGroup");

                entity.Property(e => e.SuperGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentGroupName).HasMaxLength(255);
            });

            modelBuilder.Entity<Agreement>(entity =>
            {
                entity.ToTable("AGREEMENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgreementDate).HasColumnType("datetime");

                entity.Property(e => e.Channel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgreementFeature>(entity =>
            {
                entity.ToTable("AgreementFeature");

                entity.Property(e => e.AgreementFeatureId).HasColumnName("AgreementFeatureID");

                entity.Property(e => e.Activation).HasComment("0 – Chưa áp dụng, 1 Đang áp dụng");

                entity.Property(e => e.AgreementItems).HasColumnType("ntext");

                entity.Property(e => e.AgreementUrl)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.IsRequired).HasComment("0: không bắt buộc, 1 bắt buộc phải ký");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(512);

                entity.Property(e => e.Remark).HasMaxLength(512);
            });

            modelBuilder.Entity<AgreementRegistration>(entity =>
            {
                entity.ToTable("AgreementRegistration");

                entity.Property(e => e.AgreementRegistrationId).HasColumnName("AgreementRegistrationID");

                entity.Property(e => e.AgreementFeatureId).HasColumnName("AgreementFeatureID");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.ScanUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ScanURL");

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Chưa ký,1 Đã ký ,2 Đang xử lý, 3 Chờ hủy, 4 Đã hủy");
            });

            modelBuilder.Entity<AgreementRegistrationBackup20210119>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AgreementRegistrationBackup20210119");

                entity.Property(e => e.AgreementFeatureId).HasColumnName("AgreementFeatureID");

                entity.Property(e => e.AgreementRegistrationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AgreementRegistrationID");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.ScanUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ScanURL");

                entity.Property(e => e.SignDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AlertAction>(entity =>
            {
                entity.ToTable("ALERT_ACTION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Alertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ALERTDATE");

                entity.Property(e => e.Alertregid).HasColumnName("ALERTREGID");

                entity.Property(e => e.Conditiontype).HasColumnName("CONDITIONTYPE");

                entity.Property(e => e.Conditionvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CONDITIONVALUE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Matchedvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MATCHEDVALUE");

                entity.Property(e => e.Message)
                    .HasMaxLength(255)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.NotifyAction).HasColumnName("NOTIFY_ACTION");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<AlertActionHistory>(entity =>
            {
                entity.ToTable("ALERT_ACTION_HISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Alertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ALERTDATE");

                entity.Property(e => e.Alertregid).HasColumnName("ALERTREGID");

                entity.Property(e => e.Conditiontype).HasColumnName("CONDITIONTYPE");

                entity.Property(e => e.Conditionvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CONDITIONVALUE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Matchedvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MATCHEDVALUE");

                entity.Property(e => e.Message)
                    .HasMaxLength(255)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.NotifyAction).HasColumnName("NOTIFY_ACTION");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<AlertActionHistoryOld>(entity =>
            {
                entity.ToTable("ALERT_ACTION_HISTORY_OLD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AlertDate).HasColumnType("datetime");

                entity.Property(e => e.AlertRegId).HasColumnName("AlertRegID");

                entity.Property(e => e.BuyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Index).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlertActionOld>(entity =>
            {
                entity.ToTable("ALERT_ACTION_OLD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AlertDate).HasColumnType("datetime");

                entity.Property(e => e.AlertRegId).HasColumnName("AlertRegID");

                entity.Property(e => e.BuyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Index).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlertReg>(entity =>
            {
                entity.ToTable("ALERT_REG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveFromDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveToDateTime).HasColumnType("datetime");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxBuyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinSellPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sequence)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlertRegHistory>(entity =>
            {
                entity.ToTable("ALERT_REG_HISTORY");

                entity.HasIndex(e => e.AccountNo, "IX_ALERT_REG_HISTORY_AccountNo");

                entity.HasIndex(e => e.AlertRegId, "IX_ALERT_REG_HISTORY_AlertRegID");

                entity.HasIndex(e => e.CustomerId, "IX_ALERT_REG_HISTORY_CustomerID");

                entity.HasIndex(e => e.EffectiveFromDateTime, "IX_ALERT_REG_HISTORY_EffectiveFromDateTime");

                entity.HasIndex(e => e.EffectiveToDateTime, "IX_ALERT_REG_HISTORY_EffectiveToDateTime");

                entity.HasIndex(e => e.NotifyAction, "IX_ALERT_REG_HISTORY_NotifyAction");

                entity.HasIndex(e => e.Symbol, "IX_ALERT_REG_HISTORY_Symbol");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AlertRegId).HasColumnName("AlertRegID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveFromDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveToDateTime).HasColumnType("datetime");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxBuyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinSellPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditAuthentication>(entity =>
            {
                entity.ToTable("Audit_Authentication");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthenId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cadata)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("CAData");

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoreOrderId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Metadata).HasMaxLength(2000);

                entity.Property(e => e.RefId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RefID");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");
            });

            modelBuilder.Entity<AuditAuthenticationHistory>(entity =>
            {
                entity.ToTable("Audit_Authentication_History");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthenId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cadata)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("CAData");

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoreOrderId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Metadata).HasMaxLength(2000);

                entity.Property(e => e.MovedDate).HasColumnType("datetime");

                entity.Property(e => e.RefId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RefID");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");
            });

            modelBuilder.Entity<BankAccountBackup20170802>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankAccount_Backup_20170802");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(100)
                    .HasColumnName("BANKACCOUNT");

                entity.Property(e => e.Bankaccountid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BANKACCOUNTID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(255)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Bankno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BANKNO");

                entity.Property(e => e.Banktype).HasColumnName("BANKTYPE");

                entity.Property(e => e.Beneficiary)
                    .HasMaxLength(255)
                    .HasColumnName("BENEFICIARY");

                entity.Property(e => e.Branchno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHNO");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .HasColumnName("PROVINCE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Urlpath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URLPATH");
            });

            modelBuilder.Entity<Bankaccount>(entity =>
            {
                entity.ToTable("BANKACCOUNT");

                entity.HasIndex(e => e.Bankaccount1, "IX_BANKACCOUNT_BANKACCOUNT");

                entity.HasIndex(e => e.Customerid, "IX_BANKACCOUNT_CUSTOMERID");

                entity.Property(e => e.Bankaccountid).HasColumnName("BANKACCOUNTID");

                entity.Property(e => e.Bankaccount1)
                    .HasMaxLength(100)
                    .HasColumnName("BANKACCOUNT");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(255)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Bankno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BANKNO");

                entity.Property(e => e.Banktype).HasColumnName("BANKTYPE");

                entity.Property(e => e.Beneficiary)
                    .HasMaxLength(255)
                    .HasColumnName("BENEFICIARY");

                entity.Property(e => e.Branchno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHNO");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Custbanktype)
                    .HasColumnName("CUSTBANKTYPE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .HasColumnName("PROVINCE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Urlpath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URLPATH");
            });

            modelBuilder.Entity<BankaccountBk20170210>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BANKACCOUNT_bk20170210");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(100)
                    .HasColumnName("BANKACCOUNT");

                entity.Property(e => e.Bankaccountid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BANKACCOUNTID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(255)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Bankno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BANKNO");

                entity.Property(e => e.Banktype).HasColumnName("BANKTYPE");

                entity.Property(e => e.Beneficiary)
                    .HasMaxLength(255)
                    .HasColumnName("BENEFICIARY");

                entity.Property(e => e.Branchno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHNO");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .HasColumnName("PROVINCE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Urlpath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URLPATH");
            });

            modelBuilder.Entity<Bankbalanceinfo>(entity =>
            {
                entity.ToTable("BANKBALANCEINFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cashbalance)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("CASHBALANCE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Istransferflag).HasColumnName("ISTRANSFERFLAG");
            });

            modelBuilder.Entity<Banklist>(entity =>
            {
                entity.ToTable("BANKLIST");

                entity.Property(e => e.BankName).HasMaxLength(500);

                entity.Property(e => e.BankNameE)
                    .HasMaxLength(500)
                    .HasColumnName("BankName_E");

                entity.Property(e => e.BankNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcheqcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bankcheqcode");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepositAccount)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaxTradingCash)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("max_trading_cash");

                entity.Property(e => e.MinTradingCash)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("min_trading_cash");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.SecCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SecCodeBranch)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("secCodeBranch");

                entity.Property(e => e.ShortName).HasMaxLength(300);

                entity.Property(e => e.TransferFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WithdrawAccount)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Banklist20160916>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("banklist_20160916");

                entity.Property(e => e.BankName).HasMaxLength(500);

                entity.Property(e => e.BankNameE)
                    .HasMaxLength(500)
                    .HasColumnName("BankName_E");

                entity.Property(e => e.BankNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcheqcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("bankcheqcode");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepositAccount)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaxTradingCash)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("max_trading_cash");

                entity.Property(e => e.MinTradingCash)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("min_trading_cash");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.SecCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SecCodeBranch)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("secCodeBranch");

                entity.Property(e => e.ShortName).HasMaxLength(300);

                entity.Property(e => e.WithdrawAccount)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.Branchid)
                    .IsClustered(false);

                entity.ToTable("BRANCH");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");
            });

            modelBuilder.Entity<Branchnolist>(entity =>
            {
                entity.ToTable("BRANCHNOLIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.BranchNameE)
                    .HasMaxLength(500)
                    .HasColumnName("BranchName_E");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.ShortBranchName).HasMaxLength(300);
            });

            modelBuilder.Entity<Branchnolist20160916>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BRANCHNOLIST_20160916");

                entity.Property(e => e.BankNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.BranchNameE)
                    .HasMaxLength(500)
                    .HasColumnName("BranchName_E");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.ShortBranchName).HasMaxLength(300);
            });

            modelBuilder.Entity<Branchuser>(entity =>
            {
                entity.ToTable("BRANCHUSER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Breakingnews>(entity =>
            {
                entity.ToTable("BREAKINGNEWS");

                entity.Property(e => e.Breakingnewsid).HasColumnName("BREAKINGNEWSID");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Ispublished).HasColumnName("ISPUBLISHED");

                entity.Property(e => e.Languageid).HasColumnName("LANGUAGEID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Publisheddate)
                    .HasColumnType("datetime")
                    .HasColumnName("PUBLISHEDDATE");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<Broker>(entity =>
            {
                entity.HasKey(e => e.Traderid)
                    .HasName("PK_BROKERTRADERID");

                entity.ToTable("BROKER");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Activedate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIVEDATE");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Expiredate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPIREDATE");

                entity.Property(e => e.Identitycard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYCARD");

                entity.Property(e => e.Keyordzone)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("KEYORDZONE");

                entity.Property(e => e.Passconfirmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSCONFIRMCODE");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Pin)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PIN");

                entity.Property(e => e.Pinconfirmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PINCONFIRMCODE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Supervisorid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISORID");

                entity.Property(e => e.Tradergroup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERGROUP");

                entity.Property(e => e.Tradername)
                    .HasMaxLength(100)
                    .HasColumnName("TRADERNAME");

                entity.Property(e => e.Tradertype).HasColumnName("TRADERTYPE");
            });

            modelBuilder.Entity<Brokerchangedlog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("BROKERCHANGEDLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brokerid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BROKERID");

                entity.Property(e => e.Changeinfo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEINFO");

                entity.Property(e => e.Changestatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Changetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGETIME")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Changetype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CHANGETYPE");

                entity.HasOne(d => d.Broker)
                    .WithMany(p => p.Brokerchangedlogs)
                    .HasForeignKey(d => d.Brokerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BROKERCHANGEDLOG_BROKER");
            });

            modelBuilder.Entity<Cashapisequence>(entity =>
            {
                entity.ToTable("CASHAPISEQUENCE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateReff)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cashbalance>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Asofdate })
                    .HasName("PK_CASHBALANCE_1");

                entity.ToTable("CASHBALANCE");

                entity.HasIndex(e => e.Asofdate, "IX_CASHBALANCE_ASOFDATE");

                entity.HasIndex(e => new { e.Accountno2, e.Asofdate, e.TransType1 }, "IX_CASHBALANCE_AccountNo2");

                entity.HasIndex(e => new { e.Asofdate, e.BookHolding, e.Coretype, e.Accountno2 }, "NonClusteredIndex-20190924-113328");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Asofdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ASOFDATE");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accountno2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO2");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.BookHolding)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Buycredit)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("BUYCREDIT");

                entity.Property(e => e.Coretype).HasColumnName("CORETYPE");

                entity.Property(e => e.Dividend)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("DIVIDEND");

                entity.Property(e => e.Overdue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("OVERDUE");

                entity.Property(e => e.TransType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_TYPE1");

                entity.Property(e => e.Wtr)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("WTR");
            });

            modelBuilder.Entity<Cashdueinfo>(entity =>
            {
                entity.ToTable("CASHDUEINFO");

                entity.Property(e => e.Cashdueinfoid).HasColumnName("CASHDUEINFOID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.AmtCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T1");

                entity.Property(e => e.AmtCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T2");

                entity.Property(e => e.AmtCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T3");

                entity.Property(e => e.Available)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AVAILABLE");

                entity.Property(e => e.Overdue)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("OVERDUE");

                entity.Property(e => e.Payment)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PAYMENT");

                entity.Property(e => e.WtrCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T1");

                entity.Property(e => e.WtrCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T2");

                entity.Property(e => e.WtrCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T3");

                entity.Property(e => e.WtsCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T1");

                entity.Property(e => e.WtsCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T2");

                entity.Property(e => e.WtsCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T3");
            });

            modelBuilder.Entity<CashdueinfoTplu>(entity =>
            {
                entity.HasKey(e => e.Cashdueinfoid);

                entity.ToTable("CASHDUEINFO_TPlus");

                entity.Property(e => e.Cashdueinfoid).HasColumnName("CASHDUEINFOID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.AmtCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T1");

                entity.Property(e => e.AmtCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T2");

                entity.Property(e => e.AmtCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T3");

                entity.Property(e => e.Available)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AVAILABLE");

                entity.Property(e => e.Overdue)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("OVERDUE");

                entity.Property(e => e.Payment)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PAYMENT");

                entity.Property(e => e.WtrCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T1");

                entity.Property(e => e.WtrCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T2");

                entity.Property(e => e.WtrCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T3");

                entity.Property(e => e.WtsCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T1");

                entity.Property(e => e.WtsCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T2");

                entity.Property(e => e.WtsCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T3");
            });

            modelBuilder.Entity<CashdueinfoTplusHistory>(entity =>
            {
                entity.HasKey(e => e.Cashdueinfoid);

                entity.ToTable("CASHDUEINFO_TPlus_HISTORY");

                entity.Property(e => e.Cashdueinfoid).HasColumnName("CASHDUEINFOID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.AmtCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T1");

                entity.Property(e => e.AmtCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T2");

                entity.Property(e => e.AmtCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AMT_CASH_T3");

                entity.Property(e => e.Available)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AVAILABLE");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Overdue)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("OVERDUE");

                entity.Property(e => e.Payment)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PAYMENT");

                entity.Property(e => e.WtrCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T1");

                entity.Property(e => e.WtrCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T2");

                entity.Property(e => e.WtrCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_CASH_T3");

                entity.Property(e => e.WtsCashT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T1");

                entity.Property(e => e.WtsCashT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T2");

                entity.Property(e => e.WtsCashT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_CASH_T3");
            });

            modelBuilder.Entity<Cashstatementrequest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("CASHSTATEMENTREQUEST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Fromdate)
                    .HasColumnType("datetime")
                    .HasColumnName("FROMDATE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Processdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESSDATE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Requestdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REQUESTDATE");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Todate)
                    .HasColumnType("datetime")
                    .HasColumnName("TODATE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Cashstatementrequesthistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("CASHSTATEMENTREQUESTHISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Fromdate)
                    .HasColumnType("datetime")
                    .HasColumnName("FROMDATE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Processdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESSDATE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Requestdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REQUESTDATE");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Todate)
                    .HasColumnType("datetime")
                    .HasColumnName("TODATE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Cashtran>(entity =>
            {
                entity.ToTable("CASHTRANS");

                entity.HasIndex(e => e.Accountno2, "IX_CASHTRANS_AccountNo2");

                entity.HasIndex(e => e.Duedate, "IX_CASHTRANS_DueDate");

                entity.HasIndex(e => e.Symbol, "IX_CASHTRANS_SYMBOL");

                entity.HasIndex(e => e.SynDateTime, "IX_CASHTRANS_SYNDATETIME");

                entity.HasIndex(e => e.Transdate, "IX_CASHTRANS_TRANSDATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accountno2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO2");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.ApprDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPR_DATE_TIME");

                entity.Property(e => e.Authid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTHID");

                entity.Property(e => e.BookHolding)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Coretype).HasColumnName("CORETYPE");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Firstremain)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("FIRSTREMAIN");

                entity.Property(e => e.Lastremain)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("LASTREMAIN");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Remain)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("REMAIN");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Remark2)
                    .HasMaxLength(500)
                    .HasColumnName("REMARK2");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.SynDateTime).HasColumnType("datetime");

                entity.Property(e => e.TranDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_DATE_TIME");

                entity.Property(e => e.TransNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_NO");

                entity.Property(e => e.TransType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_TYPE1");

                entity.Property(e => e.TransType2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_TYPE2");

                entity.Property(e => e.Transdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Cashtransfer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("CASHTRANSFER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BANKACCOUNT");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BANKCODE");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchbankname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHBANKNAME");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHCODE");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Createtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Errordesc)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("ERRORDESC");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Feetype).HasColumnName("FEETYPE");

                entity.Property(e => e.Identitycard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYCARD");

                entity.Property(e => e.ImbsContractno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMBS_CONTRACTNO");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.MoneyTransfer).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Movementid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOVEMENTID");

                entity.Property(e => e.PendingStatusId).HasColumnName("PendingStatusID");

                entity.Property(e => e.PreferenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason).HasColumnName("REASON");

                entity.Property(e => e.Receivername)
                    .HasMaxLength(100)
                    .HasColumnName("RECEIVERNAME");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Transferdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERDATE");

                entity.Property(e => e.Transfersource)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFERSOURCE");

                entity.Property(e => e.Transfertype).HasColumnName("TRANSFERTYPE");

                entity.Property(e => e.Transrefer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSREFER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<CashtransferPretest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CASHTRANSFER_PRETEST");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BANKACCOUNT");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchbankname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHBANKNAME");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Feetype).HasColumnName("FEETYPE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Identitycard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYCARD");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Reason).HasColumnName("REASON");

                entity.Property(e => e.Receivername)
                    .HasMaxLength(100)
                    .HasColumnName("RECEIVERNAME");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Transferdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERDATE");

                entity.Property(e => e.Transfertype).HasColumnName("TRANSFERTYPE");

                entity.Property(e => e.Transrefer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSREFER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Cashtransferhistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("CASHTRANSFERHISTORY");

                entity.HasIndex(e => e.Accountno, "IX_CASHTRANSFERHISTORY_ACCOUNTNO");

                entity.HasIndex(e => e.Contractno, "IX_CASHTRANSFERHISTORY_CONTRACTNO");

                entity.HasIndex(e => e.Customerid, "IX_CASHTRANSFERHISTORY_CUSTOMERID");

                entity.HasIndex(e => e.Status, "IX_CASHTRANSFERHISTORY_STATUS");

                entity.HasIndex(e => e.Transferdate, "IX_CASHTRANSFERHISTORY_TRANSFERDATE");

                entity.HasIndex(e => e.Userid, "IX_CASHTRANSFERHISTORY_USERID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BANKACCOUNT");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchbankname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHBANKNAME");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Feetype).HasColumnName("FEETYPE");

                entity.Property(e => e.Identitycard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYCARD");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.PreferenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason).HasColumnName("REASON");

                entity.Property(e => e.Receivername)
                    .HasMaxLength(100)
                    .HasColumnName("RECEIVERNAME");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Transferdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERDATE");

                entity.Property(e => e.Transfertype).HasColumnName("TRANSFERTYPE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Ccinfo>(entity =>
            {
                entity.HasKey(e => e.Ccid);

                entity.ToTable("CCINFO");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CcauthType).HasColumnName("CCAuthType");

                entity.Property(e => e.Ccdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CCDate");

                entity.Property(e => e.CclastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CCLastUpdate");

                entity.Property(e => e.Ccmobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CCMobile");

                entity.Property(e => e.Ccpin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CCPin");

                entity.Property(e => e.Ccstatus)
                    .HasColumnName("CCStatus")
                    .HasComment("Trang thai: 1: Dang hoat dong- 2: Huy");

                entity.Property(e => e.Channel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IvrmobileAuth).HasColumnName("IVRMobileAuth");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyChannel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Changeaccountinfo>(entity =>
            {
                entity.ToTable("CHANGEACCOUNTINFO");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NewContent).HasMaxLength(1000);

                entity.Property(e => e.OldContent).HasMaxLength(1000);

                entity.Property(e => e.Reason).HasMaxLength(1000);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Commission>(entity =>
            {
                entity.ToTable("COMMISSION");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Free agent");

                entity.Property(e => e.BeginDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngay tinh phi hoa hong");

                entity.Property(e => e.BrokerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("MktId");

                entity.Property(e => e.CommDate).HasColumnType("datetime");

                entity.Property(e => e.Commission1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Commission")
                    .HasComment("So tien hoa hong duoc lanh toi thoi diem ComDate");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("CONFIGURATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Key)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KEY");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<ConfigurationAcp>(entity =>
            {
                entity.ToTable("CONFIGURATION_ACP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginVal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndVal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(255);
            });

            modelBuilder.Entity<ConfigurationBackup20210705>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("configuration_Backup20210705");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Key)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KEY");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<ConfigurationBackup20220506>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CONFIGURATION_Backup20220506");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Key)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KEY");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<ConnectionStatus>(entity =>
            {
                entity.ToTable("ConnectionStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InnoTradeGwname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("InnoTradeGWName");
            });

            modelBuilder.Entity<Coo>(entity =>
            {
                entity.ToTable("COO");

                entity.HasIndex(e => e.Account, "IX_COO_Account");

                entity.HasIndex(e => e.CustomerId, "IX_COO_CustomerId");

                entity.HasIndex(e => e.OrderTime, "IX_COO_OrderTime");

                entity.HasIndex(e => e.OrderType, "IX_COO_OrderType");

                entity.HasIndex(e => e.SecSymbol, "IX_COO_SecSymbol");

                entity.HasIndex(e => e.Side, "IX_COO_Side");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelledConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelledTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutedPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MessageType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.RealId).HasColumnName("RealID");

                entity.Property(e => e.ReferId).HasColumnName("ReferID");

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SentTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.TargetCustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");
            });

            modelBuilder.Entity<Coo2orderInfo>(entity =>
            {
                entity.ToTable("COO2OrderInfo");

                entity.HasIndex(e => e.CooId, "IX_COO2OrderInfo_COO_ID");

                entity.HasIndex(e => e.CreatedTime, "IX_COO2OrderInfo_CreatedTime");

                entity.HasIndex(e => e.FisorderId, "IX_COO2OrderInfo_FISOrderID");

                entity.HasIndex(e => e.OrderInfoId, "IX_COO2OrderInfo_OrderInfoID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CooId).HasColumnName("COO_ID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FisorderId).HasColumnName("FISOrderID");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.OrderInfoId).HasColumnName("OrderInfoID");

                entity.Property(e => e.Remark).HasMaxLength(256);
            });

            modelBuilder.Entity<Coo2orderinfohistory>(entity =>
            {
                entity.ToTable("COO2ORDERINFOHISTORY");

                entity.HasIndex(e => e.CooId, "IX_COO2ORDERINFOHISTORY_COO_ID");

                entity.HasIndex(e => e.CreatedTime, "IX_COO2ORDERINFOHISTORY_CreatedTime");

                entity.HasIndex(e => e.FisorderId, "IX_COO2ORDERINFOHISTORY_FISOrderID");

                entity.HasIndex(e => e.OrderInfoId, "IX_COO2ORDERINFOHISTORY_OrderInfoID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CooId).HasColumnName("COO_ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FisorderId).HasColumnName("FISOrderID");

                entity.Property(e => e.OrderInfoId).HasColumnName("OrderInfoID");
            });

            modelBuilder.Entity<CooMptransaction>(entity =>
            {
                entity.ToTable("COO_MPTransactions");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TradeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CooPretest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COO_PRETEST");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelledConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelledTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MessageType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.RealId).HasColumnName("RealID");

                entity.Property(e => e.ReferId).HasColumnName("ReferID");

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SentTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");
            });

            modelBuilder.Entity<CooSt>(entity =>
            {
                entity.ToTable("COO_ST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CooId).HasColumnName("COO_ID");

                entity.Property(e => e.RefPrice).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.StopLossAbs).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.StopLossPer).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.StopLossTriggerPrice).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.TakeProfitAbs).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.TakeProfitPer).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.TakeProfitTriggerPrice).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<CooT>(entity =>
            {
                entity.ToTable("COO_TS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CooId).HasColumnName("COO_ID");
            });

            modelBuilder.Entity<CooTriggerPriceTransaction>(entity =>
            {
                entity.ToTable("COO_TriggerPriceTransaction");

                entity.Property(e => e.CooId).HasColumnName("COO_ID");

                entity.Property(e => e.IsTriggered).HasDefaultValueSql("((0))");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TradeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Coobackup>(entity =>
            {
                entity.ToTable("COOBackup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelledConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelledTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutedPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MessageType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MwaccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MWAccountNo");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.RealId).HasColumnName("RealID");

                entity.Property(e => e.ReferId).HasColumnName("ReferID");

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SentTime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.TargetCustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");
            });

            modelBuilder.Entity<Cooinfo>(entity =>
            {
                entity.ToTable("COOInfo");

                entity.HasIndex(e => e.EffectiveFromDateTime, "IX_COOInfo_EffectiveFromDateTime");

                entity.HasIndex(e => e.EffectiveToDateTime, "IX_COOInfo_EffectiveToDateTime");

                entity.HasIndex(e => e.OrderTime, "IX_COOInfo_OrderTime");

                entity.HasIndex(e => e.OrderType, "IX_COOInfo_OrderType");

                entity.HasIndex(e => e.SecSymbol, "IX_COOInfo_SecSymbol");

                entity.HasIndex(e => e.Side, "IX_COOInfo_Side");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledTime).HasColumnType("datetime");

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ConstraintCoreTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CooType).HasColumnName("COO_Type");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.EffectiveFromDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveToDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecutedPrice).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.IndayExecutedPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LastRunEoth)
                    .HasColumnType("datetime")
                    .HasColumnName("LastRunEOTH");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Price).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SentTime).HasColumnType("datetime");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");
            });

            modelBuilder.Entity<Cooinfohistory>(entity =>
            {
                entity.ToTable("COOINFOHISTORY");

                entity.HasIndex(e => e.Account, "IX_COOINFOHISTORY_Account");

                entity.HasIndex(e => e.EffectiveFromDateTime, "IX_COOINFOHISTORY_EffectiveFromDateTime");

                entity.HasIndex(e => e.EffectiveToDateTime, "IX_COOINFOHISTORY_EffectiveToDateTime");

                entity.HasIndex(e => e.OrderTime, "IX_COOINFOHISTORY_OrderTime");

                entity.HasIndex(e => e.OrderType, "IX_COOINFOHISTORY_OrderType");

                entity.HasIndex(e => e.SecSymbol, "IX_COOINFOHISTORY_SecSymbol");

                entity.HasIndex(e => e.Side, "IX_COOINFOHISTORY_Side");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledTime).HasColumnType("datetime");

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CooType).HasColumnName("COO_Type");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.EffectiveFromDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveToDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecutedPrice).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.LastRunEoth)
                    .HasColumnType("datetime")
                    .HasColumnName("LastRunEOTH");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SentTime).HasColumnType("datetime");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");
            });

            modelBuilder.Entity<Coolog>(entity =>
            {
                entity.ToTable("COOLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CooId).HasColumnName("COO_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Cooorderhistory>(entity =>
            {
                entity.HasKey(e => e.Cooorderhistoryid)
                    .IsClustered(false);

                entity.ToTable("COOORDERHISTORY");

                entity.Property(e => e.Cooorderhistoryid)
                    .ValueGeneratedNever()
                    .HasColumnName("COOORDERHISTORYID");

                entity.Property(e => e.Gtdorderid).HasColumnName("GTDORDERID");

                entity.Property(e => e.Matchedprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("MATCHEDPRICE");

                entity.Property(e => e.Matchedvolume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("MATCHEDVOLUME");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Ordertime)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("ORDERTIME");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Proorderid).HasColumnName("PROORDERID");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Storderid).HasColumnName("STORDERID");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tsorderid).HasColumnName("TSORDERID");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Coreaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNo)
                    .HasName("PK_COREACCOUNT_1");

                entity.ToTable("COREACCOUNT");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ChannelID")
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");
            });

            modelBuilder.Entity<Coredelegate>(entity =>
            {
                entity.ToTable("COREDELEGATE");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ActionType)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.AgentId)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustAcct)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Effdate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MoneyTransFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockTransFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TradeTransFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Coregroup>(entity =>
            {
                entity.ToTable("COREGROUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Effdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFDATE");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Group)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GROUP");

                entity.Property(e => e.Maxloan)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MAXLOAN");
            });

            modelBuilder.Entity<Coreuser>(entity =>
            {
                entity.ToTable("COREUSER");

                entity.Property(e => e.CoreUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<CoreuserCoreaccount>(entity =>
            {
                entity.ToTable("COREUSER_COREACCOUNT");

                entity.Property(e => e.CoreAccountId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Creditlinestocklist>(entity =>
            {
                entity.ToTable("CREDITLINESTOCKLIST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.HasIndex(e => e.Activedate, "IX_CUSTOMER_ACTIVEDATE");

                entity.HasIndex(e => e.Branchid, "IX_CUSTOMER_BRANCHID");

                entity.HasIndex(e => e.Customergroupid, "IX_CUSTOMER_CUSTOMERGROUPID");

                entity.HasIndex(e => e.Customertype, "IX_CUSTOMER_CUSTOMERTYPE");

                entity.HasIndex(e => e.Customerid, "IX_CUSTOMER_CustomerID");

                entity.HasIndex(e => e.Mktid, "IX_CUSTOMER_MKTID");

                entity.HasIndex(e => e.Status, "IX_CUSTOMER_STATUS");

                entity.HasIndex(e => e.Userid, "IX_CUSTOMER_USERID");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Activedate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIVEDATE");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Authtype).HasColumnName("AUTHTYPE");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRTHDAY");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Cardissue)
                    .HasColumnType("datetime")
                    .HasColumnName("CARDISSUE");

                entity.Property(e => e.Cellphone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CELLPHONE");

                entity.Property(e => e.Confirmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMCODE")
                    .HasComment("Code de xac nhan active account");

                entity.Property(e => e.Contactemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTEMAIL");

                entity.Property(e => e.Contactphone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTPHONE");

                entity.Property(e => e.Credittype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CREDITTYPE");

                entity.Property(e => e.Custodian)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSTODIAN");

                entity.Property(e => e.Customergroupid).HasColumnName("CUSTOMERGROUPID");

                entity.Property(e => e.Customername)
                    .HasMaxLength(200)
                    .HasColumnName("CUSTOMERNAME");

                entity.Property(e => e.Customerno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERNO");

                entity.Property(e => e.Customertype).HasColumnName("CUSTOMERTYPE");

                entity.Property(e => e.Defaultaccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULTACCOUNT");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EpEnable).HasColumnName("EP_Enable");

                entity.Property(e => e.EpFirstLogon).HasColumnName("EP_FirstLogon");

                entity.Property(e => e.EpPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EP_Password");

                entity.Property(e => e.Identitycard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYCARD");

                entity.Property(e => e.Isdefault)
                    .HasColumnName("ISDEFAULT")
                    .HasComment("Xac dinh tai khoan mac dinh cho ContactPhone");

                entity.Property(e => e.Mktid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MKTID");

                entity.Property(e => e.Modificationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFICATIONDATE");

                entity.Property(e => e.ModifiedDatePass).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDatePin).HasColumnType("datetime");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(255)
                    .HasColumnName("NATIONALITY");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(255)
                    .HasColumnName("OCCUPATION");

                entity.Property(e => e.Otp)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("OTP");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Paymenttype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTTYPE");

                entity.Property(e => e.Pcflag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PCFLAG");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Pickaccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PICKACCOUNT");

                entity.Property(e => e.Pin)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PIN");

                entity.Property(e => e.Pinconfirmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PINCONFIRMCODE");

                entity.Property(e => e.Placeissue)
                    .HasMaxLength(255)
                    .HasColumnName("PLACEISSUE");

                entity.Property(e => e.Remark).HasColumnName("REMARK");

                entity.Property(e => e.Repeatpass).HasColumnName("REPEATPASS");

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SEX");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Binh thuong 0; bi khoa/ tam ngung GD do broker 1; Bi khoa do dang nhap sai pass 2; Bi tam ngung gd do nhap sai ma pin 3");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Totalpoint)
                    .HasColumnType("decimal(26, 2)")
                    .HasColumnName("TOTALPOINT");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<CustomerAuthen>(entity =>
            {
                entity.ToTable("Customer_Authen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthenId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerBranch>(entity =>
            {
                entity.ToTable("CUSTOMER_BRANCH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.ToTable("CUSTOMER_CONTACTS");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.Skype)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Yahoo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMarketAlert>(entity =>
            {
                entity.ToTable("CustomerMarketAlert");

                entity.Property(e => e.AlertSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PointGreaterThan).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PointLessThan).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerNotifySetting>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ServiceCode })
                    .HasName("PK__Customer__3EAFB394E5FD9365");

                entity.ToTable("CustomerNotifySetting");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customerchangedlog>(entity =>
            {
                entity.HasKey(e => e.Changeid)
                    .IsClustered(false);

                entity.ToTable("CUSTOMERCHANGEDLOG");

                entity.Property(e => e.Changeid).HasColumnName("CHANGEID");

                entity.Property(e => e.Changeinfo)
                    .HasMaxLength(1024)
                    .HasColumnName("CHANGEINFO");

                entity.Property(e => e.Changeperson)
                    .HasMaxLength(20)
                    .HasColumnName("CHANGEPERSON");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Changetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGETIME");

                entity.Property(e => e.Changetype).HasColumnName("CHANGETYPE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Isuser).HasColumnName("ISUSER");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Customerchangedloghistory>(entity =>
            {
                entity.HasKey(e => e.Changeid)
                    .IsClustered(false);

                entity.ToTable("CUSTOMERCHANGEDLOGHISTORY");

                entity.Property(e => e.Changeid).HasColumnName("CHANGEID");

                entity.Property(e => e.Changeinfo)
                    .HasMaxLength(1024)
                    .HasColumnName("CHANGEINFO");

                entity.Property(e => e.Changeperson)
                    .HasMaxLength(20)
                    .HasColumnName("CHANGEPERSON");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Changetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGETIME");

                entity.Property(e => e.Changetype).HasColumnName("CHANGETYPE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Isuser).HasColumnName("ISUSER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Customeremail>(entity =>
            {
                entity.ToTable("CUSTOMEREMAIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCc).HasColumnName("IsCC");

                entity.Property(e => e.IsSms).HasColumnName("IsSMS");
            });

            modelBuilder.Entity<Customergroup>(entity =>
            {
                entity.ToTable("CUSTOMERGROUP");

                entity.Property(e => e.Customergroupid).HasColumnName("CUSTOMERGROUPID");

                entity.Property(e => e.Accountype).HasColumnName("ACCOUNTYPE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Level).HasColumnName("LEVEL");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Customerpermission>(entity =>
            {
                entity.ToTable("CUSTOMERPERMISSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ChannelID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");
            });

            modelBuilder.Entity<Customerpermissiont>(entity =>
            {
                entity.ToTable("CUSTOMERPERMISSIONT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Customerphone>(entity =>
            {
                entity.ToTable("CUSTOMERPHONE");

                entity.HasIndex(e => e.Phone, "IX_CUSTOMEREMAIL_PHONE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.IsCc).HasColumnName("IsCC");

                entity.Property(e => e.IsSms).HasColumnName("IsSMS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dealhistory>(entity =>
            {
                entity.HasKey(e => e.Dealhistoryid)
                    .IsClustered(false);

                entity.ToTable("DEALHISTORY");

                entity.HasIndex(e => e.Dealdate, "IX_DEALHISTORY_DEALDATE");

                entity.HasIndex(e => e.Orderno, "IX_DEALHISTORY_ORDERNO");

                entity.HasIndex(e => e.Side, "IX_DEALHISTORY_SIDE");

                entity.HasIndex(e => e.Symbol, "IX_DEALHISTORY_SYMBOL");

                entity.Property(e => e.Dealhistoryid).HasColumnName("DEALHISTORYID");

                entity.Property(e => e.Acctype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTYPE");

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD");

                entity.Property(e => e.Brokerno).HasColumnName("BROKERNO");

                entity.Property(e => e.Cancelflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELFLAG");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Dealdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALDATE");

                entity.Property(e => e.Dealprice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DEALPRICE");

                entity.Property(e => e.Dealtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALTIME");

                entity.Property(e => e.Dealvolume)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("DEALVOLUME");

                entity.Property(e => e.Inserttime)
                    .HasColumnType("datetime")
                    .HasColumnName("INSERTTIME");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno).HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sumcomm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMCOMM");

                entity.Property(e => e.Sumvat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMVAT");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG");
            });

            modelBuilder.Entity<Dealhistory3d>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEALHISTORY_3D");

                entity.Property(e => e.Acctype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTYPE");

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD");

                entity.Property(e => e.Brokerno).HasColumnName("BROKERNO");

                entity.Property(e => e.Cancelflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELFLAG");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Dealdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALDATE");

                entity.Property(e => e.Dealhistoryid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DEALHISTORYID");

                entity.Property(e => e.Dealprice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DEALPRICE");

                entity.Property(e => e.Dealtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALTIME");

                entity.Property(e => e.Dealvolume)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("DEALVOLUME");

                entity.Property(e => e.Inserttime)
                    .HasColumnType("datetime")
                    .HasColumnName("INSERTTIME");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno).HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sumcomm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMCOMM");

                entity.Property(e => e.Sumvat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMVAT");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG");
            });

            modelBuilder.Entity<DealhistoryBackup20191016>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEALHISTORY_backup20191016");

                entity.Property(e => e.Acctype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTYPE");

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD");

                entity.Property(e => e.Brokerno).HasColumnName("BROKERNO");

                entity.Property(e => e.Cancelflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELFLAG");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Dealdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALDATE");

                entity.Property(e => e.Dealhistoryid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DEALHISTORYID");

                entity.Property(e => e.Dealprice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DEALPRICE");

                entity.Property(e => e.Dealtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALTIME");

                entity.Property(e => e.Dealvolume)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("DEALVOLUME");

                entity.Property(e => e.Inserttime)
                    .HasColumnType("datetime")
                    .HasColumnName("INSERTTIME");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno).HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sumcomm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMCOMM");

                entity.Property(e => e.Sumvat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMVAT");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG");
            });

            modelBuilder.Entity<Dealhistorybackup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DEALHISTORYBACKUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acctype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTYPE");

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD");

                entity.Property(e => e.Brokerno).HasColumnName("BROKERNO");

                entity.Property(e => e.Cancelflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELFLAG");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Dealdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALDATE");

                entity.Property(e => e.Dealprice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DEALPRICE");

                entity.Property(e => e.Dealtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALTIME");

                entity.Property(e => e.Dealvolume)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("DEALVOLUME");

                entity.Property(e => e.Inserttime)
                    .HasColumnType("datetime")
                    .HasColumnName("INSERTTIME");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno).HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sumcomm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMCOMM");

                entity.Property(e => e.Sumvat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SUMVAT");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG");
            });

            modelBuilder.Entity<Dealinfo>(entity =>
            {
                entity.ToTable("DEALINFO");

                entity.HasIndex(e => e.DealDate, "IX_DEALINFO_DealDate");

                entity.HasIndex(e => e.OrderNo, "IX_DEALINFO_OrderNo");

                entity.HasIndex(e => e.Symbol, "IX_DEALINFO_SYMBOL");

                entity.Property(e => e.DealInfoId).HasColumnName("DealInfoID");

                entity.Property(e => e.AccType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DealDate).HasMaxLength(8);

                entity.Property(e => e.DealPrice).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.DealTime).HasMaxLength(6);

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.PutThoughFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sumcomm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SUMCOMM");

                entity.Property(e => e.Sumvat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SUMVAT");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DealinfoPretest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEALINFO_PRETEST");

                entity.Property(e => e.AccType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DealDate).HasMaxLength(8);

                entity.Property(e => e.DealInfoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DealInfoID");

                entity.Property(e => e.DealPrice).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.DealTime).HasMaxLength(6);

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.PutThoughFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sumcomm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SUMCOMM");

                entity.Property(e => e.Sumvat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SUMVAT");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dealinfobackup>(entity =>
            {
                entity.HasKey(e => e.DealInfoId)
                    .HasName("PK_DealInfoBackup");

                entity.ToTable("DEALINFOBACKUP");

                entity.Property(e => e.DealInfoId).HasColumnName("DealInfoID");

                entity.Property(e => e.AccType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DealDate).HasMaxLength(8);

                entity.Property(e => e.DealPrice).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.DealTime).HasMaxLength(6);

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.PutThoughFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sumcomm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SUMCOMM");

                entity.Property(e => e.Sumvat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SUMVAT");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DelegatePermissionWhiteList>(entity =>
            {
                entity.ToTable("DelegatePermission_WhiteList");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);
            });

            modelBuilder.Entity<Delegatepermission>(entity =>
            {
                entity.HasKey(e => new { e.AccountNo, e.AgentId, e.Permission })
                    .HasName("PK_DELEGATEPERMISSION_1");

                entity.ToTable("DELEGATEPERMISSION");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DelegatepermissionTemp>(entity =>
            {
                entity.HasKey(e => new { e.AccountNo, e.AgentId, e.Permission });

                entity.ToTable("DELEGATEPERMISSION_TEMP");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DerivativesInfo>(entity =>
            {
                entity.HasKey(e => e.DiId)
                    .HasName("PK__DERIVATI__03ED35FC6F3637D7");

                entity.ToTable("DERIVATIVES_INFO");

                entity.Property(e => e.DiId).HasColumnName("DI_ID");

                entity.Property(e => e.BoardCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FirstTradingDate).HasColumnType("datetime");

                entity.Property(e => e.LastTradingDate).HasColumnType("datetime");

                entity.Property(e => e.ListingStatus)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE");

                entity.Property(e => e.NmBuyForeignQtty).HasColumnName("NM_BuyForeignQtty");

                entity.Property(e => e.NmBuyForeignValue).HasColumnName("NM_BuyForeignValue");

                entity.Property(e => e.NmSellForeignQtty).HasColumnName("NM_SellForeignQtty");

                entity.Property(e => e.NmSellForeignValue).HasColumnName("NM_SellForeignValue");

                entity.Property(e => e.NmTotalTradedQtty).HasColumnName("NM_TotalTradedQtty");

                entity.Property(e => e.NmTotalTradedValue).HasColumnName("NM_TotalTradedValue");

                entity.Property(e => e.PtBuyForeignQtty).HasColumnName("PT_BuyForeignQtty");

                entity.Property(e => e.PtBuyForeignValue).HasColumnName("PT_BuyForeignValue");

                entity.Property(e => e.PtMatchPrice).HasColumnName("PT_MatchPrice");

                entity.Property(e => e.PtMatchQtty).HasColumnName("PT_MatchQtty");

                entity.Property(e => e.PtSellForeignQtty).HasColumnName("PT_SellForeignQtty");

                entity.Property(e => e.PtSellForeignValue).HasColumnName("PT_SellForeignValue");

                entity.Property(e => e.PtTotalTradedQtty).HasColumnName("PT_TotalTradedQtty");

                entity.Property(e => e.PtTotalTradedValue).HasColumnName("PT_TotalTradedValue");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.SecurityTradingStatus)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SymbolId).HasColumnName("SymbolID");

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.Property(e => e.TradeSesStatus)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TradingSessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("TradingSessionID");

                entity.Property(e => e.Tradingdate).HasColumnType("datetime");

                entity.Property(e => e.Underlying)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dividendcash>(entity =>
            {
                entity.ToTable("DIVIDENDCASH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Amt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMT");

                entity.Property(e => e.Effdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFDATE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Refdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REFDATE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sharecode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SHARECODE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Dividendstock>(entity =>
            {
                entity.ToTable("DIVIDENDSTOCK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Newvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NEWVALUE");

                entity.Property(e => e.Oldvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OLDVALUE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(255)
                    .HasColumnName("PURPOSE");

                entity.Property(e => e.Refdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REFDATE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Roundup)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ROUNDUP");

                entity.Property(e => e.Roundupflag)
                    .HasMaxLength(1)
                    .HasColumnName("ROUNDUPFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Sharecode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SHARECODE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");

                entity.Property(e => e.Xdate)
                    .HasColumnType("datetime")
                    .HasColumnName("XDATE");

                entity.Property(e => e.Xtype)
                    .HasMaxLength(1)
                    .HasColumnName("XTYPE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Emaillog>(entity =>
            {
                entity.ToTable("EMAILLOG");

                entity.Property(e => e.Emaillogid).HasColumnName("EMAILLOGID");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sent2email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SENT2EMAIL");

                entity.Property(e => e.Senttime)
                    .HasColumnType("datetime")
                    .HasColumnName("SENTTIME");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("SUBJECT");

                entity.Property(e => e.Userid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<EodProcessLog>(entity =>
            {
                entity.ToTable("EodProcessLog");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.FullMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.Table)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exceptionstock>(entity =>
            {
                entity.ToTable("EXCEPTIONSTOCK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Market).HasMaxLength(20);

                entity.Property(e => e.StockSymbol).HasColumnType("ntext");
            });

            modelBuilder.Entity<FosCoo>(entity =>
            {
                entity.ToTable("FOS_COO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Allowshow).HasColumnName("ALLOWSHOW");

                entity.Property(e => e.Auctionorder)
                    .HasColumnName("AUCTIONORDER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancellederrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CANCELLEDERRORREASON");

                entity.Property(e => e.Cancelledrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus)
                    .HasColumnName("CANCELSTATUS")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changeerrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CHANGEERRORREASON");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changesourceid).HasColumnName("CHANGESOURCEID");

                entity.Property(e => e.Changestatus)
                    .HasColumnName("CHANGESTATUS")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Changetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGETIME");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CooorderId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("COOOrderID");

                entity.Property(e => e.CoreOrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Coreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREORDERID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Currency)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.EffectiveTime).HasColumnType("datetime");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE");

                entity.Property(e => e.ExchangeSessionid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE_SESSIONID");

                entity.Property(e => e.Executedprice).HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXECUTEDTIME");

                entity.Property(e => e.Executedvolume).HasColumnName("EXECUTEDVOLUME");

                entity.Property(e => e.Isnew)
                    .HasColumnName("ISNEW")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LossStep)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Minvolume).HasColumnName("MINVOLUME");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifytime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFYTIME");

                entity.Property(e => e.Numofexecution).HasColumnName("NUMOFEXECUTION");

                entity.Property(e => e.OrderType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orderrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("ORDERRORREASON");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE");

                entity.Property(e => e.Orderstatus)
                    .HasColumnName("ORDERSTATUS")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Ordertime)
                    .HasColumnType("datetime")
                    .HasColumnName("ORDERTIME");

                entity.Property(e => e.Ordrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ORDREJREASON");

                entity.Property(e => e.Orgordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORGORDERSOURCE");

                entity.Property(e => e.PegLimitType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PegMoveType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PegOffsetType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PegOffsetValue)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT");

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POSITION")
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.ProfitStep)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag).HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Realid)
                    .HasColumnName("REALID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Senttime)
                    .HasColumnType("datetime")
                    .HasColumnName("SENTTIME");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE");

                entity.Property(e => e.Sourceid)
                    .HasColumnName("SOURCEID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.StopOrderType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.StopPrice4Bb)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("StopPrice4BB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StopStep)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StopToler)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.Targetcustomerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TARGETCUSTOMERID");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.Tradeby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRADEBY");

                entity.Property(e => e.Tradebyvalue).HasColumnName("TRADEBYVALUE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.TriggerPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TriggerPriceDirection)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<FosCoobackup>(entity =>
            {
                entity.ToTable("FOS_COOBackup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Allowshow).HasColumnName("ALLOWSHOW");

                entity.Property(e => e.Auctionorder)
                    .HasColumnName("AUCTIONORDER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancellederrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CANCELLEDERRORREASON");

                entity.Property(e => e.Cancelledrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus)
                    .HasColumnName("CANCELSTATUS")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changeerrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CHANGEERRORREASON");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changesourceid).HasColumnName("CHANGESOURCEID");

                entity.Property(e => e.Changestatus)
                    .HasColumnName("CHANGESTATUS")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Changetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGETIME");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CooorderId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("COOOrderID");

                entity.Property(e => e.CoreOrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Coreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREORDERID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Currency)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.EffectiveTime).HasColumnType("datetime");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE");

                entity.Property(e => e.ExchangeSessionid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE_SESSIONID");

                entity.Property(e => e.Executedprice).HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXECUTEDTIME");

                entity.Property(e => e.Executedvolume).HasColumnName("EXECUTEDVOLUME");

                entity.Property(e => e.Isnew)
                    .HasColumnName("ISNEW")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LossStep)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Minvolume).HasColumnName("MINVOLUME");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifytime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFYTIME");

                entity.Property(e => e.Movedate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOVEDATE");

                entity.Property(e => e.Numofexecution).HasColumnName("NUMOFEXECUTION");

                entity.Property(e => e.OrderType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orderrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("ORDERRORREASON");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE");

                entity.Property(e => e.Orderstatus)
                    .HasColumnName("ORDERSTATUS")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Ordertime)
                    .HasColumnType("datetime")
                    .HasColumnName("ORDERTIME");

                entity.Property(e => e.Ordrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ORDREJREASON");

                entity.Property(e => e.Orgid).HasColumnName("ORGID");

                entity.Property(e => e.Orgordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORGORDERSOURCE");

                entity.Property(e => e.PegLimitType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PegMoveType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PegOffsetType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PegOffsetValue)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT");

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POSITION")
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.ProfitStep)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag).HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Realid)
                    .HasColumnName("REALID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Senttime)
                    .HasColumnType("datetime")
                    .HasColumnName("SENTTIME");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE");

                entity.Property(e => e.Sourceid)
                    .HasColumnName("SOURCEID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.StopOrderType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.StopPrice4Bb)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("StopPrice4BB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StopStep)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StopToler)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.Targetcustomerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TARGETCUSTOMERID");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.Tradeby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRADEBY");

                entity.Property(e => e.Tradebyvalue).HasColumnName("TRADEBYVALUE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.TriggerPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TriggerPriceDirection)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<FosDealinfo>(entity =>
            {
                entity.ToTable("FOS_DEALINFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coredealid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREDEALID");

                entity.Property(e => e.Coreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREORDERID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Executedprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXECUTEDTIME");

                entity.Property(e => e.Executedvolume).HasColumnName("EXECUTEDVOLUME");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifytime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFYTIME");

                entity.Property(e => e.Orgcoreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ORGCOREORDERID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            });

            modelBuilder.Entity<FosDealinfobackup>(entity =>
            {
                entity.ToTable("FOS_DEALINFOBACKUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Backupby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("BACKUPBY");

                entity.Property(e => e.Backuptime)
                    .HasColumnType("datetime")
                    .HasColumnName("BACKUPTIME");

                entity.Property(e => e.Coredealid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREDEALID");

                entity.Property(e => e.Coreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREORDERID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Executedprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXECUTEDTIME");

                entity.Property(e => e.Executedvolume).HasColumnName("EXECUTEDVOLUME");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifytime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFYTIME");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.Orgcoreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ORGCOREORDERID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            });

            modelBuilder.Entity<FosOrderinfo>(entity =>
            {
                entity.ToTable("FOS_ORDERINFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Allowshow).HasColumnName("ALLOWSHOW");

                entity.Property(e => e.Auctionorder).HasColumnName("AUCTIONORDER");

                entity.Property(e => e.Cancellederrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CANCELLEDERRORREASON");

                entity.Property(e => e.Cancelledrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus).HasColumnName("CANCELSTATUS");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changeerrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CHANGEERRORREASON");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changesourceid).HasColumnName("CHANGESOURCEID");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Changetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGETIME");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CooorderId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("COOOrderID");

                entity.Property(e => e.CooparentId).HasColumnName("COOParentID");

                entity.Property(e => e.CoreOrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Coreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREORDERID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Currency)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Customerno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERNO");

                entity.Property(e => e.Effectivetime)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFECTIVETIME");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE");

                entity.Property(e => e.ExchangeSessionid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE_SESSIONID");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Executedprice).HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXECUTEDTIME");

                entity.Property(e => e.Executedvolume).HasColumnName("EXECUTEDVOLUME");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.LossStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Minvolume).HasColumnName("MINVOLUME");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifytime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFYTIME");

                entity.Property(e => e.Numofexecution).HasColumnName("NUMOFEXECUTION");

                entity.Property(e => e.Orderrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("ORDERRORREASON");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE");

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ORDREJREASON");

                entity.Property(e => e.Orgcoreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ORGCOREORDERID");

                entity.Property(e => e.Orgordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORGORDERSOURCE");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");

                entity.Property(e => e.Parentreforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("PARENTREFORDERID");

                entity.Property(e => e.PegOffsetValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Peglimittype).HasColumnName("PEGLIMITTYPE");

                entity.Property(e => e.Pegmovetype).HasColumnName("PEGMOVETYPE");

                entity.Property(e => e.Pegoffsettype)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("PEGOFFSETTYPE");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT");

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POSITION");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.ProfitStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag).HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.StopPrice4Bb)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("StopPrice4BB");

                entity.Property(e => e.StopStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StopToler).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Stopordertype).HasColumnName("STOPORDERTYPE");

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.Targetcustomerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TARGETCUSTOMERID");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.Tradeby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRADEBY");

                entity.Property(e => e.Tradebyvalue).HasColumnName("TRADEBYVALUE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Transtime)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.TriggerPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TriggerPriceDirection)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<FosOrderinfobackup>(entity =>
            {
                entity.ToTable("FOS_ORDERINFOBACKUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Allowshow).HasColumnName("ALLOWSHOW");

                entity.Property(e => e.Auctionorder).HasColumnName("AUCTIONORDER");

                entity.Property(e => e.Backupby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("BACKUPBY");

                entity.Property(e => e.Backuptime)
                    .HasColumnType("datetime")
                    .HasColumnName("BACKUPTIME");

                entity.Property(e => e.Cancellederrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CANCELLEDERRORREASON");

                entity.Property(e => e.Cancelledrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus).HasColumnName("CANCELSTATUS");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changeerrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("CHANGEERRORREASON");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changesourceid).HasColumnName("CHANGESOURCEID");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Changetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGETIME");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CooorderId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("COOOrderID");

                entity.Property(e => e.CooparentId).HasColumnName("COOParentID");

                entity.Property(e => e.CoreOrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Coreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COREORDERID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATETIME");

                entity.Property(e => e.Currency)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Customerno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERNO");

                entity.Property(e => e.EffectiveTime).HasColumnType("datetime");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE");

                entity.Property(e => e.ExchangeSessionid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXCHANGE_SESSIONID");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Executedprice).HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("EXECUTEDTIME");

                entity.Property(e => e.Executedvolume).HasColumnName("EXECUTEDVOLUME");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.LossStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Minvolume).HasColumnName("MINVOLUME");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MODIFYBY");

                entity.Property(e => e.Modifytime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFYTIME");

                entity.Property(e => e.Numofexecution).HasColumnName("NUMOFEXECUTION");

                entity.Property(e => e.Orderrorreason)
                    .HasMaxLength(512)
                    .HasColumnName("ORDERRORREASON");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE");

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ORDREJREASON");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.Orgcoreorderid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ORGCOREORDERID");

                entity.Property(e => e.Orgordersource)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORGORDERSOURCE");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");

                entity.Property(e => e.Parentreforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("PARENTREFORDERID");

                entity.Property(e => e.PegOffsetValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT");

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POSITION");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.ProfitStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag).HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.StopPrice4Bb)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("StopPrice4BB");

                entity.Property(e => e.StopStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StopToler).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.Targetcustomerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TARGETCUSTOMERID");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.Tradeby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRADEBY");

                entity.Property(e => e.Tradebyvalue).HasColumnName("TRADEBYVALUE");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Transtime)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.TriggerPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TriggerPriceDirection)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Fullcoo2orderinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FULLCOO2ORDERINFO");

                entity.Property(e => e.CooId).HasColumnName("COO_ID");

                entity.Property(e => e.Createdtime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDTIME");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");
            });

            modelBuilder.Entity<Fullcooinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FULLCOOINFO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.ToTable("FUNCTIONS");

                entity.Property(e => e.Functionid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTIONID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Functionname)
                    .HasMaxLength(250)
                    .HasColumnName("FUNCTIONNAME");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Moduleid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MODULEID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Functions)
                    .HasForeignKey(d => d.Moduleid)
                    .HasConstraintName("FK_FUNCTIONS_MODULES");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasKey(e => e.Holidayid)
                    .IsClustered(false);

                entity.ToTable("HOLIDAY");

                entity.Property(e => e.Holidayid).HasColumnName("HOLIDAYID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Holiday1)
                    .HasColumnType("datetime")
                    .HasColumnName("HOLIDAY");

                entity.Property(e => e.Repeat).HasColumnName("REPEAT");
            });

            modelBuilder.Entity<HolidayHistory>(entity =>
            {
                entity.HasKey(e => e.Holidayid)
                    .HasName("PK__HOLIDAY___5D64539576681873");

                entity.ToTable("HOLIDAY_HISTORY");

                entity.Property(e => e.Holidayid).HasColumnName("HOLIDAYID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Holiday)
                    .HasColumnType("datetime")
                    .HasColumnName("HOLIDAY");

                entity.Property(e => e.Repeat).HasColumnName("REPEAT");
            });

            modelBuilder.Entity<Insertstatuslog>(entity =>
            {
                entity.HasKey(e => e.Instlogid)
                    .HasName("PK_InsertStatusLog");

                entity.ToTable("INSERTSTATUSLOG");

                entity.Property(e => e.Instlogid).HasColumnName("INSTLOGID");

                entity.Property(e => e.Begininstdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BEGININSTDATE");

                entity.Property(e => e.Currentnumofrecord).HasColumnName("CURRENTNUMOFRECORD");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Endinstdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDINSTDATE");

                entity.Property(e => e.Numofrecord).HasColumnName("NUMOFRECORD");

                entity.Property(e => e.Statuscode)
                    .HasColumnName("STATUSCODE")
                    .HasComment("0/1/2/3");

                entity.Property(e => e.Statusmessage)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STATUSMESSAGE");

                entity.Property(e => e.Statusstate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUSSTATE")
                    .HasComment("Started/Updating/Failed/Finished");

                entity.Property(e => e.Table)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TABLE");
            });

            modelBuilder.Entity<Internalaccount>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.InternalAccountNo });

                entity.ToTable("INTERNALACCOUNT");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternalAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InternalAddress)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InternalCustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InternalCustomerName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InternalCustomerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InternalIdentityCard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InternalScanUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("InternalScanURL");

                entity.Property(e => e.ModifiedDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Reason).HasMaxLength(255);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("LANGUAGE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<LoanMarginInterest>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("LoanMarginInterest");

                entity.Property(e => e.AutoId).HasColumnName("AutoID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DebtAmt)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("DebtAMT");

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InterestAmt)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("InterestAMT");

                entity.Property(e => e.InterestTotalAmt)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("InterestTotalAMT");

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SyncDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Loginfo>(entity =>
            {
                entity.ToTable("LOGINFO");

                entity.HasIndex(e => e.Actiontime, "IX_LOGINFO_ACTIONTIME");

                entity.HasIndex(e => e.Actiontype, "IX_LOGINFO_ACTIONTYPE");

                entity.HasIndex(e => e.Customerid, "IX_LOGINFO_CUSTOMERID");

                entity.HasIndex(e => e.Userid, "IX_LOGINFO_USERID");

                entity.Property(e => e.Loginfoid).HasColumnName("LOGINFOID");

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME")
                    .HasComment("");

                entity.Property(e => e.Actiontype)
                    .HasColumnName("ACTIONTYPE")
                    .HasComment("USER_LOGON = 1,\r\nUSER_LOGOUT = 2,\r\nCUSTOMER_LOGON = 3,\r\nCUSTOMER_LOGOUT = 4,\r\nNEW_CUSTOMER = 5,\r\nDISABLE_CUSTOMER = 6,\r\nDELETE_CUSTOMER = 7,\r\nCHANGE_ETEMAIL = 8,\r\nCHANGE_CCMOBILE = 9,\r\nCHANGE_BANK_ACCOUNT = 10,\r\nCHANGE_PASSWORD = 11,\r\nFORGOT_PASSWORD = 12,\r\nSYNC_TOKEN = 13,\r\nAGENT_NEW = 14,\r\nAGENT_ADD_CUST = 15,\r\nAGENT_CHANGE = 16,\r\nAGENT_REM_CUST = 17,\r\nAGENT_CHANGE_RIGHT  =18,\r\nTOKEN2PIN = 19,\r\nPIN2TOKEN =20,\r\nCHANGE_PIN = 21,\r\nCHANGE_CONFIG = 22");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE");

                entity.Property(e => e.Newinfo).HasColumnName("NEWINFO");

                entity.Property(e => e.Oldinfo).HasColumnName("OLDINFO");

                entity.Property(e => e.Remark).HasColumnName("REMARK");

                entity.Property(e => e.Userid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Loginfohistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGINFOHISTORY");

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Actiontype).HasColumnName("ACTIONTYPE");

                entity.Property(e => e.Agentid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AGENTID");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Loginfoid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGINFOID");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE");

                entity.Property(e => e.Newinfo).HasColumnName("NEWINFO");

                entity.Property(e => e.Oldinfo).HasColumnName("OLDINFO");

                entity.Property(e => e.Remark).HasColumnName("REMARK");

                entity.Property(e => e.Userid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Loginlog>(entity =>
            {
                entity.HasKey(e => e.Loginhistoryid)
                    .IsClustered(false);

                entity.ToTable("LOGINLOG");

                entity.HasIndex(e => e.Customerid, "IX_LOGINLOG_CUSTOMERID");

                entity.HasIndex(e => e.Channel, "IX_LOGINLOG_Channel");

                entity.HasIndex(e => e.Logindate, "IX_LOGINLOG_LOGINDATE");

                entity.HasIndex(e => e.Logoutdate, "IX_LOGINLOG_LOGOUTDATE");

                entity.HasIndex(e => e.Status, "IX_LOGINLOG_STATUS");

                entity.Property(e => e.Loginhistoryid).HasColumnName("LOGINHISTORYID");

                entity.Property(e => e.Channel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Logindate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGINDATE");

                entity.Property(e => e.Logoutdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGOUTDATE");

                entity.Property(e => e.Metadata).HasMaxLength(2000);

                entity.Property(e => e.Remark)
                    .HasMaxLength(300)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Loginloghistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGINLOGHISTORY");

                entity.Property(e => e.Channel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Logindate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGINDATE");

                entity.Property(e => e.Loginhistoryid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGINHISTORYID");

                entity.Property(e => e.Logoutdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGOUTDATE");

                entity.Property(e => e.Metadata).HasMaxLength(2000);

                entity.Property(e => e.Remark)
                    .HasMaxLength(300)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sessionid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SESSIONID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Logtransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("LOGTRANSACTIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Executedprice).HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedvol).HasColumnName("EXECUTEDVOL");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Oldprice).HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordertype).HasColumnName("ORDERTYPE");

                entity.Property(e => e.Ordrejreason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDREJREASON");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.Tradetime)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADETIME");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Logtransactionshistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("LOGTRANSACTIONSHISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Executedprice).HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedvol).HasColumnName("EXECUTEDVOL");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Market)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Oldprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordertype).HasColumnName("ORDERTYPE");

                entity.Property(e => e.Ordrejreason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDREJREASON");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(30, 13)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.Tradetime)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADETIME");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Loyaltyrewardspoint>(entity =>
            {
                entity.HasKey(e => e.Loyaltyrewardspointid)
                    .IsClustered(false);

                entity.ToTable("LOYALTYREWARDSPOINT");

                entity.Property(e => e.Loyaltyrewardspointid)
                    .ValueGeneratedNever()
                    .HasColumnName("LOYALTYREWARDSPOINTID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Brokerid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BROKERID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Newpoint)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("NEWPOINT");

                entity.Property(e => e.Oldpoint)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("OLDPOINT");
            });

            modelBuilder.Entity<Marginstocklist>(entity =>
            {
                entity.ToTable("MARGINSTOCKLIST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Canbuy)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CANBUY");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Ratio)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RATIO");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<MessageSequence>(entity =>
            {
                entity.ToTable("MESSAGE_SEQUENCE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.HasKey(e => e.Moduleid)
                    .HasName("PK_GROUPSYSTEM")
                    .IsClustered(false);

                entity.ToTable("MODULE");

                entity.Property(e => e.Moduleid).HasColumnName("MODULEID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");
            });

            modelBuilder.Entity<Module1>(entity =>
            {
                entity.HasKey(e => e.Moduleid);

                entity.ToTable("MODULES");

                entity.Property(e => e.Moduleid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MODULEID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Modulename)
                    .HasMaxLength(250)
                    .HasColumnName("MODULENAME");
            });

            modelBuilder.Entity<NearestWorkingDate>(entity =>
            {
                entity.HasKey(e => e.Market);

                entity.Property(e => e.Market).HasMaxLength(1);

                entity.Property(e => e.T).HasColumnType("datetime");

                entity.Property(e => e.T1).HasColumnType("datetime");

                entity.Property(e => e.T2).HasColumnType("datetime");

                entity.Property(e => e.T3).HasColumnType("datetime");
            });

            modelBuilder.Entity<Newsletter>(entity =>
            {
                entity.HasKey(e => e.Newslettersid)
                    .IsClustered(false);

                entity.ToTable("NEWSLETTERS");

                entity.Property(e => e.Newslettersid).HasColumnName("NEWSLETTERSID");

                entity.Property(e => e.Attachedfile)
                    .HasMaxLength(255)
                    .HasColumnName("ATTACHEDFILE");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Ispublished).HasColumnName("ISPUBLISHED");

                entity.Property(e => e.Lastmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTMODIFIED");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.Publisheddate)
                    .HasColumnType("datetime")
                    .HasColumnName("PUBLISHEDDATE");

                entity.Property(e => e.Quotes)
                    .HasMaxLength(255)
                    .HasColumnName("QUOTES");
            });

            modelBuilder.Entity<Newsletterscategory>(entity =>
            {
                entity.HasKey(e => e.Categoryid)
                    .IsClustered(false);

                entity.ToTable("NEWSLETTERSCATEGORY");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(255)
                    .HasColumnName("CATEGORYNAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Languageid).HasColumnName("LANGUAGEID");

                entity.Property(e => e.Level).HasColumnName("LEVEL");

                entity.Property(e => e.Order).HasColumnName("ORDER");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Newsletterscategories)
                    .HasForeignKey(d => d.Languageid)
                    .HasConstraintName("FK_NEWSLETTERSCATEGORY_LANGUAGE");
            });

            modelBuilder.Entity<Newslettersregistration>(entity =>
            {
                entity.HasKey(e => e.Newslettersregistrationid)
                    .IsClustered(false);

                entity.ToTable("NEWSLETTERSREGISTRATION");

                entity.Property(e => e.Newslettersregistrationid).HasColumnName("NEWSLETTERSREGISTRATIONID");

                entity.Property(e => e.Changedate)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGEDATE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Registerdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTERDATE");

                entity.HasMany(d => d.Categories)
                    .WithMany(p => p.Newslettersregistrations)
                    .UsingEntity<Dictionary<string, object>>(
                        "Newslettersregistrationlist",
                        l => l.HasOne<Newsletterscategory>().WithMany().HasForeignKey("Categoryid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_NEWSLETTERSREGISTRATIONLIST_NEWSLETTERSCATEGORY"),
                        r => r.HasOne<Newslettersregistration>().WithMany().HasForeignKey("Newslettersregistrationid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_NEWSLETTERSREGISTRATIONLIST_NEWSLETTERSREGISTRATION"),
                        j =>
                        {
                            j.HasKey("Newslettersregistrationid", "Categoryid").HasName("PK__NEWSLETTERSREGIS__7E388A4D");

                            j.ToTable("NEWSLETTERSREGISTRATIONLIST");

                            j.IndexerProperty<int>("Newslettersregistrationid").HasColumnName("NEWSLETTERSREGISTRATIONID");

                            j.IndexerProperty<long>("Categoryid").HasColumnName("CATEGORYID");
                        });
            });

            modelBuilder.Entity<Newsresearch>(entity =>
            {
                entity.HasKey(e => e.Newsresearchid)
                    .IsClustered(false);

                entity.ToTable("NEWSRESEARCH");

                entity.HasIndex(e => new { e.NewsresearchidExt, e.Source }, "IDX_NEWSRESEARCH_EXTKEYS");

                entity.HasIndex(e => e.Customergroupid, "IX_NEWSRESEARCH_CUSTOMERGROUPID");

                entity.HasIndex(e => e.Ispublished, "IX_NEWSRESEARCH_ISPUBLISHED");

                entity.HasIndex(e => e.Languageid, "IX_NEWSRESEARCH_LANGUAGEID");

                entity.HasIndex(e => e.Publisheddate, "IX_NEWSRESEARCH_PUBLISHEDDATE");

                entity.HasIndex(e => e.Quotes, "IX_NEWSRESEARCH_QUOTES");

                entity.HasIndex(e => e.Source, "IX_NEWSRESEARCH_SOURCE");

                entity.HasIndex(e => e.Title, "IX_NEWSRESEARCH_TITLE");

                entity.Property(e => e.Newsresearchid).HasColumnName("NEWSRESEARCHID");

                entity.Property(e => e.Attachedfile)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ATTACHEDFILE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasColumnName("AUTHOR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Content)
                    .HasColumnType("ntext")
                    .HasColumnName("CONTENT");

                entity.Property(e => e.Createby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEBY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Customergroupid).HasColumnName("CUSTOMERGROUPID");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Introduction)
                    .HasMaxLength(1000)
                    .HasColumnName("INTRODUCTION");

                entity.Property(e => e.Ispublished).HasColumnName("ISPUBLISHED");

                entity.Property(e => e.Languageid)
                    .HasColumnName("LANGUAGEID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTMODIFIED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("MODIFIEDBY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewsresearchidExt)
                    .HasMaxLength(36)
                    .HasColumnName("NEWSRESEARCHID_EXT")
                    .HasDefaultValueSql("('00000000-0000-0000-0000-000000000000')");

                entity.Property(e => e.Numviews).HasColumnName("NUMVIEWS");

                entity.Property(e => e.Publisheddate)
                    .HasColumnType("datetime")
                    .HasColumnName("PUBLISHEDDATE");

                entity.Property(e => e.Quotes)
                    .HasMaxLength(255)
                    .HasColumnName("QUOTES");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .HasColumnName("SOURCE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sourceid)
                    .HasMaxLength(255)
                    .HasColumnName("SOURCEID");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("TITLE");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Newsresearches)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NEWSRESEARCH_NEWSRESEARCHCATEGORY");
            });

            modelBuilder.Entity<Newsresearchcategory>(entity =>
            {
                entity.HasKey(e => e.Categoryid)
                    .IsClustered(false);

                entity.ToTable("NEWSRESEARCHCATEGORY");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(255)
                    .HasColumnName("CATEGORYNAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Languageid).HasColumnName("LANGUAGEID");

                entity.Property(e => e.Level).HasColumnName("LEVEL");

                entity.Property(e => e.Order).HasColumnName("ORDER");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            });

            modelBuilder.Entity<Newsresearchcategory2Ext>(entity =>
            {
                entity.ToTable("NEWSRESEARCHCATEGORY_2_EXT");

                entity.HasIndex(e => new { e.Categoryid, e.CategoryidExt }, "IDX_NEWSRESEARCHCATEGORY_2_EXT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.CategoryidExt).HasColumnName("CATEGORYID_EXT");
            });

            modelBuilder.Entity<NewsresearchcategoryExt>(entity =>
            {
                entity.HasKey(e => e.CategoryidExt);

                entity.ToTable("NEWSRESEARCHCATEGORY_EXT");

                entity.HasIndex(e => new { e.CategoryidOrg, e.Sourceid }, "IDX_NEWSRESEARCHCATEGORY_EXT");

                entity.Property(e => e.CategoryidExt).HasColumnName("CATEGORYID_EXT");

                entity.Property(e => e.CategoryidOrg)
                    .HasMaxLength(36)
                    .HasColumnName("CATEGORYID_ORG")
                    .HasDefaultValueSql("('00000000-0000-0000-0000-000000000000')");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(255)
                    .HasColumnName("CATEGORYNAME");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Languageid).HasColumnName("LANGUAGEID");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Parentid)
                    .HasMaxLength(36)
                    .HasColumnName("PARENTID");

                entity.Property(e => e.Sourceid)
                    .HasMaxLength(32)
                    .HasColumnName("SOURCEID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Nexdayprice>(entity =>
            {
                entity.ToTable("NEXDAYPRICE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CeilingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FloorPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Market)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Symbol).HasMaxLength(50);
            });

            modelBuilder.Entity<NextDayPrice>(entity =>
            {
                entity.HasKey(e => e.Symbol);

                entity.ToTable("NextDayPrice");

                entity.Property(e => e.Symbol).HasMaxLength(20);

                entity.Property(e => e.CeilingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FloorPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Market)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RefPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NotifyDeviceId>(entity =>
            {
                entity.ToTable("Notify_DeviceID");

                entity.Property(e => e.Channel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RegisteredConfirmation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark).HasMaxLength(255);
            });

            modelBuilder.Entity<NotifyEvent>(entity =>
            {
                entity.ToTable("NOTIFY_EVENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ProcessedTime).HasColumnType("datetime");

                entity.Property(e => e.TriggerDate).HasColumnType("datetime");

                entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

                entity.Property(e => e.WsretCode)
                    .HasMaxLength(10)
                    .HasColumnName("WSRetCode")
                    .IsFixedLength();

                entity.Property(e => e.Wsstatus).HasColumnName("WSStatus");
            });

            modelBuilder.Entity<NotifyEventHistory>(entity =>
            {
                entity.ToTable("NOTIFY_EVENT_HISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ProcessedTime).HasColumnType("datetime");

                entity.Property(e => e.TriggerDate).HasColumnType("datetime");

                entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

                entity.Property(e => e.WsretCode)
                    .HasMaxLength(10)
                    .HasColumnName("WSRetCode")
                    .IsFixedLength();

                entity.Property(e => e.Wsstatus).HasColumnName("WSStatus");
            });

            modelBuilder.Entity<NotifyServicesType>(entity =>
            {
                entity.HasKey(e => e.ServiceCode)
                    .HasName("PK__Notify_S__A01D74C8DAFF19BC");

                entity.ToTable("Notify_Services_Type");

                entity.Property(e => e.ServiceCode).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NotifyServicesTypeLanguage>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.LangId })
                    .HasName("PK__Notify_S__5A4245E5239D87F3");

                entity.ToTable("Notify_Services_Type_Language");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceName).HasMaxLength(200);
            });

            modelBuilder.Entity<Oddslot>(entity =>
            {
                entity.HasKey(e => e.Oddslotid)
                    .IsClustered(false);

                entity.ToTable("ODDSLOT");

                entity.Property(e => e.Oddslotid).HasColumnName("ODDSLOTID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BUYER");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dateprice)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEPRICE");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(13, 4)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<OddslotPretest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ODDSLOT_PRETEST");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BUYER");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dateprice)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEPRICE");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Oddslotid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ODDSLOTID");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(13, 4)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<Oddslotconfig>(entity =>
            {
                entity.ToTable("ODDSLOTCONFIG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MarketId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Oddslotexceptstock>(entity =>
            {
                entity.ToTable("ODDSLOTEXCEPTSTOCK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IncludeType).HasDefaultValueSql("((1))");

                entity.Property(e => e.MarketId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oddslothistory>(entity =>
            {
                entity.HasKey(e => e.Oddslothistid)
                    .IsClustered(false);

                entity.ToTable("ODDSLOTHISTORY");

                entity.Property(e => e.Oddslothistid).HasColumnName("ODDSLOTHISTID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BUYER");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dateprice)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEPRICE");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<OrderAutoApproveList>(entity =>
            {
                entity.HasKey(e => e.ApproveId)
                    .HasName("PK__OrderAutoApprove__5D8C8EF0");

                entity.ToTable("OrderAutoApproveList");

                entity.Property(e => e.ApproveId).HasColumnName("ApproveID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creditline).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);
            });

            modelBuilder.Entity<OrderBasket>(entity =>
            {
                entity.HasKey(e => e.BasketId);

                entity.ToTable("ORDER_BASKET");

                entity.Property(e => e.BasketId).HasColumnName("BasketID");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark).HasMaxLength(250);
            });

            modelBuilder.Entity<OrderBasketinfo>(entity =>
            {
                entity.ToTable("ORDER_BASKETINFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Basketid).HasColumnName("BASKETID");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(250)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Transtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderConditionGtd>(entity =>
            {
                entity.ToTable("OrderConditionGTD");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.ConditionPrice)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastMatchedPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LastMatchingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.MatchingType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RejectedReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StockSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VolumeCancelled).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrderConditionGtdsent>(entity =>
            {
                entity.ToTable("OrderConditionGTDSent");

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnterId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FisOrderId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderConditionGtdid).HasColumnName("OrderConditionGTDId");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RefOrderId)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderConditionSt>(entity =>
            {
                entity.ToTable("OrderConditionST");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvgPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsCheckStopLoss)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCheckTakeProfit)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastMatchedPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LastMatchingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.MatchingType).HasDefaultValueSql("((1))");

                entity.Property(e => e.RejectedReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StockSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StopLossPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StopLossWhenPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TakeProfitPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TakeProfitWhenPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderConditionStsent>(entity =>
            {
                entity.ToTable("OrderConditionSTSent");

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnterId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FisOrderId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderConditionStid).HasColumnName("OrderConditionSTId");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RefOrderId)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderConfirmation>(entity =>
            {
                entity.ToTable("ORDER_CONFIRMATION");

                entity.Property(e => e.OrderConfirmationId).HasColumnName("OrderConfirmationID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorChannel).HasMaxLength(20);

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(20)
                    .HasColumnName("AuthorID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: do He thong tu dong ky lenh.");

                entity.Property(e => e.CancelVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelledTime).HasColumnType("datetime");

                entity.Property(e => e.CancelledVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("Ma xac nhan");

                entity.Property(e => e.ConfirmCodeDate).HasColumnType("datetime");

                entity.Property(e => e.Coreaccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COREACCOUNT");

                entity.Property(e => e.Coretype)
                    .HasColumnName("CORETYPE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ExecutedPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.ExecutedVol).HasDefaultValueSql("((0))");

                entity.Property(e => e.FisOrderId)
                    .HasColumnName("FisOrderID")
                    .HasComment("OrderID tren he thong FIS");

                entity.Property(e => e.MatchedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SignDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngay ky phieu lenh");

                entity.Property(e => e.Status).HasComment("0: Chua ky - \r\n1: Da ky");

                entity.Property(e => e.TpCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TP_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TpStatus)
                    .HasColumnName("TP_STATUS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TpUse)
                    .HasColumnName("TP_USE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.TransTime)
                    .HasColumnType("datetime")
                    .HasComment("Ngay giao dich");

                entity.Property(e => e.Volume).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrderConfirmationExcludeTraderid>(entity =>
            {
                entity.HasKey(e => e.ExTraderId);

                entity.ToTable("ORDER_CONFIRMATION_EXCLUDE_TRADERID");

                entity.Property(e => e.ExTraderId).HasColumnName("ExTraderID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");
            });

            modelBuilder.Entity<OrderConfirmationhistory>(entity =>
            {
                entity.HasKey(e => e.OrderConfirmationId);

                entity.ToTable("ORDER_CONFIRMATIONHISTORY");

                entity.Property(e => e.OrderConfirmationId).HasColumnName("OrderConfirmationID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorChannel).HasMaxLength(20);

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(20)
                    .HasColumnName("AuthorID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: do He thong tu dong ky lenh.");

                entity.Property(e => e.CancelVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelledTime).HasColumnType("datetime");

                entity.Property(e => e.CancelledVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.ConPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("Ma xac nhan");

                entity.Property(e => e.ConfirmCodeDate).HasColumnType("datetime");

                entity.Property(e => e.Coretype)
                    .HasColumnName("CORETYPE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ExecutedPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.ExecutedVol).HasDefaultValueSql("((0))");

                entity.Property(e => e.FisOrderId)
                    .HasColumnName("FisOrderID")
                    .HasComment("OrderID tren he thong FIS");

                entity.Property(e => e.MatchedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SignDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngay ky phieu lenh");

                entity.Property(e => e.Status).HasComment("0: Chua ky - \r\n1: Da ky");

                entity.Property(e => e.TpCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TP_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TpStatus)
                    .HasColumnName("TP_STATUS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TpUse)
                    .HasColumnName("TP_USE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.TransTime)
                    .HasColumnType("datetime")
                    .HasComment("Ngay giao dich");

                entity.Property(e => e.Volume).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrderConfirmationsummary>(entity =>
            {
                entity.HasKey(e => e.SumId);

                entity.ToTable("ORDER_CONFIRMATIONSUMMARY");

                entity.Property(e => e.SumId).HasColumnName("SUM_ID");

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthorID");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ChannelID");

                entity.Property(e => e.ConfirmContent).HasColumnType("ntext");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.TradeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderConfirmationsummaryHistory>(entity =>
            {
                entity.HasKey(e => e.SumId);

                entity.ToTable("ORDER_CONFIRMATIONSUMMARY_HISTORY");

                entity.Property(e => e.SumId)
                    .ValueGeneratedNever()
                    .HasColumnName("SUM_ID");

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthorID");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ChannelID");

                entity.Property(e => e.ConfirmContent).HasColumnType("ntext");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.TradeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderGroup>(entity =>
            {
                entity.HasKey(e => e.Grouporderid)
                    .HasName("PK_GROUPORDER")
                    .IsClustered(false);

                entity.ToTable("ORDER_GROUP");

                entity.Property(e => e.Grouporderid)
                    .ValueGeneratedNever()
                    .HasColumnName("GROUPORDERID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Changeprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("CHANGEPRICE");

                entity.Property(e => e.Changevolume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("CHANGEVOLUME");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sumorder)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("SUMORDER");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderGtd>(entity =>
            {
                entity.HasKey(e => e.Gtdorderid)
                    .HasName("PK_GTDORDER")
                    .IsClustered(false);

                entity.ToTable("ORDER_GTD");

                entity.Property(e => e.Gtdorderid)
                    .ValueGeneratedNever()
                    .HasColumnName("GTDORDERID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Begindate)
                    .HasColumnType("datetime")
                    .HasColumnName("BEGINDATE");

                entity.Property(e => e.Cancelledtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS")
                    .IsFixedLength();

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordertime)
                    .HasMaxLength(15)
                    .HasColumnName("ORDERTIME")
                    .IsFixedLength();

                entity.Property(e => e.Ordrejreason).HasColumnName("ORDREJREASON");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Realid).HasColumnName("REALID");

                entity.Property(e => e.Referid).HasColumnName("REFERID");

                entity.Property(e => e.Senttime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SENTTIME");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderPrior>(entity =>
            {
                entity.HasKey(e => e.Proorderid)
                    .HasName("PK_PROORDER")
                    .IsClustered(false);

                entity.ToTable("ORDER_PRIOR");

                entity.Property(e => e.Proorderid)
                    .ValueGeneratedNever()
                    .HasColumnName("PROORDERID");

                entity.Property(e => e.Ismatchall).HasColumnName("ISMATCHALL");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderSplit>(entity =>
            {
                entity.HasKey(e => e.Ordersplitid)
                    .HasName("PK_ORDERSPLIT")
                    .IsClustered(false);

                entity.ToTable("ORDER_SPLIT");

                entity.Property(e => e.Ordersplitid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDERSPLITID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderSt>(entity =>
            {
                entity.HasKey(e => e.Storderid)
                    .HasName("PK_STORDER")
                    .IsClustered(false);

                entity.ToTable("ORDER_ST");

                entity.Property(e => e.Storderid)
                    .ValueGeneratedNever()
                    .HasColumnName("STORDERID");

                entity.Property(e => e.Limitgainprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("LIMITGAINPRICE");

                entity.Property(e => e.Limitgainratio)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("LIMITGAINRATIO");

                entity.Property(e => e.Limitlossprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("LIMITLOSSPRICE");

                entity.Property(e => e.Limitlossratio)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("LIMITLOSSRATIO");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderT>(entity =>
            {
                entity.HasKey(e => e.Tsorderid)
                    .HasName("PK_TSORDER")
                    .IsClustered(false);

                entity.ToTable("ORDER_TS");

                entity.Property(e => e.Tsorderid)
                    .ValueGeneratedNever()
                    .HasColumnName("TSORDERID");

                entity.Property(e => e.Downboundprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("DOWNBOUNDPRICE");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Upboundprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("UPBOUNDPRICE");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Orderhistory>(entity =>
            {
                entity.HasKey(e => e.Orderhistoryid)
                    .IsClustered(false);

                entity.ToTable("ORDERHISTORY");

                entity.HasIndex(e => new { e.Accountno, e.Orderdate }, "IX_ORDERHISTORY_AccountNo");

                entity.HasIndex(e => e.Channel, "IX_ORDERHISTORY_CHANNEL");

                entity.HasIndex(e => e.Orderdate, "IX_ORDERHISTORY_ORDERDATE");

                entity.HasIndex(e => e.Orderno, "IX_ORDERHISTORY_ORDERNO");

                entity.HasIndex(e => e.Orderstatus, "IX_ORDERHISTORY_ORDERSTATUS");

                entity.HasIndex(e => e.Side, "IX_ORDERHISTORY_Side");

                entity.HasIndex(e => e.Symbol, "IX_ORDERHISTORY_Symbol");

                entity.Property(e => e.Orderhistoryid).HasColumnName("ORDERHISTORYID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accttype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Approveid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD")
                    .IsFixedLength();

                entity.Property(e => e.Branchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID")
                    .IsFixedLength();

                entity.Property(e => e.Brokerno).HasColumnName("BROKERNO");

                entity.Property(e => e.Brokerorderno).HasColumnName("BROKERORDERNO");

                entity.Property(e => e.Cancelid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CANCELID");

                entity.Property(e => e.Canceltime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELTIME");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Channel).HasColumnName("CHANNEL");

                entity.Property(e => e.Chguserid)
                    .HasMaxLength(40)
                    .HasColumnName("CHGUSERID");

                entity.Property(e => e.Condition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITION")
                    .IsFixedLength();

                entity.Property(e => e.Conditionprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITIONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dealcount).HasColumnName("DEALCOUNT");

                entity.Property(e => e.Delflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Effecteddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EFFECTEDDATE");

                entity.Property(e => e.Enterid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ENTERID");

                entity.Property(e => e.Fee)
                    .HasColumnType("numeric(26, 6)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Matchprice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MATCHPRICE");

                entity.Property(e => e.Matchvalue)
                    .HasColumnType("numeric(26, 6)")
                    .HasColumnName("MATCHVALUE");

                entity.Property(e => e.Matchvolume)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MATCHVOLUME");

                entity.Property(e => e.Minorstatus).HasColumnName("MINORSTATUS");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno).HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordertime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTIME");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Pubvolume)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("PUBVOLUME");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Secsymbolfront)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOLFRONT");

                entity.Property(e => e.Secsymbolreport)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOLREPORT");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Trusteeid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRUSTEEID")
                    .IsFixedLength();

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Orderhistory3d>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDERHISTORY_3D");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accttype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Approveid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD")
                    .IsFixedLength();

                entity.Property(e => e.Branchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID")
                    .IsFixedLength();

                entity.Property(e => e.Brokerno).HasColumnName("BROKERNO");

                entity.Property(e => e.Brokerorderno).HasColumnName("BROKERORDERNO");

                entity.Property(e => e.Cancelid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CANCELID");

                entity.Property(e => e.Canceltime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELTIME");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Channel).HasColumnName("CHANNEL");

                entity.Property(e => e.Chguserid)
                    .HasMaxLength(40)
                    .HasColumnName("CHGUSERID");

                entity.Property(e => e.Condition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITION")
                    .IsFixedLength();

                entity.Property(e => e.Conditionprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITIONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dealcount).HasColumnName("DEALCOUNT");

                entity.Property(e => e.Delflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Effecteddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EFFECTEDDATE");

                entity.Property(e => e.Enterid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ENTERID");

                entity.Property(e => e.Fee)
                    .HasColumnType("numeric(26, 6)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Matchprice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MATCHPRICE");

                entity.Property(e => e.Matchvalue)
                    .HasColumnType("numeric(26, 6)")
                    .HasColumnName("MATCHVALUE");

                entity.Property(e => e.Matchvolume)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MATCHVOLUME");

                entity.Property(e => e.Minorstatus).HasColumnName("MINORSTATUS");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Orderhistoryid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ORDERHISTORYID");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno).HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordertime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTIME");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Pubvolume)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("PUBVOLUME");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Secsymbolfront)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOLFRONT");

                entity.Property(e => e.Secsymbolreport)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOLREPORT");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Stopprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("STOPPRICE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Trusteeid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRUSTEEID")
                    .IsFixedLength();

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Orderhistorybackup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ORDERHISTORYBACKUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accttype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Approveid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD")
                    .IsFixedLength();

                entity.Property(e => e.Branchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID")
                    .IsFixedLength();

                entity.Property(e => e.Brokerno).HasColumnName("BROKERNO");

                entity.Property(e => e.Brokerorderno).HasColumnName("BROKERORDERNO");

                entity.Property(e => e.Cancelid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CANCELID");

                entity.Property(e => e.Canceltime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELTIME");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Channel).HasColumnName("CHANNEL");

                entity.Property(e => e.Chguserid)
                    .HasMaxLength(40)
                    .HasColumnName("CHGUSERID");

                entity.Property(e => e.Condition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITION")
                    .IsFixedLength();

                entity.Property(e => e.Conditionprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITIONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dealcount).HasColumnName("DEALCOUNT");

                entity.Property(e => e.Delflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Effecteddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EFFECTEDDATE");

                entity.Property(e => e.Enterid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ENTERID");

                entity.Property(e => e.Fee)
                    .HasColumnType("numeric(26, 6)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Matchprice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MATCHPRICE");

                entity.Property(e => e.Matchvalue)
                    .HasColumnType("numeric(26, 6)")
                    .HasColumnName("MATCHVALUE");

                entity.Property(e => e.Matchvolume)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MATCHVOLUME");

                entity.Property(e => e.Minorstatus).HasColumnName("MINORSTATUS");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno).HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordertime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTIME");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Pubvolume)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("PUBVOLUME");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Secsymbolfront)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOLFRONT");

                entity.Property(e => e.Secsymbolreport)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOLREPORT");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Trusteeid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRUSTEEID")
                    .IsFixedLength();

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Orderinfo>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ORDERINFO");

                entity.HasIndex(e => e.Account, "IX_ORDERINFO_ACCOUNT");

                entity.HasIndex(e => e.CreateTime, "IX_ORDERINFO_CREATETIME");

                entity.HasIndex(e => e.Fisorderid, "IX_ORDERINFO_FISORDERID");

                entity.HasIndex(e => e.Ordersource, "IX_ORDERINFO_ORDERSOURCE");

                entity.HasIndex(e => e.Orderstatus, "IX_ORDERINFO_ORDERSTATUS");

                entity.HasIndex(e => e.Side, "IX_ORDERINFO_SIDE");

                entity.HasIndex(e => e.Secsymbol, "IX_ORDERINFO_SecSymbol");

                entity.HasIndex(e => e.Transtime, "IX_ORDERINFO_TRANSTIME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.AllowShow)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0: Không show/check số dư/lệnh đối ứng - 1: Được phép show/check số dư/lệnh đối ứng");

                entity.Property(e => e.Cancelledconfirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDCONFIRMNO");

                entity.Property(e => e.Cancelledexectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDEXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Cancelledrejreason)
                    .HasColumnName("CANCELLEDREJREASON")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume)
                    .HasColumnName("CANCELLEDVOLUME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancelstatus)
                    .HasColumnName("CANCELSTATUS")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Cancelvolume)
                    .HasColumnName("CANCELVOLUME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON")
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.Changestatus)
                    .HasColumnName("CHANGESTATUS")
                    .HasDefaultValueSql("((-1))")
                    .HasComment("-1: Không sưa - 0: Đang sửa - 2: Đã sửa - 3: Từ chối sửa");

                entity.Property(e => e.Commission)
                    .HasColumnName("COMMISSION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Errorreason)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ERRORREASON");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Executedprice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("EXECUTEDPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Executedvol)
                    .HasColumnName("EXECUTEDVOL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Isnew)
                    .HasColumnName("ISNEW")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issentemail).HasColumnName("ISSENTEMAIL");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Matchedtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MATCHEDTIME");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE")
                    .IsFixedLength();

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Numofmatch)
                    .HasColumnName("NUMOFMATCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oldaccount)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLDACCOUNT");

                entity.Property(e => e.Oldprice).HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason)
                    .HasColumnName("ORDREJREASON")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag)
                    .HasColumnName("PUTTHROUGHFLAG")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: Lệnh thường - 1: GDTT cùng công ty - 2: GDTT khác công ty");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.Tax)
                    .HasColumnName("TAX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.Transtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Orderinfo20170302>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDERINFO_20170302");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Cancelledconfirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDCONFIRMNO");

                entity.Property(e => e.Cancelledexectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDEXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Cancelledrejreason).HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus).HasColumnName("CANCELSTATUS");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Errorreason)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ERRORREASON");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Executedprice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedvol).HasColumnName("EXECUTEDVOL");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Issentemail).HasColumnName("ISSENTEMAIL");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS");

                entity.Property(e => e.Matchedtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MATCHEDTIME");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE")
                    .IsFixedLength();

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Numofmatch).HasColumnName("NUMOFMATCH");

                entity.Property(e => e.Oldaccount)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLDACCOUNT");

                entity.Property(e => e.Oldprice).HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason).HasColumnName("ORDREJREASON");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag).HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.Transtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderinfoBackup20210703>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orderinfo_Backup20210703");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Cancelledconfirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDCONFIRMNO");

                entity.Property(e => e.Cancelledexectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDEXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Cancelledrejreason).HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus).HasColumnName("CANCELSTATUS");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Errorreason)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ERRORREASON");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Executedprice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedvol).HasColumnName("EXECUTEDVOL");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Issentemail).HasColumnName("ISSENTEMAIL");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS");

                entity.Property(e => e.Matchedtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MATCHEDTIME");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE")
                    .IsFixedLength();

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Numofmatch).HasColumnName("NUMOFMATCH");

                entity.Property(e => e.Oldaccount)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLDACCOUNT");

                entity.Property(e => e.Oldprice).HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason).HasColumnName("ORDREJREASON");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag).HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.Transtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderinfoBk20170304>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDERINFO_BK_20170304");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Cancelledconfirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDCONFIRMNO");

                entity.Property(e => e.Cancelledexectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDEXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Cancelledrejreason).HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus).HasColumnName("CANCELSTATUS");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON");

                entity.Property(e => e.Changestatus).HasColumnName("CHANGESTATUS");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Errorreason)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ERRORREASON");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Executedprice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedvol).HasColumnName("EXECUTEDVOL");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Issentemail).HasColumnName("ISSENTEMAIL");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS");

                entity.Property(e => e.Matchedtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MATCHEDTIME");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE")
                    .IsFixedLength();

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Numofmatch).HasColumnName("NUMOFMATCH");

                entity.Property(e => e.Oldaccount)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLDACCOUNT");

                entity.Property(e => e.Oldprice).HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason).HasColumnName("ORDREJREASON");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag).HasColumnName("PUTTHROUGHFLAG");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.Transtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<OrderinfoPretest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDERINFO_PRETEST");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Cancelledconfirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDCONFIRMNO");

                entity.Property(e => e.Cancelledexectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDEXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Cancelledrejreason).HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus).HasColumnName("CANCELSTATUS");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Errorreason)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ERRORREASON");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Executedprice).HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedvol).HasColumnName("EXECUTEDVOL");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Issentemail).HasColumnName("ISSENTEMAIL");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS");

                entity.Property(e => e.Matchedtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MATCHEDTIME");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Numofmatch).HasColumnName("NUMOFMATCH");

                entity.Property(e => e.Oldaccount)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLDACCOUNT");

                entity.Property(e => e.Oldprice).HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason).HasColumnName("ORDREJREASON");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT")
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.Transtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Orderinfobackup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ORDERINFOBACKUP");

                entity.HasIndex(e => e.TransDate, "IX_ORDERINFOBACKUP_TRANSDATE");

                entity.HasIndex(e => e.Transtime, "IX_ORDERINFOBACKUP_TRANSTIME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.AllowShow)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0: Không show/check số dư/lệnh đối ứng - 1: Được phép show/check số dư/lệnh đối ứng");

                entity.Property(e => e.Cancelledconfirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDCONFIRMNO");

                entity.Property(e => e.Cancelledexectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDEXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Cancelledrejreason).HasColumnName("CANCELLEDREJREASON");

                entity.Property(e => e.Cancelledsourceid).HasColumnName("CANCELLEDSOURCEID");

                entity.Property(e => e.Cancelledtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Cancelledvolume).HasColumnName("CANCELLEDVOLUME");

                entity.Property(e => e.Cancelstatus).HasColumnName("CANCELSTATUS");

                entity.Property(e => e.Cancelvolume).HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Changerejreason)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEREJREASON")
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.Changestatus)
                    .HasColumnName("CHANGESTATUS")
                    .HasDefaultValueSql("((-1))")
                    .HasComment("-1: Không sưa - 0: Đang sửa - 2: Đã sửa - 3: Từ chối sửa");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Confirmno)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Conprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Errorreason)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("ERRORREASON");

                entity.Property(e => e.Exectranstype).HasColumnName("EXECTRANSTYPE");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXECTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Executedprice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("EXECUTEDPRICE");

                entity.Property(e => e.Executedvol).HasColumnName("EXECUTEDVOL");

                entity.Property(e => e.Fisorderid).HasColumnName("FISORDERID");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Marketstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MARKETSTATUS");

                entity.Property(e => e.Matchedtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MATCHEDTIME");

                entity.Property(e => e.Messagetype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGETYPE")
                    .IsFixedLength();

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Numofmatch).HasColumnName("NUMOFMATCH");

                entity.Property(e => e.Oldprice).HasColumnName("OLDPRICE");

                entity.Property(e => e.Ordersource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSOURCE")
                    .IsFixedLength();

                entity.Property(e => e.Orderstatus).HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Ordrejreason).HasColumnName("ORDREJREASON");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Portorclient)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PORTORCLIENT")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Publishvol).HasColumnName("PUBLISHVOL");

                entity.Property(e => e.Putthroughflag)
                    .HasColumnName("PUTTHROUGHFLAG")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: Lệnh thường - 1: GDTT cùng công ty - 2: GDTT khác công ty");

                entity.Property(e => e.Reforderid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("REFORDERID");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Stopprice).HasColumnName("STOPPRICE");

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Transtime)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTIME");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Ordersource>(entity =>
            {
                entity.ToTable("ORDERSOURCE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Domain)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN");

                entity.Property(e => e.Feeratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FEERATIO");

                entity.Property(e => e.MinFee).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Pipename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PIPENAME");

                entity.Property(e => e.Pipeserver)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PIPESERVER");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.TaxRatio).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<OrdersourceBackup20170802>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDERSOURCE_Backup_20170802");

                entity.Property(e => e.Domain)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN");

                entity.Property(e => e.Feeratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FEERATIO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MinFee).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Pipename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PIPENAME");

                entity.Property(e => e.Pipeserver)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PIPESERVER");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PWD");

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.TaxRatio).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Orderstatistic>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ORDERSTATISTIC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Newcancel).HasColumnName("NEWCANCEL");

                entity.Property(e => e.Newmatch).HasColumnName("NEWMATCH");

                entity.Property(e => e.Newreject).HasColumnName("NEWREJECT");

                entity.Property(e => e.Totalcancel).HasColumnName("TOTALCANCEL");

                entity.Property(e => e.Totalmatch).HasColumnName("TOTALMATCH");

                entity.Property(e => e.Totalreject).HasColumnName("TOTALREJECT");
            });

            modelBuilder.Entity<OverdraftAccountList>(entity =>
            {
                entity.ToTable("OVERDRAFT_ACCOUNT_LIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OverdraftServiceId).HasColumnName("OverdraftServiceID");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OverdraftAccountListHistory>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.MovingDate });

                entity.ToTable("OVERDRAFT_ACCOUNT_LIST_HISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MovingDate).HasColumnType("datetime");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OverdraftServiceId).HasColumnName("OverdraftServiceID");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OverdraftIncludeStock>(entity =>
            {
                entity.ToTable("OVERDRAFT_INCLUDE_STOCK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OverdraftIncludeStockHistory>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.MovingDate });

                entity.ToTable("OVERDRAFT_INCLUDE_STOCK_HISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MovingDate).HasColumnType("datetime");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OverdraftServiceList>(entity =>
            {
                entity.ToTable("OVERDRAFT_SERVICE_LIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.ServiceName).HasMaxLength(250);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.Permissionid)
                    .IsClustered(false);

                entity.ToTable("PERMISSION");

                entity.Property(e => e.Permissionid).HasColumnName("PERMISSIONID");

                entity.Property(e => e.Moduleid).HasColumnName("MODULEID");

                entity.Property(e => e.Usergroupid).HasColumnName("USERGROUPID");
            });

            modelBuilder.Entity<Permission1>(entity =>
            {
                entity.HasKey(e => new { e.Actionid, e.Groupid });

                entity.ToTable("PERMISSIONS");

                entity.Property(e => e.Actionid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONID");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Hasaccess).HasColumnName("HASACCESS");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Permission1s)
                    .HasForeignKey(d => d.Actionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERMISSIONS_ACTIONS");
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("PORTFOLIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Actualvolume)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ACTUALVOLUME");

                entity.Property(e => e.Avaivolume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AVAIVOLUME");

                entity.Property(e => e.Avgprice)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("AVGPRICE");

                entity.Property(e => e.Portfoliodate)
                    .HasColumnType("datetime")
                    .HasColumnName("PORTFOLIODATE");

                entity.Property(e => e.Sectype).HasColumnName("SECTYPE");

                entity.Property(e => e.Startprice)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("STARTPRICE");

                entity.Property(e => e.Startvolume)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("STARTVOLUME");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Todayrealize)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("TODAYREALIZE");

                entity.Property(e => e.Trusteeid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRUSTEEID");
            });

            modelBuilder.Entity<Portfoliohistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("PORTFOLIOHISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Actualvolume)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ACTUALVOLUME");

                entity.Property(e => e.Avaivolume)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("AVAIVOLUME");

                entity.Property(e => e.Avgprice)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("AVGPRICE");

                entity.Property(e => e.Portfoliodate)
                    .HasColumnType("datetime")
                    .HasColumnName("PORTFOLIODATE");

                entity.Property(e => e.Sectype).HasColumnName("SECTYPE");

                entity.Property(e => e.Startprice)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("STARTPRICE");

                entity.Property(e => e.Startvolume)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("STARTVOLUME");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Todayrealize)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("TODAYREALIZE");

                entity.Property(e => e.Trusteeid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRUSTEEID");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("PROVINCES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProvinceID");

                entity.Property(e => e.ProvinceName).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(200);
            });

            modelBuilder.Entity<PushNewsNotify>(entity =>
            {
                entity.ToTable("PushNewsNotify");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PushDateTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<PushNewsNotifyHistory>(entity =>
            {
                entity.ToTable("PushNewsNotifyHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MovedDate).HasColumnType("datetime");

                entity.Property(e => e.PushDateTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<Realizegainloss>(entity =>
            {
                entity.HasKey(e => e.Realizeglid)
                    .IsClustered(false);

                entity.ToTable("REALIZEGAINLOSS");

                entity.HasIndex(e => e.Accountno, "IX_REALIZEGAINLOSS_ACCOUNTNO");

                entity.HasIndex(e => e.Symbol, "IX_REALIZEGAINLOSS_SYMBOL");

                entity.HasIndex(e => e.Tradedate, "IX_REALIZEGAINLOSS_TRADEDATE");

                entity.Property(e => e.Realizeglid).HasColumnName("REALIZEGLID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.BookHolding)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Buyprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BUYPRICE");

                entity.Property(e => e.Coretype).HasColumnName("CORETYPE");

                entity.Property(e => e.Gainloss)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("GAINLOSS");

                entity.Property(e => e.Percentgl)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("PERCENTGL");

                entity.Property(e => e.Sellprice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("SELLPRICE");

                entity.Property(e => e.SeqNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Syncdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SYNCDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Regcontactcenter>(entity =>
            {
                entity.ToTable("REGCONTACTCENTER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);
            });

            modelBuilder.Entity<Rejectcode>(entity =>
            {
                entity.HasKey(e => e.Rejectid)
                    .IsClustered(false);

                entity.ToTable("REJECTCODE");

                entity.Property(e => e.Rejectid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REJECTID");

                entity.Property(e => e.Message)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");
            });

            modelBuilder.Entity<Rightalert>(entity =>
            {
                entity.HasKey(e => e.Ririd)
                    .HasName("PK_RIGHTALERT_1");

                entity.ToTable("RIGHTALERT");

                entity.Property(e => e.Ririd)
                    .ValueGeneratedNever()
                    .HasColumnName("RIRID");

                entity.Property(e => e.Contact).HasColumnName("CONTACT");

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.Morealert).HasColumnName("MOREALERT");

                entity.Property(e => e.Sms).HasColumnName("SMS");
            });

            modelBuilder.Entity<Rightinfo>(entity =>
            {
                entity.ToTable("RIGHTINFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Confirmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMDATE");

                entity.Property(e => e.New)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("NEW");

                entity.Property(e => e.Newsharecode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NEWSHARECODE");

                entity.Property(e => e.Old)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("OLD");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Reftype)
                    .HasMaxLength(5)
                    .HasColumnName("REFTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Roundup)
                    .HasColumnType("decimal(20, 13)")
                    .HasColumnName("ROUNDUP");

                entity.Property(e => e.Seqno).HasColumnName("SEQNO");

                entity.Property(e => e.Stocktype)
                    .HasMaxLength(5)
                    .HasColumnName("STOCKTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.TransferLimitDate).HasColumnType("datetime");

                entity.Property(e => e.Xdate)
                    .HasColumnType("datetime")
                    .HasColumnName("XDATE");

                entity.Property(e => e.Xtype).HasColumnName("XTYPE");
            });

            modelBuilder.Entity<Rightregistration>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("RIGHTREGISTRATION");

                entity.HasIndex(e => e.Accountno, "IX_RIGHTREGISTRATION_ACCOUNTNO");

                entity.HasIndex(e => e.Closedate, "IX_RIGHTREGISTRATION_CLOSEDATE");

                entity.HasIndex(e => e.Confirmdate, "IX_RIGHTREGISTRATION_CONFIRMDATE");

                entity.HasIndex(e => e.Status, "IX_RIGHTREGISTRATION_STATUS");

                entity.HasIndex(e => e.Symbol, "IX_RIGHTREGISTRATION_SYMBOL");

                entity.HasIndex(e => e.Xtype, "IX_RIGHTREGISTRATION_XTYPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Closedate)
                    .HasColumnType("datetime")
                    .HasColumnName("CLOSEDATE");

                entity.Property(e => e.Compamt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("COMPAMT");

                entity.Property(e => e.Compunitbfxr)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITBFXR");

                entity.Property(e => e.Compunitconfirm)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITCONFIRM");

                entity.Property(e => e.Compunitdep)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITDEP");

                entity.Property(e => e.Compunitnew)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITNEW");

                entity.Property(e => e.Compunitwd)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITWD");

                entity.Property(e => e.Confirmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMDATE");

                entity.Property(e => e.Confirmflag)
                    .HasMaxLength(5)
                    .HasColumnName("CONFIRMFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Delflag)
                    .HasMaxLength(5)
                    .HasColumnName("DELFLAG")
                    .IsFixedLength();

                entity.Property(e => e.New)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("NEW");

                entity.Property(e => e.Newsharecode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NEWSHARECODE");

                entity.Property(e => e.Old)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("OLD");

                entity.Property(e => e.Paydate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAYDATE");

                entity.Property(e => e.Payrate)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PAYRATE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(5)
                    .HasColumnName("PURPOSE")
                    .IsFixedLength();

                entity.Property(e => e.Refno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFNO");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Rirno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIRNO");

                entity.Property(e => e.Rirtime)
                    .HasColumnType("datetime")
                    .HasColumnName("RIRTIME");

                entity.Property(e => e.Roundup)
                    .HasColumnType("decimal(20, 13)")
                    .HasColumnName("ROUNDUP");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Stocktype)
                    .HasMaxLength(5)
                    .HasColumnName("STOCKTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Transferfromdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERFROMDATE");

                entity.Property(e => e.Transfertodate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERTODATE");

                entity.Property(e => e.Xdate)
                    .HasColumnType("datetime")
                    .HasColumnName("XDate");

                entity.Property(e => e.Xtype).HasColumnName("XTYPE");
            });

            modelBuilder.Entity<Rightrequesthistory>(entity =>
            {
                entity.ToTable("RIGHTREQUESTHISTORY");

                entity.HasIndex(e => e.AccountNo, "IX_RIGHTREQUESTHISTORY_ACCOUNTNO");

                entity.HasIndex(e => e.CloseDate, "IX_RIGHTREQUESTHISTORY_CLOSEDATE");

                entity.HasIndex(e => e.Confirmdate, "IX_RIGHTREQUESTHISTORY_CONFIRMDATE");

                entity.HasIndex(e => e.ContractNo, "IX_RIGHTREQUESTHISTORY_ContractNo");

                entity.HasIndex(e => e.Rrid, "IX_RIGHTREQUESTHISTORY_RRID");

                entity.HasIndex(e => e.Symbol, "IX_RIGHTREQUESTHISTORY_SYMBOL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CompUnitConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompUnitNew).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Compamt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Confirmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMDATE");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.New).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.NewShareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Old).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.PayRate).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.Receiveraccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVERACCOUNT");

                entity.Property(e => e.RightDate).HasColumnType("datetime");

                entity.Property(e => e.Rirno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIRNO");

                entity.Property(e => e.Rrid).HasColumnName("RRID");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferToDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Volume).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Xtype).HasColumnName("XType");
            });

            modelBuilder.Entity<Rightstk>(entity =>
            {
                entity.ToTable("RIGHTSTK");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CompUnitConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompUnitNew).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Compamt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Confirmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMDATE");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.New).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.NewShareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Old).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.PayRate).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.Receiveraccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVERACCOUNT");

                entity.Property(e => e.RightDate).HasColumnType("datetime");

                entity.Property(e => e.Rirno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIRNO");

                entity.Property(e => e.Rrid).HasColumnName("RRID");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferToDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Volume).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Xtype).HasColumnName("XType");
            });

            modelBuilder.Entity<Rightstk20161003>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RIGHTSTK_20161003");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CompUnitConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompUnitNew).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Compamt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Confirmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMDATE");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.New).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.NewShareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Old).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.PayRate).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.Receiveraccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVERACCOUNT");

                entity.Property(e => e.RightDate).HasColumnType("datetime");

                entity.Property(e => e.Rirno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIRNO");

                entity.Property(e => e.Rrid).HasColumnName("RRID");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferToDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Volume).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Xtype).HasColumnName("XType");
            });

            modelBuilder.Entity<RightstkPretest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RIGHTSTK_PRETEST");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CompUnitConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompUnitNew).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Compamt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Confirmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMDATE");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.New).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.NewShareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Old).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.PayRate).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.Receiveraccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVERACCOUNT");

                entity.Property(e => e.RightDate).HasColumnType("datetime");

                entity.Property(e => e.Rirno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIRNO");

                entity.Property(e => e.Rrid).HasColumnName("RRID");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferToDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Volume).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Xtype).HasColumnName("XType");
            });

            modelBuilder.Entity<Rightstkhistory>(entity =>
            {
                entity.ToTable("RIGHTSTKHISTORY");

                entity.HasIndex(e => e.AccountNo, "IX_RIGHTSTKHISTORY_ACCOUNTNO");

                entity.HasIndex(e => e.CloseDate, "IX_RIGHTSTKHISTORY_CLOSEDATE");

                entity.HasIndex(e => e.Confirmdate, "IX_RIGHTSTKHISTORY_CONFIRMDATE");

                entity.HasIndex(e => e.ContractNo, "IX_RIGHTSTKHISTORY_ContractNo");

                entity.HasIndex(e => e.Rrid, "IX_RIGHTSTKHISTORY_RRID");

                entity.HasIndex(e => e.RightDate, "IX_RIGHTSTKHISTORY_RightDate");

                entity.HasIndex(e => e.Symbol, "IX_RIGHTSTKHISTORY_SYMBOL");

                entity.HasIndex(e => e.Status, "IX_RIGHTSTKHISTORY_Status");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CompUnitConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompUnitNew).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Compamt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Compunitbfxr)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITBFXR");

                entity.Property(e => e.Compunitdep)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITDEP");

                entity.Property(e => e.Compunitwd)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("COMPUNITWD");

                entity.Property(e => e.Confirmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMDATE");

                entity.Property(e => e.Confirmflag)
                    .HasMaxLength(5)
                    .HasColumnName("CONFIRMFLAG")
                    .IsFixedLength();

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Delflag)
                    .HasMaxLength(5)
                    .HasColumnName("DELFLAG")
                    .IsFixedLength();

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.New).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.NewShareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Old).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.PayRate).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Paydate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAYDATE");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.Receiveraccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVERACCOUNT");

                entity.Property(e => e.RightDate).HasColumnType("datetime");

                entity.Property(e => e.Rirno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIRNO");

                entity.Property(e => e.Roundup)
                    .HasColumnType("decimal(20, 13)")
                    .HasColumnName("ROUNDUP");

                entity.Property(e => e.Rrid).HasColumnName("RRID");

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferToDate).HasColumnType("datetime");

                entity.Property(e => e.Transferfromdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERFROMDATE");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Volume).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Xtype).HasColumnName("XType");
            });

            modelBuilder.Entity<SectorIndex>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.MarketCode, e.SectorNo })
                    .HasName("PK_SextorIndex");

                entity.ToTable("SectorIndex");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MarketCode).HasMaxLength(50);

                entity.Property(e => e.SectorNo).HasMaxLength(50);
            });

            modelBuilder.Entity<SessionDataHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SessionData_History");

                entity.Property(e => e.Address).HasMaxLength(256);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.LastAccessTime).HasColumnType("datetime");

                entity.Property(e => e.Lat).HasMaxLength(20);

                entity.Property(e => e.Lng).HasMaxLength(20);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.MacAddress).HasMaxLength(20);

                entity.Property(e => e.MoveDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerSessionId).HasMaxLength(256);

                entity.Property(e => e.RequestIpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserAgent).HasMaxLength(512);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SessionDatum>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.LastAccessTime).HasColumnType("datetime");

                entity.Property(e => e.Lat).HasMaxLength(20);

                entity.Property(e => e.Lng).HasMaxLength(20);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.MacAddress).HasMaxLength(20);

                entity.Property(e => e.PartnerSessionId).HasMaxLength(50);

                entity.Property(e => e.RequestIpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SignOnlineRegistration>(entity =>
            {
                entity.HasKey(e => e.RegistrationId);

                entity.ToTable("SignOnlineRegistration");

                entity.Property(e => e.RegistrationId).HasColumnName("RegistrationID");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.TypeSigningId).HasColumnName("TypeSigningID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SignOnlineType>(entity =>
            {
                entity.HasKey(e => e.SigningId);

                entity.ToTable("SignOnlineType");

                entity.Property(e => e.SigningId).HasColumnName("SigningID");

                entity.Property(e => e.SigningDescription).HasMaxLength(1024);

                entity.Property(e => e.SigningName).HasMaxLength(255);

                entity.Property(e => e.SigningTerm).HasColumnType("ntext");
            });

            modelBuilder.Entity<Smsregistration>(entity =>
            {
                entity.HasKey(e => e.Smsregistrationid)
                    .IsClustered(false);

                entity.ToTable("SMSREGISTRATION");

                entity.Property(e => e.Smsregistrationid)
                    .ValueGeneratedNever()
                    .HasColumnName("SMSREGISTRATIONID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");
            });

            modelBuilder.Entity<Spr>(entity =>
            {
                entity.ToTable("SPR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("So tien can ho tro");

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.FundingDate).HasColumnType("datetime");

                entity.Property(e => e.Interest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemainAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sprdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SPRDate");

                entity.Property(e => e.TradeDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngay mau chung khoan");

                entity.Property(e => e.TradeValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Gia tri lenh dat cua ngay TradeDate");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasComment("1: nhan ho tro, 2: tra ho tro");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sprhistory>(entity =>
            {
                entity.ToTable("SPRHISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.FundingDate).HasColumnType("datetime");

                entity.Property(e => e.Interest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemainAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sprdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SPRDate");

                entity.Property(e => e.TradeDate).HasColumnType("datetime");

                entity.Property(e => e.TradeValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sql>(entity =>
            {
                entity.HasKey(e => e.C1)
                    .HasName("PK__sql__3213663B4FF8C000");

                entity.ToTable("sql");

                entity.Property(e => e.C1)
                    .ValueGeneratedNever()
                    .HasColumnName("c1");

                entity.Property(e => e.C2)
                    .HasMaxLength(48)
                    .HasColumnName("c2")
                    .IsFixedLength();
            });

            modelBuilder.Entity<StepPriceRange>(entity =>
            {
                entity.ToTable("StepPriceRange");

                entity.Property(e => e.AssetCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssetType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Max).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Min).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StockType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StepPriceRangeBackup20220506>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StepPriceRange_Backup20220506");

                entity.Property(e => e.AssetCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssetType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Market)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Max).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Min).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceStep).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StockType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Stockbalance>(entity =>
            {
                entity.ToTable("STOCKBALANCE");

                entity.HasIndex(e => e.Asofdate, "IX_STOCKBALANCE_ASOFDATE");

                entity.HasIndex(e => e.Stocksymbol, "IX_STOCKBALANCE_STOCKSYMBOL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accountno2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO2");

                entity.Property(e => e.Asofdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ASOFDATE");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(32, 3)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Stocksymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STOCKSYMBOL");

                entity.Property(e => e.Stocktype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STOCKTYPE");
            });

            modelBuilder.Entity<Stockduehistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STOCKDUEHISTORY");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Available)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("AVAILABLE");

                entity.Property(e => e.Avgprice)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("AVGPRICE");

                entity.Property(e => e.Mktvalue)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("MKTVALUE");

                entity.Property(e => e.Net)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NET");

                entity.Property(e => e.Stockduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("STOCKDUEDATE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Wtr)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR");

                entity.Property(e => e.WtrT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_T1");

                entity.Property(e => e.WtrT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_T2");

                entity.Property(e => e.WtrT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTR_T3");

                entity.Property(e => e.Wts)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS");

                entity.Property(e => e.WtsT1)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_T1");

                entity.Property(e => e.WtsT2)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_T2");

                entity.Property(e => e.WtsT3)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("WTS_T3");
            });

            modelBuilder.Entity<Stockdueinfo>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STOCKDUEINFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Avaivolume)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("AVAIVOLUME");

                entity.Property(e => e.Avgprice)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("AVGPRICE");

                entity.Property(e => e.Marketprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("MARKETPRICE");

                entity.Property(e => e.Stockduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("STOCKDUEDATE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Wtr)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR");

                entity.Property(e => e.WtrT1)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR_T1");

                entity.Property(e => e.WtrT2)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR_T2");

                entity.Property(e => e.WtrT3)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR_T3");

                entity.Property(e => e.Wts)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS");

                entity.Property(e => e.WtsT1)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS_T1");

                entity.Property(e => e.WtsT2)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS_T2");

                entity.Property(e => e.WtsT3)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS_T3");
            });

            modelBuilder.Entity<Stockdueinfohistory>(entity =>
            {
                entity.ToTable("STOCKDUEINFOHISTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Avaivolume)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("AVAIVOLUME");

                entity.Property(e => e.Avgprice)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("AVGPRICE");

                entity.Property(e => e.Marketprice)
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("MARKETPRICE");

                entity.Property(e => e.Stockduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("STOCKDUEDATE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Wtr)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR");

                entity.Property(e => e.WtrT1)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR_T1");

                entity.Property(e => e.WtrT2)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR_T2");

                entity.Property(e => e.WtrT3)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTR_T3");

                entity.Property(e => e.Wts)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS");

                entity.Property(e => e.WtsT1)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS_T1");

                entity.Property(e => e.WtsT2)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS_T2");

                entity.Property(e => e.WtsT3)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("WTS_T3");
            });

            modelBuilder.Entity<Stockinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKINFO");

                entity.Property(e => e.AveragePrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("AVERAGE_PRICE");

                entity.Property(e => e.BasicPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BASIC_PRICE");

                entity.Property(e => e.CeilingPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("CEILING_PRICE");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FloorPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("FLOOR_PRICE");

                entity.Property(e => e.KeyId).HasColumnName("KEY_ID");

                entity.Property(e => e.MarketCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("MARKET_CODE");

                entity.Property(e => e.MatchPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("MATCH_PRICE");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE");

                entity.Property(e => e.ParValue)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("PAR_VALUE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_CODE");

                entity.Property(e => e.StockName)
                    .HasMaxLength(512)
                    .HasColumnName("STOCK_NAME");

                entity.Property(e => e.StockNo).HasColumnName("STOCK_NO");

                entity.Property(e => e.StockType)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_TYPE");

                entity.Property(e => e.TradingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADING_DATE");

                entity.Property(e => e.TradingUnit)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("TRADING_UNIT");
            });

            modelBuilder.Entity<StockinfoOddlot>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PK__STOCKINF__09FA964EBADE7D37");

                entity.ToTable("STOCKINFO_ODDLOT");

                entity.Property(e => e.KeyId).HasColumnName("KEY_ID");

                entity.Property(e => e.BestBidPrice1)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_BID_PRICE1");

                entity.Property(e => e.BestBidPrice2)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_BID_PRICE2");

                entity.Property(e => e.BestBidPrice3)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_BID_PRICE3");

                entity.Property(e => e.BestBidQtty1)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_BID_QTTY1");

                entity.Property(e => e.BestBidQtty2)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_BID_QTTY2");

                entity.Property(e => e.BestBidQtty3)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_BID_QTTY3");

                entity.Property(e => e.BestOfferPrice1)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_OFFER_PRICE1");

                entity.Property(e => e.BestOfferPrice2)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_OFFER_PRICE2");

                entity.Property(e => e.BestOfferPrice3)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_OFFER_PRICE3");

                entity.Property(e => e.BestOfferQtty1)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_OFFER_QTTY1");

                entity.Property(e => e.BestOfferQtty2)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_OFFER_QTTY2");

                entity.Property(e => e.BestOfferQtty3)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("BEST_OFFER_QTTY3");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MatchPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("MATCH_PRICE");

                entity.Property(e => e.MatchQtty)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("MATCH_QTTY");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("MODIFY_BY");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_CODE");

                entity.Property(e => e.TotalQtty)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("TOTAL_QTTY");

                entity.Property(e => e.TotalValue)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("TOTAL_VALUE");
            });

            modelBuilder.Entity<Stocktran>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STOCKTRANS");

                entity.HasIndex(e => new { e.Accountno2, e.Symbol }, "IX_STOCKTRANS_AccountNo2");

                entity.HasIndex(e => e.Duedate, "IX_STOCKTRANS_DueDate");

                entity.HasIndex(e => e.Reftype, "IX_STOCKTRANS_RefType");

                entity.HasIndex(e => e.Symbol, "IX_STOCKTRANS_SYMBOL");

                entity.HasIndex(e => e.Transdate, "IX_STOCKTRANS_TransDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accountno2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO2");

                entity.Property(e => e.ApprDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPR_DATE_TIME");

                entity.Property(e => e.Authid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTHID");

                entity.Property(e => e.Custtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUSTTYPE");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Reftype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFTYPE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.SeqNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Stocktype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STOCKTYPE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.SynDateTime).HasColumnType("datetime");

                entity.Property(e => e.TranDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_DATE_TIME");

                entity.Property(e => e.TransNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_NO");

                entity.Property(e => e.TransType1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_TYPE1");

                entity.Property(e => e.TransType2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANS_TYPE2");

                entity.Property(e => e.Transdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Stocktransfer>(entity =>
            {
                entity.ToTable("STOCKTRANSFER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Feetype).HasColumnName("FEETYPE");

                entity.Property(e => e.Isnew).HasColumnName("ISNEW");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Receiver)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVER");

                entity.Property(e => e.Refno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REFNO");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Transferdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Stocktransferaccount>(entity =>
            {
                entity.ToTable("STOCKTRANSFERACCOUNT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Stocktransferhistory>(entity =>
            {
                entity.ToTable("STOCKTRANSFERHISTORY");

                entity.HasIndex(e => e.Accountno, "IX_STOCKTRANSFERHISTORY_ACCOUNTNO");

                entity.HasIndex(e => e.Contractno, "IX_STOCKTRANSFERHISTORY_CONTRACTNO");

                entity.HasIndex(e => e.Customerid, "IX_STOCKTRANSFERHISTORY_CUSTOMERID");

                entity.HasIndex(e => e.Symbol, "IX_STOCKTRANSFERHISTORY_SYMBOL");

                entity.HasIndex(e => e.Transferdate, "IX_STOCKTRANSFERHISTORY_TRANSFERDATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Approveid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEID");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVETIME");

                entity.Property(e => e.Contractno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACTNO");

                entity.Property(e => e.Customerid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Edittime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITTIME");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FEE");

                entity.Property(e => e.Feetype).HasColumnName("FEETYPE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("REASON");

                entity.Property(e => e.Receiver)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVER");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Traderid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID");

                entity.Property(e => e.Transferdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSFERDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<Synctokenhistory>(entity =>
            {
                entity.HasKey(e => e.Synctokenid)
                    .IsClustered(false);

                entity.ToTable("SYNCTOKENHISTORY");

                entity.Property(e => e.Synctokenid).HasColumnName("SYNCTOKENID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Syncdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SYNCDATE");

                entity.HasOne(d => d.AccountnoNavigation)
                    .WithMany(p => p.Synctokenhistories)
                    .HasForeignKey(d => d.Accountno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYNCTOKENHISTORY_CUSTOMER");
            });

            modelBuilder.Entity<Systemlog>(entity =>
            {
                entity.HasKey(e => e.Systemlogid)
                    .IsClustered(false);

                entity.ToTable("SYSTEMLOG");

                entity.Property(e => e.Systemlogid).HasColumnName("SYSTEMLOGID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Actiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONDATE");

                entity.Property(e => e.Actiontype).HasColumnName("ACTIONTYPE");

                entity.Property(e => e.Moduleid).HasColumnName("MODULEID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(240)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Tradetrnhist>(entity =>
            {
                entity.ToTable("TRADETRNHIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accountno2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO2");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Commission)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("COMMISSION");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Grossamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("GROSSAMOUNT");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Referno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERNO");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tax)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Unit).HasColumnName("UNIT");
            });

            modelBuilder.Entity<Tradetrnhistbackup>(entity =>
            {
                entity.ToTable("TRADETRNHISTBACKUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accountno2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO2");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Commission)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("COMMISSION");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("DUEDATE");

                entity.Property(e => e.Grossamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("GROSSAMOUNT");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Referno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERNO");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tax)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("TAX");

                entity.Property(e => e.Tradedate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRADEDATE");

                entity.Property(e => e.Unit).HasColumnName("UNIT");
            });

            modelBuilder.Entity<TvsiDanhSachDealLenhTrongNgay>(entity =>
            {
                entity.HasKey(e => e.DanhSachDealLenhTrongNgayId)
                    .HasName("PK__TVSI_DANH_SACH_D__0CE767AE");

                entity.ToTable("TVSI_DANH_SACH_DEAL_LENH_TRONG_NGAY");

                entity.HasIndex(e => e.DanhSachDealLenhTrongNgayId, "U_TVSI_DANH_SACH_DEAL_LENH_TRONG_NGAY")
                    .IsUnique();

                entity.Property(e => e.DanhSachDealLenhTrongNgayId).HasColumnName("danh_sach_deal_lenh_trong_ngay_id");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO")
                    .IsFixedLength();

                entity.Property(e => e.Acctype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Board)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOARD")
                    .IsFixedLength();

                entity.Property(e => e.Brokerno)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BROKERNO")
                    .IsFixedLength();

                entity.Property(e => e.Brokerorderno)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BROKERORDERNO")
                    .IsFixedLength();

                entity.Property(e => e.Cancelflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCELFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Confirmno)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("CONFIRMNO");

                entity.Property(e => e.Contrafirm)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CONTRAFIRM")
                    .IsFixedLength();

                entity.Property(e => e.Custtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUSTTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Dealdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEALDATE")
                    .IsFixedLength();

                entity.Property(e => e.Dealprice)
                    .HasColumnType("decimal(13, 6)")
                    .HasColumnName("DEALPRICE");

                entity.Property(e => e.Dealtime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEALTIME")
                    .IsFixedLength();

                entity.Property(e => e.Dealvolume)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("DEALVOLUME");

                entity.Property(e => e.Dueday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DUEDAY")
                    .IsFixedLength();

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Inserttime)
                    .HasColumnType("datetime")
                    .HasColumnName("INSERTTIME");

                entity.Property(e => e.Mktconfirmno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MKTCONFIRMNO")
                    .IsFixedLength();

                entity.Property(e => e.Mktordno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MKTORDNO")
                    .IsFixedLength();

                entity.Property(e => e.NgaySuaCuoi)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_sua_cuoi");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_tao");

                entity.Property(e => e.NguoiSuaCuoi)
                    .HasMaxLength(50)
                    .HasColumnName("nguoi_sua_cuoi");

                entity.Property(e => e.NguoiTao)
                    .HasMaxLength(50)
                    .HasColumnName("nguoi_tao");

                entity.Property(e => e.Orderno)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("ORDERNO");

                entity.Property(e => e.Orderseqno)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ORDERSEQNO");

                entity.Property(e => e.Putthroughflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUTTHROUGHFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL")
                    .IsFixedLength();

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Updateflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEFLAG")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TvsiDanhSachLenhLichSu>(entity =>
            {
                entity.HasKey(e => e.DanhSachLenhLichSuId)
                    .HasName("PK__TVSI_DANH_SACH_L__0FC3D459");

                entity.ToTable("TVSI_DANH_SACH_LENH_LICH_SU");

                entity.HasIndex(e => e.DanhSachLenhLichSuId, "U_TVSI_DANH_SACH_LENH_LICH_SU")
                    .IsUnique();

                entity.Property(e => e.DanhSachLenhLichSuId).HasColumnName("danh_sach_lenh_lich_su_id");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO")
                    .IsFixedLength();

                entity.Property(e => e.Branchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID")
                    .IsFixedLength();

                entity.Property(e => e.Cancelid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CANCELID")
                    .IsFixedLength();

                entity.Property(e => e.Canceltime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELTIME")
                    .IsFixedLength();

                entity.Property(e => e.Cancelvolume)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Conditionprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITIONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Enterid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ENTERID")
                    .IsFixedLength();

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Matchvalue)
                    .HasColumnType("decimal(17, 6)")
                    .HasColumnName("MATCHVALUE");

                entity.Property(e => e.Matchvolume)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MATCHVOLUME");

                entity.Property(e => e.NgaySuaCuoi)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_sua_cuoi");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_tao");

                entity.Property(e => e.NguoiSuaCuoi)
                    .HasMaxLength(50)
                    .HasColumnName("nguoi_sua_cuoi");

                entity.Property(e => e.NguoiTao)
                    .HasMaxLength(50)
                    .HasColumnName("nguoi_tao");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE")
                    .IsFixedLength();

                entity.Property(e => e.Orderno)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("ORDERNO");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSTATUS")
                    .IsFixedLength();

                entity.Property(e => e.Ordertime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTIME")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 6)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Rejectcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("REJECTCODE")
                    .IsFixedLength();

                entity.Property(e => e.Rejecttext)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REJECTTEXT")
                    .IsFixedLength();

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL")
                    .IsFixedLength();

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Showprice)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SHOWPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Traderid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID")
                    .IsFixedLength();

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<TvsiDanhSachLenhTrongNgay>(entity =>
            {
                entity.HasKey(e => e.DanhSachLenhTrongNgayId)
                    .HasName("PK__TVSI_DANH_SACH_L__12A04104");

                entity.ToTable("TVSI_DANH_SACH_LENH_TRONG_NGAY");

                entity.HasIndex(e => e.DanhSachLenhTrongNgayId, "U_TVSI_DANH_SACH_LENH_TRONG_NGAY")
                    .IsUnique();

                entity.Property(e => e.DanhSachLenhTrongNgayId).HasColumnName("danh_sach_lenh_trong_ngay_id");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO")
                    .IsFixedLength();

                entity.Property(e => e.Branchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID")
                    .IsFixedLength();

                entity.Property(e => e.Cancelid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CANCELID")
                    .IsFixedLength();

                entity.Property(e => e.Canceltime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CANCELTIME")
                    .IsFixedLength();

                entity.Property(e => e.Cancelvolume)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("CANCELVOLUME");

                entity.Property(e => e.Conditionprice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDITIONPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Enterid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ENTERID")
                    .IsFixedLength();

                entity.Property(e => e.Market)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARKET")
                    .IsFixedLength();

                entity.Property(e => e.Matchvalue)
                    .HasColumnType("decimal(17, 6)")
                    .HasColumnName("MATCHVALUE");

                entity.Property(e => e.Matchvolume)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MATCHVOLUME");

                entity.Property(e => e.NgaySuaCuoi)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_sua_cuoi");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_tao");

                entity.Property(e => e.NguoiSuaCuoi)
                    .HasMaxLength(50)
                    .HasColumnName("nguoi_sua_cuoi");

                entity.Property(e => e.NguoiTao)
                    .HasMaxLength(50)
                    .HasColumnName("nguoi_tao");

                entity.Property(e => e.Orderdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ORDERDATE")
                    .IsFixedLength();

                entity.Property(e => e.Orderno)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("ORDERNO");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSTATUS")
                    .IsFixedLength();

                entity.Property(e => e.Ordertime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ORDERTIME")
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(13, 6)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Rejectcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("REJECTCODE")
                    .IsFixedLength();

                entity.Property(e => e.Rejecttext)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REJECTTEXT")
                    .IsFixedLength();

                entity.Property(e => e.Secsymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SECSYMBOL")
                    .IsFixedLength();

                entity.Property(e => e.Servicetype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Showprice)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SHOWPRICE")
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIDE")
                    .IsFixedLength();

                entity.Property(e => e.Traderid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TRADERID")
                    .IsFixedLength();

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<TvsiDuLieuXacNhanLenh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TVSI_DU_LIEU_XAC_NHAN_LENH");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledTime).HasColumnType("datetime");

                entity.Property(e => e.ConfirmCode)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmCodeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ExecutedPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MatchedTime).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.SecSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TpCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TP_CODE");

                entity.Property(e => e.TpStatus).HasColumnName("TP_STATUS");

                entity.Property(e => e.TpUse).HasColumnName("TP_USE");

                entity.Property(e => e.TraderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TraderID");

                entity.Property(e => e.TransTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TvsiThongTinSuaLenh>(entity =>
            {
                entity.HasKey(e => e.ThongTinSuaLenhId);

                entity.ToTable("TVSI_THONG_TIN_SUA_LENH");

                entity.Property(e => e.ThongTinSuaLenhId).HasColumnName("Thong_tin_sua_lenh_ID");

                entity.Property(e => e.GiaCu).HasColumnName("Gia_cu");

                entity.Property(e => e.GiaMoi).HasColumnName("Gia_moi");

                entity.Property(e => e.LenhSua).HasColumnName("Lenh_sua");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_cap_nhat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayGiaoDich)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_giao_dich");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_tao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat)
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_cap_nhat");

                entity.Property(e => e.NguoiTao)
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_tao");

                entity.Property(e => e.SoHieuLenh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("So_hieu_lenh");

                entity.Property(e => e.SoTaiKhoan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("So_tai_khoan");

                entity.Property(e => e.ThoiGianSuaLenh)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Thoi_gian_sua_lenh");

                entity.Property(e => e.TradeIdSuaLenh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TradeID_sua_lenh");
            });

            modelBuilder.Entity<TvsiWatchList>(entity =>
            {
                entity.HasKey(e => e.WatchListId);

                entity.ToTable("TVSI_WATCH_LIST");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Symbols)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.WatchList).HasMaxLength(200);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK_BROKER")
                    .IsClustered(false);

                entity.ToTable("USER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Bousergroupid).HasColumnName("BOUSERGROUPID");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTMODIFIED");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");
            });

            modelBuilder.Entity<Usergroup>(entity =>
            {
                entity.ToTable("USERGROUP");

                entity.Property(e => e.Usergroupid).HasColumnName("USERGROUPID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Groupname)
                    .HasMaxLength(100)
                    .HasColumnName("GROUPNAME");
            });

            modelBuilder.Entity<ViewBoAccountGetBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_BO_ACCOUNT_GetBranch");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Customername)
                    .HasMaxLength(200)
                    .HasColumnName("CUSTOMERNAME");

                entity.Property(e => e.Customerno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMERNO");

                entity.Property(e => e.Identitycard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYCARD");
            });

            modelBuilder.Entity<Workingday>(entity =>
            {
                entity.HasKey(e => e.Workingid)
                    .HasName("PK_WORKINGDATE")
                    .IsClustered(false);

                entity.ToTable("WORKINGDAY");

                entity.Property(e => e.Workingid).HasColumnName("WORKINGID");

                entity.Property(e => e.Iswork).HasColumnName("ISWORK");

                entity.Property(e => e.Workingday1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORKINGDAY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
