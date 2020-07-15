using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PCS.CPMS.BL.Models;
using PCS.CPMS.DAL;
/// <summary>
/// this is a testing
/// </summary>
/// 
/// <exception cref="TESTING 3 TEST1MIKE"
namespace PCS.CPMS.DAL
{
        public partial class tng_cpmsContext : DbContext
        {
            public tng_cpmsContext()
            {
            }

            public tng_cpmsContext(DbContextOptions<tng_cpmsContext> options)
                : base(options)
            {
            }

            public virtual DbSet<Afcaction> Afcaction { get; set; }
            public virtual DbSet<Afcaction1> Afcaction1 { get; set; }
            public virtual DbSet<AfcactionTombstone> AfcactionTombstone { get; set; }
            public virtual DbSet<AlarmMonitor> AlarmMonitor { get; set; }
            public virtual DbSet<AuditTrail> AuditTrail { get; set; }
            public virtual DbSet<BackOutVehicle> BackOutVehicle { get; set; }
            public virtual DbSet<BackOutVehicleTombstone> BackOutVehicleTombstone { get; set; }
            public virtual DbSet<BatchCreationLog> BatchCreationLog { get; set; }
            public virtual DbSet<BatchStatus> BatchStatus { get; set; }
            public virtual DbSet<BayDisplay> BayDisplay { get; set; }
            public virtual DbSet<CctvTrigger> CctvTrigger { get; set; }
            public virtual DbSet<Companies> Companies { get; set; }
            public virtual DbSet<Company> Company { get; set; }
            public virtual DbSet<Contact> Contact { get; set; }
            public virtual DbSet<DayType> DayType { get; set; }
            public virtual DbSet<DeviceType> DeviceType { get; set; }
            public virtual DbSet<DeviceTypeStatus> DeviceTypeStatus { get; set; }
            public virtual DbSet<EventLevel> EventLevel { get; set; }
            public virtual DbSet<EventLog> EventLog { get; set; }
            public virtual DbSet<EventType> EventType { get; set; }
            public virtual DbSet<FailureReason> FailureReason { get; set; }
            public virtual DbSet<FareHour> FareHour { get; set; }
            public virtual DbSet<FareMinutes> FareMinutes { get; set; }
            public virtual DbSet<FareRateDetail> FareRateDetail { get; set; }
            public virtual DbSet<FareRateHeader> FareRateHeader { get; set; }
            public virtual DbSet<FareRateHour> FareRateHour { get; set; }
            public virtual DbSet<FareRateMinutes> FareRateMinutes { get; set; }
            public virtual DbSet<FareRateSettings> FareRateSettings { get; set; }
            public virtual DbSet<FareValidatorSetting> FareValidatorSetting { get; set; }
            public virtual DbSet<HelpPointCctvmapping> HelpPointCctvmapping { get; set; }
            public virtual DbSet<HourlySales> HourlySales { get; set; }
            public virtual DbSet<HoursInDay> HoursInDay { get; set; }
            public virtual DbSet<Lane> Lane { get; set; }
            public virtual DbSet<LaneDevice> LaneDevice { get; set; }
            public virtual DbSet<LaneParameter> LaneParameter { get; set; }
            public virtual DbSet<OperationParameter> OperationParameter { get; set; }
            public virtual DbSet<ParkingLevel> ParkingLevel { get; set; }
            public virtual DbSet<PasswordSetting> PasswordSetting { get; set; }
            public virtual DbSet<Payout> Payout { get; set; }
            public virtual DbSet<Permission> Permission { get; set; }
            public virtual DbSet<Role> Role { get; set; }
            public virtual DbSet<RoleAccess> RoleAccess { get; set; }
            public virtual DbSet<Roles> Roles { get; set; }
            public virtual DbSet<RolesAccess> RolesAccess { get; set; }
            public virtual DbSet<RunningSequences> RunningSequences { get; set; }
            public virtual DbSet<SeasonCard> SeasonCard { get; set; }
            public virtual DbSet<SeasonInvoice> SeasonInvoice { get; set; }
            public virtual DbSet<SeasonPassCard> SeasonPassCard { get; set; }
            public virtual DbSet<SeasonPassCardMaster> SeasonPassCardMaster { get; set; }
            public virtual DbSet<SeasonPassUser> SeasonPassUser { get; set; }
            public virtual DbSet<SeasonPaymentOption> SeasonPaymentOption { get; set; }
            public virtual DbSet<SeasonRate> SeasonRate { get; set; }
            public virtual DbSet<SeasonSetting> SeasonSetting { get; set; }
            public virtual DbSet<SeasonTransaction> SeasonTransaction { get; set; }
            public virtual DbSet<SeasonUser> SeasonUser { get; set; }
            public virtual DbSet<Sequences> Sequences { get; set; }
            public virtual DbSet<Setting> Setting { get; set; }
            public virtual DbSet<Site> Site { get; set; }
            public virtual DbSet<SpParameterStatus> SpParameterStatus { get; set; }
            public virtual DbSet<SpecialDay> SpecialDay { get; set; }
            public virtual DbSet<StringMap> StringMap { get; set; }
            public virtual DbSet<TbSite> TbSite { get; set; }
            public virtual DbSet<TngControlBatch> TngControlBatch { get; set; }
            public virtual DbSet<TngInvalidCard> TngInvalidCard { get; set; }
            public virtual DbSet<TngReloadTxn> TngReloadTxn { get; set; }
            public virtual DbSet<TngReloadTxnError> TngReloadTxnError { get; set; }
            public virtual DbSet<TngUsageTxn> TngUsageTxn { get; set; }
            public virtual DbSet<TngUsageTxnError> TngUsageTxnError { get; set; }
            public virtual DbSet<Transaction> Transaction { get; set; }
            public virtual DbSet<TransactionFailure> TransactionFailure { get; set; }
            public virtual DbSet<TransactionFailureSeasonPass> TransactionFailureSeasonPass { get; set; }
            public virtual DbSet<TransactionMonitor> TransactionMonitor { get; set; }
            public virtual DbSet<TransactionSeasonPass> TransactionSeasonPass { get; set; }
            public virtual DbSet<TransactionValidator> TransactionValidator { get; set; }
            public virtual DbSet<User> User { get; set; }
            public virtual DbSet<Users> Users { get; set; }
            public virtual DbSet<VehicleClass> VehicleClass { get; set; }
            public virtual DbSet<WeekDay> WeekDay { get; set; }
            public virtual DbSet<Zone> Zone { get; set; }

//            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            {
//                if (!optionsBuilder.IsConfigured)
//                {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                    optionsBuilder.UseSqlServer("server=LAPTOP-EG0VQGMH;Database=tng_cpms_1;Trusted_Connection=True;");
//                }
//            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                modelBuilder.Entity<Afcaction>(entity =>
                {
                    entity.HasNoKey();

                    entity.ToView("AFCAction");

                    entity.Property(e => e.ActionId).HasColumnName("ActionID");

                    entity.Property(e => e.ActionTime).HasColumnType("datetime");

                    entity.Property(e => e.Authorized).HasMaxLength(100);

                    entity.Property(e => e.CardNo)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.CreationDate).HasColumnType("datetime");

                    entity.Property(e => e.LaneCode)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                    entity.Property(e => e.RefusalMessage).HasMaxLength(100);

                    entity.Property(e => e.SerialNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.Usage)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.VehicleClass)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();
                });

                modelBuilder.Entity<Afcaction1>(entity =>
                {
                    entity.HasKey(e => e.ActionId)
                        .HasName("PK_AfcAction");

                    entity.ToTable("AFCAction1");

                    entity.Property(e => e.ActionId)
                        .HasColumnName("ActionID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.ActionTime).HasColumnType("datetime");

                    entity.Property(e => e.Authorized)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CardNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.LaneCode)
                        .IsRequired()
                        .HasMaxLength(7)
                        .IsUnicode(false);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.RefusalMessage)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.SerialNo)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Usage)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.VehicleClass)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();
                });

                modelBuilder.Entity<AfcactionTombstone>(entity =>
                {
                    entity.HasKey(e => e.ActionId)
                        .HasName("PKDEL_AFCAction_Tombstone_ActionID");

                    entity.ToTable("AFCAction_Tombstone");

                    entity.Property(e => e.ActionId)
                        .HasColumnName("ActionID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.DeletionDate).HasColumnType("datetime");
                });

                modelBuilder.Entity<AlarmMonitor>(entity =>
                {
                    entity.HasNoKey();

                    entity.ToView("AlarmMonitor");

                    entity.Property(e => e.Description).HasMaxLength(150);

                    entity.Property(e => e.Device).HasMaxLength(150);

                    entity.Property(e => e.EventDate).HasColumnType("datetime");

                    entity.Property(e => e.EventId).HasColumnName("EventID");

                    entity.Property(e => e.EventLevel)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.EventTypeCode)
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ZoneName).HasMaxLength(50);
                });

                modelBuilder.Entity<AuditTrail>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.AuditDetails).HasColumnName("Audit_Details");

                    entity.Property(e => e.AuditType)
                        .HasColumnName("Audit_Type")
                        .HasMaxLength(15);

                    entity.Property(e => e.CpmsMenu)
                        .HasColumnName("CPMS_Menu")
                        .HasMaxLength(50);

                    entity.Property(e => e.LastUpdIpadd)
                        .HasColumnName("LastUpdIPAdd")
                        .HasMaxLength(15);

                    entity.Property(e => e.LastUpdTime).HasColumnType("datetime");

                    entity.Property(e => e.LastUpdUserId)
                        .HasColumnName("LastUpdUserID")
                        .HasMaxLength(15);
                });

                modelBuilder.Entity<BackOutVehicle>(entity =>
                {
                    entity.Property(e => e.BackOutVehicleId)
                        .HasColumnName("BackOutVehicleID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.SerialNo)
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<BackOutVehicleTombstone>(entity =>
                {
                    entity.HasKey(e => e.BackOutVehicleId)
                        .HasName("PKDEL_BackOutVehicle_Tombstone_BackOutVehicleID");

                    entity.ToTable("BackOutVehicle_Tombstone");

                    entity.Property(e => e.BackOutVehicleId)
                        .HasColumnName("BackOutVehicleID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.DeletionDate).HasColumnType("datetime");
                });

                modelBuilder.Entity<BatchCreationLog>(entity =>
                {
                    entity.HasKey(e => e.BatchId);

                    entity.Property(e => e.BatchId).HasColumnName("BatchID");

                    entity.Property(e => e.BatchDate).HasColumnType("date");

                    entity.Property(e => e.BatchFileName)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.BatchNumber)
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    entity.Property(e => e.BatchType)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    entity.Property(e => e.CreationDate).HasColumnType("datetime");

                    entity.Property(e => e.JobNo)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ParkAideUploadStatus)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                    entity.Property(e => e.SiteId).HasColumnName("SiteID");

                    entity.Property(e => e.Spid)
                        .HasColumnName("SPID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.TerminalId)
                        .HasColumnName("TerminalID")
                        .HasMaxLength(3)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<BatchStatus>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.Bojdatetime, e.Jobno, e.Batchtrantype });

                    entity.ToTable("BATCH_STATUS");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Bojdatetime)
                        .HasColumnName("BOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Jobno).HasColumnName("JOBNO");

                    entity.Property(e => e.Batchtrantype)
                        .HasColumnName("BATCHTRANTYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.BatchStatus1)
                        .HasColumnName("BATCH_STATUS")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.Batchno).HasColumnName("BATCHNO");

                    entity.Property(e => e.DateEntered)
                        .HasColumnName("DATE_ENTERED")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.Eojdatetime)
                        .HasColumnName("EOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.HashTotalNpurse)
                        .HasColumnName("HASH_TOTAL_NPURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.HashTotalPurse)
                        .HasColumnName("HASH_TOTAL_PURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.JobType)
                        .HasColumnName("JOB_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.OperationMode)
                        .HasColumnName("OPERATION_MODE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.Operdate)
                        .HasColumnName("OPERDATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.RecordCount).HasColumnName("RECORD_COUNT");

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.TerminalType)
                        .HasColumnName("TERMINAL_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.TotalCreditNpurse)
                        .HasColumnName("TOTAL_CREDIT_NPURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.TotalCreditPurse)
                        .HasColumnName("TOTAL_CREDIT_PURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.TotalDebitNpurse)
                        .HasColumnName("TOTAL_DEBIT_NPURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.TotalDebitPurse)
                        .HasColumnName("TOTAL_DEBIT_PURSE")
                        .HasColumnType("decimal(8, 2)");
                });

                modelBuilder.Entity<BayDisplay>(entity =>
                {
                    entity.Property(e => e.BayDisplayId).HasColumnName("BayDisplayID");

                    entity.Property(e => e.CreatedBy).HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.DisplayName)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.PortName).HasMaxLength(5);

                    entity.Property(e => e.UnitAddress).HasMaxLength(50);
                });

                modelBuilder.Entity<CctvTrigger>(entity =>
                {
                    entity.HasNoKey();

                    entity.ToView("CctvTrigger");

                    entity.Property(e => e.HelpPoint).HasMaxLength(203);

                    entity.Property(e => e.Ip)
                        .HasColumnName("IP")
                        .HasMaxLength(203);

                    entity.Property(e => e.Port).HasMaxLength(203);

                    entity.Property(e => e.Status).HasMaxLength(100);

                    entity.Property(e => e.TriggerTime).HasColumnType("datetime");
                });

                modelBuilder.Entity<Companies>(entity =>
                {
                    entity.HasNoKey();

                    entity.Property(e => e.CompanyAddress).HasMaxLength(150);

                    entity.Property(e => e.CompanyBankAccountName).HasMaxLength(30);

                    entity.Property(e => e.CompanyBankAccountNo).HasMaxLength(30);

                    entity.Property(e => e.CompanyBankName).HasMaxLength(100);

                    entity.Property(e => e.CompanyName)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CompanyRegistrationNo).HasMaxLength(50);

                    entity.Property(e => e.ContactNo).HasMaxLength(50);

                    entity.Property(e => e.CreatedBy).HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.SstId)
                        .HasColumnName("SstID")
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<Company>(entity =>
                {
                    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                    entity.Property(e => e.CompanyAddress)
                        .IsRequired()
                        .HasMaxLength(150);

                    entity.Property(e => e.CompanyName)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CompanyRegistrationNo)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ContactNo)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.SstId)
                        .IsRequired()
                        .HasColumnName("SstID")
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<Contact>(entity =>
                {
                    entity.Property(e => e.Id)
                        .HasColumnName("ID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.ContactAddress)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.ContactCompany)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.ContactCompanyAddress)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.ContactCompanyPhone).HasMaxLength(20);

                    entity.Property(e => e.ContactImage).IsRequired();

                    entity.Property(e => e.ContactName)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.ContactPhone)
                        .IsRequired()
                        .HasMaxLength(20);

                    entity.Property(e => e.ContactTitle)
                        .IsRequired()
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<DayType>(entity =>
                {
                    entity.HasIndex(e => e.DayType1)
                        .HasName("UK_DayType")
                        .IsUnique();

                    entity.Property(e => e.DayTypeId).HasColumnName("DayTypeID");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.DayType1)
                        .IsRequired()
                        .HasColumnName("DayType")
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
                });

                modelBuilder.Entity<DeviceType>(entity =>
                {
                    entity.Property(e => e.DeviceTypeId)
                        .HasColumnName("DeviceTypeID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.DeviceType1)
                        .IsRequired()
                        .HasColumnName("DeviceType")
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<DeviceTypeStatus>(entity =>
                {
                    entity.HasNoKey();

                    entity.Property(e => e.DeviceTypeId).HasColumnName("DeviceTypeID");

                    entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                    entity.Property(e => e.ResourceName)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.Status)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.HasOne(d => d.DeviceType)
                        .WithMany()
                        .HasForeignKey(d => d.DeviceTypeId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DeviceTypeStatus_DeviceType");
                });

                modelBuilder.Entity<EventLevel>(entity =>
                {
                    entity.HasKey(e => e.EventLevelCode);

                    entity.Property(e => e.EventLevelCode)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.AckColor).HasMaxLength(50);

                    entity.Property(e => e.Color).HasMaxLength(50);

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.EventLevel1)
                        .IsRequired()
                        .HasColumnName("EventLevel")
                        .HasMaxLength(50);

                    entity.Property(e => e.EventLog)
                        .IsRequired()
                        .HasDefaultValueSql("((1))");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
                });

                modelBuilder.Entity<EventLog>(entity =>
                {
                    entity.HasKey(e => e.EventId)
                        .HasName("PK_EventLog1");

                    entity.Property(e => e.EventId)
                        .HasColumnName("EventID")
                        .HasDefaultValueSql("(newid())");

                    entity.Property(e => e.Comment)
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.DeviceTypeId).HasColumnName("DeviceTypeID");

                    entity.Property(e => e.EventDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.EventTypeCode)
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.LaneCode)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                    entity.Property(e => e.Mute).HasDefaultValueSql("((0))");

                    entity.Property(e => e.Parameters)
                        .IsRequired()
                        .HasMaxLength(200);

                    entity.Property(e => e.ZoneCode)
                        .IsRequired()
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<EventType>(entity =>
                {
                    entity.HasKey(e => e.EventTypeCode)
                        .HasName("PK_EventType1");

                    entity.Property(e => e.EventTypeCode)
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.Description).HasMaxLength(50);

                    entity.Property(e => e.EventGroup).HasMaxLength(15);

                    entity.Property(e => e.EventLevel)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.EventSource).HasMaxLength(10);

                    entity.Property(e => e.LogFlag)
                        .IsRequired()
                        .HasDefaultValueSql("((1))");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
                });

                modelBuilder.Entity<FailureReason>(entity =>
                {
                    entity.HasKey(e => new { e.FailureCode, e.Category })
                        .HasName("PK_FailReason");

                    entity.Property(e => e.FailureCode)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Category)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Description)
                        .HasMaxLength(100)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<FareHour>(entity =>
                {
                    entity.Property(e => e.FareHourId).HasColumnName("FareHourID");

                    entity.Property(e => e.FareRateId).HasColumnName("FareRateID");
                });

                modelBuilder.Entity<FareMinutes>(entity =>
                {
                    entity.HasKey(e => e.FareMinId);

                    entity.Property(e => e.FareMinId).HasColumnName("FareMinID");

                    entity.Property(e => e.FareLineId).HasColumnName("FareLineID");

                    entity.Property(e => e.FareRateDetailId).HasColumnName("FareRateDetailID");
                });

                modelBuilder.Entity<FareRateDetail>(entity =>
                {
                    entity.HasKey(e => e.FareLineId)
                        .HasName("PK_FareRateDetails");

                    entity.Property(e => e.FareLineId).HasColumnName("FareLineID");

                    entity.Property(e => e.DefaultFareCalc).HasDefaultValueSql("((0))");

                    entity.Property(e => e.FareMode)
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    entity.Property(e => e.FareRateId).HasColumnName("FareRateID");

                    entity.Property(e => e.FromTime)
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.ToTime)
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.HasOne(d => d.FareRate)
                        .WithMany(p => p.FareRateDetail)
                        .HasForeignKey(d => d.FareRateId)
                        .HasConstraintName("FK_FareRateDetail_FareRateHeader");
                });

                modelBuilder.Entity<FareRateHeader>(entity =>
                {
                    entity.HasKey(e => e.FareRateId)
                        .HasName("PK_FareRateHeader_1");

                    entity.Property(e => e.FareRateId).HasColumnName("FareRateID");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.DayTypeId).HasColumnName("DayTypeID");

                    entity.Property(e => e.HasBackOffPenalty).HasDefaultValueSql("((0))");

                    entity.Property(e => e.HasEntryMismatchPenalty).HasDefaultValueSql("((0))");

                    entity.Property(e => e.HasExitMismatchPenalty).HasDefaultValueSql("((0))");

                    entity.Property(e => e.HasOvernightCharge).HasDefaultValueSql("((0))");

                    entity.Property(e => e.HasPassThroughFee).HasDefaultValueSql("((0))");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.VehicleClassId).HasColumnName("VehicleClassID");
                });

                modelBuilder.Entity<FareRateHour>(entity =>
                {
                    entity.HasNoKey();

                    entity.Property(e => e.Fare).HasColumnName("fare");

                    entity.Property(e => e.FareRateHourId)
                        .HasColumnName("FareRateHourID")
                        .ValueGeneratedOnAdd();

                    entity.Property(e => e.FareRateId).HasColumnName("FareRateID");

                    entity.Property(e => e.Initial).HasColumnName("initial");
                });

                modelBuilder.Entity<FareRateMinutes>(entity =>
                {
                    entity.HasKey(e => e.FareMinuteId);

                    entity.Property(e => e.FareMinuteId).HasColumnName("FareMinuteID");

                    entity.Property(e => e.Fare).HasColumnName("fare");

                    entity.Property(e => e.FareRateId).HasColumnName("FareRateID");

                    entity.Property(e => e.Initial).HasColumnName("initial");
                });

                modelBuilder.Entity<FareRateSettings>(entity =>
                {
                    entity.HasKey(e => e.FareRateSettingId);

                    entity.Property(e => e.AfterWorkingHourChargeType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.AfterWorkingHourTime)
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.EnableAfterWorkingCharge)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.EnableFirstNextCharge)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.EnableMaxCharge)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.EnableParkValidation)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.FareChargeType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.FareRateId).HasColumnName("FareRateID");

                    entity.Property(e => e.FareType)
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.MaxChargeType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.MaxValidateChargeType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.WorkingHourTime)
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .IsFixedLength();
                });

                modelBuilder.Entity<FareValidatorSetting>(entity =>
                {
                    entity.HasKey(e => e.FareValidatorId);

                    entity.Property(e => e.FareValidatorId)
                        .HasColumnName("FareValidatorID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.EnableParkValidation)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.LaneCode)
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.OverGraceCharge)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ValidateTypeCharge)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.WeekdayRateId).HasColumnName("WeekdayRateID");

                    entity.Property(e => e.WeekendRateId).HasColumnName("WeekendRateID");
                });

                modelBuilder.Entity<HelpPointCctvmapping>(entity =>
                {
                    entity.ToTable("HelpPointCCTVMapping");

                    entity.Property(e => e.HelpPointCctvmappingId).HasColumnName("HelpPointCCTVMappingID");

                    entity.Property(e => e.Cctvipaddress)
                        .IsRequired()
                        .HasColumnName("CCTVIPAddress")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    entity.Property(e => e.Cctvport)
                        .IsRequired()
                        .HasColumnName("CCTVPort")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    entity.Property(e => e.Command)
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.Description)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.HelpPoint)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
                });

                modelBuilder.Entity<HourlySales>(entity =>
                {
                    entity.HasNoKey();

                    entity.ToView("HourlySales");

                    entity.Property(e => e.ExitLane)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.FareGst).HasColumnName("FareGST");

                    entity.Property(e => e.SuccessFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.SurchargeGst).HasColumnName("SurchargeGST");

                    entity.Property(e => e.TimeFrom).HasColumnType("datetime");

                    entity.Property(e => e.TimeTo).HasColumnType("datetime");

                    entity.Property(e => e.TransactionTime).HasColumnType("datetime");
                });

                modelBuilder.Entity<HoursInDay>(entity =>
                {
                    entity.HasNoKey();

                    entity.ToView("HoursInDay");
                });

                modelBuilder.Entity<Lane>(entity =>
                {
                    entity.HasKey(e => e.LaneCode)
                        .HasName("PK_Device");

                    entity.Property(e => e.LaneCode)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ConsoleIpaddress)
                        .IsRequired()
                        .HasColumnName("ConsoleIPAddress")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    entity.Property(e => e.ConsoleUpdate).HasColumnType("datetime");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.DefaultLanguage)
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.IconLocation)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.IconSize)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.LaneMode)
                        .IsRequired()
                        .HasMaxLength(5);

                    entity.Property(e => e.LaneName)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.MonitorConsole)
                        .IsRequired()
                        .HasDefaultValueSql("((1))");

                    entity.Property(e => e.Mute)
                        .IsRequired()
                        .HasDefaultValueSql("((1))");

                    entity.Property(e => e.ParkingLevelId).HasColumnName("ParkingLevelID");

                    entity.Property(e => e.ReaderId)
                        .HasColumnName("ReaderID")
                        .HasMaxLength(10);

                    entity.Property(e => e.Status)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('Out Order')");

                    entity.Property(e => e.ZoneCode)
                        .HasMaxLength(10)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<LaneDevice>(entity =>
                {
                    entity.Property(e => e.LaneDeviceId).HasColumnName("LaneDeviceID");

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.DeviceTypeId).HasColumnName("DeviceTypeID");

                    entity.Property(e => e.LaneCode)
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.Status)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('-')");

                    entity.HasOne(d => d.DeviceType)
                        .WithMany(p => p.LaneDevice)
                        .HasForeignKey(d => d.DeviceTypeId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LaneDevice_DeviceType");

                    entity.HasOne(d => d.LaneCodeNavigation)
                        .WithMany(p => p.LaneDevice)
                        .HasForeignKey(d => d.LaneCode)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LaneDevice_Lane");
                });

                modelBuilder.Entity<LaneParameter>(entity =>
                {
                    entity.HasKey(e => e.LaneParamId);

                    entity.Property(e => e.LaneParamId)
                        .HasColumnName("LaneParamID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.LaneCode)
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.ParamCode)
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ParamValue)
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.HasOne(d => d.LaneCodeNavigation)
                        .WithMany(p => p.LaneParameter)
                        .HasForeignKey(d => d.LaneCode)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LaneParameter_Lane");

                    entity.HasOne(d => d.ParamCodeNavigation)
                        .WithMany(p => p.LaneParameter)
                        .HasForeignKey(d => d.ParamCode)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LaneParameter_OperationParameter");
                });

                modelBuilder.Entity<OperationParameter>(entity =>
                {
                    entity.HasKey(e => e.ParamCode);

                    entity.Property(e => e.ParamCode)
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.Description).HasMaxLength(100);

                    entity.Property(e => e.ParamName)
                        .IsRequired()
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<ParkingLevel>(entity =>
                {
                    entity.Property(e => e.ParkingLevelId).HasColumnName("ParkingLevelID");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.LaneCode).HasMaxLength(100);

                    entity.Property(e => e.LevelCode)
                        .IsRequired()
                        .HasMaxLength(10);

                    entity.Property(e => e.LevelName).HasMaxLength(50);

                    entity.Property(e => e.LevelPicture).HasColumnType("image");

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.ZoneCode)
                        .IsRequired()
                        .HasMaxLength(3);
                });

                modelBuilder.Entity<PasswordSetting>(entity =>
                {
                    entity.Property(e => e.PasswordSettingId).HasColumnName("PasswordSettingID");

                    entity.Property(e => e.PasswordSettingName)
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<Payout>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                    entity.Property(e => e.BankReferenceNo)
                        .HasMaxLength(50)
                        .IsFixedLength();

                    entity.Property(e => e.CreatedBy)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.Receipt).HasColumnType("text");

                    entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                    entity.Property(e => e.Settlement).HasColumnType("text");
                });

                modelBuilder.Entity<Permission>(entity =>
                {
                    entity.Property(e => e.PermissionId)
                        .HasColumnName("PermissionID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                    entity.Property(e => e.Module)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.Title).HasMaxLength(50);
                });

                modelBuilder.Entity<Role>(entity =>
                {
                    entity.Property(e => e.RoleId).HasColumnName("RoleID");

                    entity.Property(e => e.ChangePassword).HasDefaultValueSql("((0))");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.RoleName).HasMaxLength(50);
                });

                modelBuilder.Entity<RoleAccess>(entity =>
                {
                    entity.HasKey(e => new { e.RoleId, e.PermissionId });

                    entity.Property(e => e.RoleId).HasColumnName("RoleID");

                    entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                    entity.Property(e => e.AccessMode)
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength()
                        .HasDefaultValueSql("((0))");

                    entity.HasOne(d => d.Permission)
                        .WithMany(p => p.RoleAccess)
                        .HasForeignKey(d => d.PermissionId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_RoleAccess_Permission");

                    entity.HasOne(d => d.Role)
                        .WithMany(p => p.RoleAccess)
                        .HasForeignKey(d => d.RoleId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_RoleAccess_Role");
                });

                modelBuilder.Entity<Roles>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.RoleName).HasMaxLength(50);
                });

                modelBuilder.Entity<RolesAccess>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.RoleId).HasColumnName("RoleID");

                    entity.Property(e => e.SiteId).HasColumnName("SiteID");
                });

                modelBuilder.Entity<RunningSequences>(entity =>
                {
                    entity.HasKey(e => e.ReaderId);

                    entity.ToTable("Running_Sequences");

                    entity.Property(e => e.ReaderId)
                        .HasColumnName("ReaderID")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.SeqBatch).HasColumnName("SEQ_BATCH");

                    entity.Property(e => e.SeqBl).HasColumnName("SEQ_BL");

                    entity.Property(e => e.SeqFn).HasColumnName("SEQ_FN");
                });

                modelBuilder.Entity<SeasonCard>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.CardExpiryDate).HasColumnType("datetime");

                    entity.Property(e => e.CardNo)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.ParkingLevelId).HasColumnName("ParkingLevelID");

                    entity.Property(e => e.PlateNo)
                        .IsRequired()
                        .HasMaxLength(15);

                    entity.Property(e => e.ReservedBayNo).HasMaxLength(10);

                    entity.Property(e => e.SeasonRateId).HasColumnName("SeasonRateID");

                    entity.Property(e => e.SeasonUserId).HasColumnName("SeasonUserID");

                    entity.HasOne(d => d.ParkingLevel)
                        .WithMany(p => p.SeasonCard)
                        .HasForeignKey(d => d.ParkingLevelId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeasonCard_ParkingLevel");

                    entity.HasOne(d => d.SeasonUser)
                        .WithMany(p => p.SeasonCard)
                        .HasForeignKey(d => d.SeasonUserId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeasonCard_SeasonUser");
                });

                modelBuilder.Entity<SeasonInvoice>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                    entity.Property(e => e.InvoiceNo)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.SeasonCardId).HasColumnName("SeasonCardID");

                    entity.Property(e => e.SeasonRateId).HasColumnName("SeasonRateID");

                    entity.Property(e => e.SeasonUserId).HasColumnName("SeasonUserID");
                });

                modelBuilder.Entity<SeasonPassCard>(entity =>
                {
                    entity.ToTable("SeasonPass_Card");

                    entity.Property(e => e.CardNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.CardType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                    entity.Property(e => e.SeasonPassUserId)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.SeasonPassUserName)
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<SeasonPassCardMaster>(entity =>
                {
                    entity.HasNoKey();

                    entity.ToTable("SeasonPass_CardMaster");

                    entity.Property(e => e.CardNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<SeasonPassUser>(entity =>
                {
                    entity.ToTable("SeasonPass_User");

                    entity.Property(e => e.Id).HasColumnName("id");

                    entity.Property(e => e.CompanyName)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ContactNo)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.DisableFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.IdentificationNo)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.UnitNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.UserId)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.UserName)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.UserType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();
                });

                modelBuilder.Entity<SeasonPaymentOption>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.CreatedBy).HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.Description).HasMaxLength(100);

                    entity.Property(e => e.ModifyBy).HasMaxLength(50);

                    entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                    entity.Property(e => e.PaymentTypeName)
                        .IsRequired()
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<SeasonRate>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.CreatedBy).HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                    entity.Property(e => e.Description).HasMaxLength(200);

                    entity.Property(e => e.ModifyBy).HasMaxLength(50);

                    entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                    entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.SeasonPaymentOptionId).HasColumnName("SeasonPaymentOptionID");

                    entity.Property(e => e.SeasonRateName).HasMaxLength(50);

                    entity.HasOne(d => d.SeasonPaymentOption)
                        .WithMany(p => p.SeasonRate)
                        .HasForeignKey(d => d.SeasonPaymentOptionId)
                        .HasConstraintName("FK_SeasonRate_SeasonPaymentOption");
                });

                modelBuilder.Entity<SeasonSetting>(entity =>
                {
                    entity.HasKey(e => e.SettingId);

                    entity.Property(e => e.CreatedBy)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.Description)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ModifiedBy)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.Name)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.SettingValue)
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<SeasonTransaction>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.AuthCode).HasMaxLength(20);

                    entity.Property(e => e.Ccname)
                        .HasColumnName("CCName")
                        .HasMaxLength(200);

                    entity.Property(e => e.Ccno)
                        .HasColumnName("CCNo")
                        .HasMaxLength(16);

                    entity.Property(e => e.Currency).HasMaxLength(5);

                    entity.Property(e => e.ErrDesc).HasMaxLength(100);

                    entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                    entity.Property(e => e.Lang).HasMaxLength(50);

                    entity.Property(e => e.MerchantCode).HasMaxLength(20);

                    entity.Property(e => e.PaymentGateway)
                        .IsRequired()
                        .HasMaxLength(25);

                    entity.Property(e => e.ProdDesc).HasMaxLength(100);

                    entity.Property(e => e.RefNo)
                        .IsRequired()
                        .HasMaxLength(30);

                    entity.Property(e => e.Remark).HasMaxLength(100);

                    entity.Property(e => e.RequestSignature).HasMaxLength(100);

                    entity.Property(e => e.SBankname)
                        .HasColumnName("S_bankname")
                        .HasMaxLength(100);

                    entity.Property(e => e.SCountry)
                        .HasColumnName("S_country")
                        .HasMaxLength(100);

                    entity.Property(e => e.SeasonCardId).HasColumnName("SeasonCardID");

                    entity.Property(e => e.SeasonRateId).HasColumnName("SeasonRateID");

                    entity.Property(e => e.SeasonUserId).HasColumnName("SeasonUserID");

                    entity.Property(e => e.Signature).HasMaxLength(100);

                    entity.Property(e => e.SignatureType).HasMaxLength(50);

                    entity.Property(e => e.SiteId).HasColumnName("SiteID");

                    entity.Property(e => e.TransId).HasMaxLength(30);

                    entity.Property(e => e.TransactionAmount).HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.TransactionTime).HasColumnType("datetime");

                    entity.Property(e => e.UserContact).HasMaxLength(50);

                    entity.Property(e => e.UserEmail).HasMaxLength(50);

                    entity.Property(e => e.UserName).HasMaxLength(50);

                    entity.HasOne(d => d.SeasonCard)
                        .WithMany(p => p.SeasonTransaction)
                        .HasForeignKey(d => d.SeasonCardId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeasonTransaction_SeasonCard");

                    entity.HasOne(d => d.SeasonRate)
                        .WithMany(p => p.SeasonTransaction)
                        .HasForeignKey(d => d.SeasonRateId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeasonTransaction_SeasonRate");

                    entity.HasOne(d => d.SeasonUser)
                        .WithMany(p => p.SeasonTransaction)
                        .HasForeignKey(d => d.SeasonUserId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeasonTransaction_SeasonUser");
                });

                modelBuilder.Entity<SeasonUser>(entity =>
                {
                    entity.HasIndex(e => e.IdentityNo)
                        .HasName("UQ__SeasonUs__30655EAEBF07D420")
                        .IsUnique();

                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.Address).HasMaxLength(200);

                    entity.Property(e => e.BillingAddress).HasMaxLength(200);

                    entity.Property(e => e.BillingName).HasMaxLength(100);

                    entity.Property(e => e.BlockNo).HasMaxLength(30);

                    entity.Property(e => e.ContactNo).HasMaxLength(50);

                    entity.Property(e => e.CreatedBy).HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.DrivingLicense).HasMaxLength(50);

                    entity.Property(e => e.EmailAddress).HasMaxLength(100);

                    entity.Property(e => e.IdentityNo)
                        .IsRequired()
                        .HasMaxLength(20);

                    entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                    entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.Password)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.PasswordChangeDate).HasColumnType("datetime");

                    entity.Property(e => e.UnitNo).HasMaxLength(10);
                });

                modelBuilder.Entity<Sequences>(entity =>
                {
                    entity.HasKey(e => e.Name);

                    entity.Property(e => e.Name)
                        .HasColumnName("name")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    entity.Property(e => e.Value).HasColumnName("value");
                });

                modelBuilder.Entity<Setting>(entity =>
                {
                    entity.Property(e => e.SettingId)
                        .HasColumnName("SettingID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.Description).HasMaxLength(100);

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.SettingValue).HasMaxLength(1000);
                });

                modelBuilder.Entity<Site>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                    entity.Property(e => e.CreatedBy).HasMaxLength(30);

                    entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                    entity.Property(e => e.EnrollDate).HasColumnType("datetime");

                    entity.Property(e => e.LastUpdatedBy).HasMaxLength(30);

                    entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                    entity.Property(e => e.LocationId)
                        .IsRequired()
                        .HasColumnName("LocationID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Mdr).HasColumnName("MDR");

                    entity.Property(e => e.MonthlyLaneCharge).HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Podate)
                        .HasColumnName("PODate")
                        .HasColumnType("datetime");

                    entity.Property(e => e.SiteBankAccountName).HasMaxLength(30);

                    entity.Property(e => e.SiteBankAccountNo).HasMaxLength(30);

                    entity.Property(e => e.SiteBankName).HasMaxLength(100);

                    entity.Property(e => e.SiteContactPersonEmail).HasMaxLength(50);

                    entity.Property(e => e.SiteContactPersonName).HasMaxLength(50);

                    entity.Property(e => e.SiteContactPersonTelNo).HasMaxLength(30);

                    entity.Property(e => e.Tngrate).HasColumnName("TNGRate");

                    entity.Property(e => e.TngrateMargin).HasColumnName("TNGRateMargin");
                });

                modelBuilder.Entity<SpParameterStatus>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.TerminalParmType, e.TerminalParmVersion, e.TerminalParmCreatedDate });

                    entity.ToTable("SP_PARAMETER_STATUS");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.TerminalParmType)
                        .HasColumnName("TERMINAL_PARM_TYPE")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    entity.Property(e => e.TerminalParmVersion).HasColumnName("TERMINAL_PARM_VERSION");

                    entity.Property(e => e.TerminalParmCreatedDate)
                        .HasColumnName("TERMINAL_PARM_CREATED_DATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.SiteParmCapturedDate)
                        .HasColumnName("SITE_PARM_CAPTURED_DATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.SiteParmCreatedDate)
                        .HasColumnName("SITE_PARM_CREATED_DATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.SiteParmType)
                        .HasColumnName("SITE_PARM_TYPE")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    entity.Property(e => e.SiteParmVersion).HasColumnName("SITE_PARM_VERSION");

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.TerminalParmCapturedDate)
                        .HasColumnName("TERMINAL_PARM_CAPTURED_DATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.TerminalParmStatus)
                        .HasColumnName("TERMINAL_PARM_STATUS")
                        .HasMaxLength(15)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<SpecialDay>(entity =>
                {
                    entity.Property(e => e.SpecialDayId).HasColumnName("SpecialDayID");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.SpecialDate).HasColumnType("datetime");

                    entity.Property(e => e.SpecialDayName)
                        .IsRequired()
                        .HasMaxLength(50);
                });

                modelBuilder.Entity<StringMap>(entity =>
                {
                    entity.Property(e => e.AttributeCode)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.AttributeText)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.AttributeValue)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");
                });

                modelBuilder.Entity<TbSite>(entity =>
                {
                    entity.ToTable("TB_SITE");

                    entity.Property(e => e.Id)
                        .HasColumnName("ID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.Ccrate).HasColumnName("CCRate");

                    entity.Property(e => e.CcrateMargin).HasColumnName("CCRateMargin");

                    entity.Property(e => e.ClientId).HasColumnName("ClientID");

                    entity.Property(e => e.CompanyBankAccountName).HasMaxLength(30);

                    entity.Property(e => e.CompanyBankAccountNo).HasMaxLength(30);

                    entity.Property(e => e.CompanyBankName).HasMaxLength(100);

                    entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                    entity.Property(e => e.EnrollDate).HasColumnType("date");

                    entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                    entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                    entity.Property(e => e.MonthlyLaneCharge).HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.Podate)
                        .HasColumnName("PODate")
                        .HasColumnType("date");

                    entity.Property(e => e.SiteBankAccountName).HasMaxLength(30);

                    entity.Property(e => e.SiteBankAccountNo).HasMaxLength(30);

                    entity.Property(e => e.SiteBankName).HasMaxLength(100);

                    entity.Property(e => e.SiteContactPersonEmail).HasMaxLength(50);

                    entity.Property(e => e.SiteContactPersonName).HasMaxLength(50);

                    entity.Property(e => e.SiteContactPersonTelNo).HasMaxLength(30);

                    entity.Property(e => e.Tngrate).HasColumnName("TNGRate");

                    entity.Property(e => e.TngrateMargin).HasColumnName("TNGRateMargin");
                });

                modelBuilder.Entity<TngControlBatch>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.Bojdatetime, e.Jobno, e.Batchtrantype });

                    entity.ToTable("TNG_CONTROL_BATCH");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Bojdatetime)
                        .HasColumnName("BOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Jobno).HasColumnName("JOBNO");

                    entity.Property(e => e.Batchtrantype)
                        .HasColumnName("BATCHTRANTYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.BatchStatus)
                        .HasColumnName("BATCH_STATUS")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.Batchno).HasColumnName("BATCHNO");

                    entity.Property(e => e.Eojdatetime)
                        .HasColumnName("EOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.HashTotalNpurse)
                        .HasColumnName("HASH_TOTAL_NPURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.HashTotalPurse)
                        .HasColumnName("HASH_TOTAL_PURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.JobType)
                        .HasColumnName("JOB_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.OperationMode)
                        .HasColumnName("OPERATION_MODE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.Operdate)
                        .HasColumnName("OPERDATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.RecordCount).HasColumnName("RECORD_COUNT");

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.TerminalType)
                        .HasColumnName("TERMINAL_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.TotalCreditNpurse)
                        .HasColumnName("TOTAL_CREDIT_NPURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.TotalCreditPurse)
                        .HasColumnName("TOTAL_CREDIT_PURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.TotalDebitNpurse)
                        .HasColumnName("TOTAL_DEBIT_NPURSE")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.TotalDebitPurse)
                        .HasColumnName("TOTAL_DEBIT_PURSE")
                        .HasColumnType("decimal(8, 2)");
                });

                modelBuilder.Entity<TngInvalidCard>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.Bojdatetime, e.Jobno, e.TransCode, e.Mfgno, e.Transdatetime });

                    entity.ToTable("TNG_INVALID_CARD");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Bojdatetime)
                        .HasColumnName("BOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Jobno).HasColumnName("JOBNO");

                    entity.Property(e => e.TransCode)
                        .HasColumnName("TRANS_CODE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Mfgno)
                        .HasColumnName("MFGNO")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Transdatetime)
                        .HasColumnName("TRANSDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Batchno).HasColumnName("BATCHNO");

                    entity.Property(e => e.CardIssuer)
                        .HasColumnName("CARD_ISSUER")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.CardNo)
                        .HasColumnName("CARD_NO")
                        .HasMaxLength(19)
                        .IsUnicode(false);

                    entity.Property(e => e.JobType)
                        .HasColumnName("JOB_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.OperationMode)
                        .HasColumnName("OPERATION_MODE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.Operdate)
                        .HasColumnName("OPERDATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.TerminalType)
                        .HasColumnName("TERMINAL_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<TngReloadTxn>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.Bojdatetime, e.Jobno, e.Mfgno, e.Cardtranno, e.Transtype, e.Transdatetime });

                    entity.ToTable("TNG_RELOAD_TXN");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Bojdatetime)
                        .HasColumnName("BOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Jobno).HasColumnName("JOBNO");

                    entity.Property(e => e.Mfgno)
                        .HasColumnName("MFGNO")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Cardtranno).HasColumnName("CARDTRANNO");

                    entity.Property(e => e.Transtype)
                        .HasColumnName("TRANSTYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Transdatetime)
                        .HasColumnName("TRANSDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Aftcardbal)
                        .HasColumnName("AFTCARDBAL")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.AppSector)
                        .HasColumnName("APP_SECTOR")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Batchno).HasColumnName("BATCHNO");

                    entity.Property(e => e.CardIssuer)
                        .HasColumnName("CARD_ISSUER")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.CardNo)
                        .HasColumnName("CARD_NO")
                        .HasMaxLength(18)
                        .IsUnicode(false);

                    entity.Property(e => e.CardType)
                        .HasColumnName("CARD_TYPE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.CorpFlag)
                        .HasColumnName("CORP_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.DcFlag)
                        .HasColumnName("DC_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryOperatorid)
                        .HasColumnName("ENTRY_OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.EntrySiteid)
                        .HasColumnName("ENTRY_SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitMachineno)
                        .HasColumnName("EXIT_MACHINENO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitObuno)
                        .HasColumnName("EXIT_OBUNO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.FreeFormat)
                        .HasColumnName("FREE_FORMAT")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.LrMachinecode)
                        .HasColumnName("LR_MACHINECODE")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.Operdate)
                        .HasColumnName("OPERDATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.PurseFlag)
                        .HasColumnName("PURSE_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.SignNo)
                        .HasColumnName("SIGN_NO")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    entity.Property(e => e.SignVersion).HasColumnName("SIGN_VERSION");

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Transamount)
                        .HasColumnName("TRANSAMOUNT")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.UserCategory)
                        .HasColumnName("USER_CATEGORY")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<TngReloadTxnError>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.Bojdatetime, e.Jobno, e.Mfgno, e.Cardtranno, e.Transtype, e.Transdatetime });

                    entity.ToTable("TNG_RELOAD_TXN_ERROR");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Bojdatetime)
                        .HasColumnName("BOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Jobno).HasColumnName("JOBNO");

                    entity.Property(e => e.Mfgno)
                        .HasColumnName("MFGNO")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Cardtranno).HasColumnName("CARDTRANNO");

                    entity.Property(e => e.Transtype)
                        .HasColumnName("TRANSTYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Transdatetime)
                        .HasColumnName("TRANSDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Aftcardbal)
                        .HasColumnName("AFTCARDBAL")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.AppSector)
                        .HasColumnName("APP_SECTOR")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Batchno).HasColumnName("BATCHNO");

                    entity.Property(e => e.CardIssuer)
                        .HasColumnName("CARD_ISSUER")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.CardNo)
                        .HasColumnName("CARD_NO")
                        .HasMaxLength(18)
                        .IsUnicode(false);

                    entity.Property(e => e.CardType)
                        .HasColumnName("CARD_TYPE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.CorpFlag)
                        .HasColumnName("CORP_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.DateEntered)
                        .HasColumnName("DATE_ENTERED")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.DcFlag)
                        .HasColumnName("DC_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryOperatorid)
                        .HasColumnName("ENTRY_OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.EntrySiteid)
                        .HasColumnName("ENTRY_SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ErrorCode)
                        .HasColumnName("ERROR_CODE")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ErrorDescription)
                        .HasColumnName("ERROR_DESCRIPTION")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitMachineno)
                        .HasColumnName("EXIT_MACHINENO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitObuno)
                        .HasColumnName("EXIT_OBUNO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.FreeFormat)
                        .HasColumnName("FREE_FORMAT")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.LrMachinecode)
                        .HasColumnName("LR_MACHINECODE")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.Operdate)
                        .HasColumnName("OPERDATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.PurseFlag)
                        .HasColumnName("PURSE_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.SignNo)
                        .HasColumnName("SIGN_NO")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    entity.Property(e => e.SignVersion).HasColumnName("SIGN_VERSION");

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Transamount)
                        .HasColumnName("TRANSAMOUNT")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.UserCategory)
                        .HasColumnName("USER_CATEGORY")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<TngUsageTxn>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.Bojdatetime, e.Jobno, e.Mfgno, e.Cardtranno, e.Transtype, e.Transdatetime });

                    entity.ToTable("TNG_USAGE_TXN");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Bojdatetime)
                        .HasColumnName("BOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Jobno).HasColumnName("JOBNO");

                    entity.Property(e => e.Mfgno)
                        .HasColumnName("MFGNO")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Cardtranno).HasColumnName("CARDTRANNO");

                    entity.Property(e => e.Transtype)
                        .HasColumnName("TRANSTYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Transdatetime)
                        .HasColumnName("TRANSDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Aftcardbal)
                        .HasColumnName("AFTCARDBAL")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.AppSector)
                        .HasColumnName("APP_SECTOR")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Batchno).HasColumnName("BATCHNO");

                    entity.Property(e => e.CardIssuer)
                        .HasColumnName("CARD_ISSUER")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.CardNo)
                        .HasColumnName("CARD_NO")
                        .HasMaxLength(18)
                        .IsUnicode(false);

                    entity.Property(e => e.CardType)
                        .HasColumnName("CARD_TYPE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.CorpFlag)
                        .HasColumnName("CORP_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.DcFlag)
                        .HasColumnName("DC_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryOperatorid)
                        .HasColumnName("ENTRY_OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.EntrySiteid)
                        .HasColumnName("ENTRY_SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitMachineno)
                        .HasColumnName("EXIT_MACHINENO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitObuno)
                        .HasColumnName("EXIT_OBUNO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.FreeFormat)
                        .HasColumnName("FREE_FORMAT")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.LrMachinecode)
                        .HasColumnName("LR_MACHINECODE")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.Operdate)
                        .HasColumnName("OPERDATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.PurseFlag)
                        .HasColumnName("PURSE_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.SignNo)
                        .HasColumnName("SIGN_NO")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    entity.Property(e => e.SignVersion).HasColumnName("SIGN_VERSION");

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Transamount)
                        .HasColumnName("TRANSAMOUNT")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.UserCategory)
                        .HasColumnName("USER_CATEGORY")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<TngUsageTxnError>(entity =>
                {
                    entity.HasKey(e => new { e.Operatorid, e.Siteid, e.Terminalid, e.Bojdatetime, e.Jobno, e.Mfgno, e.Cardtranno, e.Transtype, e.Transdatetime });

                    entity.ToTable("TNG_USAGE_TXN_ERROR");

                    entity.Property(e => e.Operatorid)
                        .HasColumnName("OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Siteid)
                        .HasColumnName("SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Terminalid)
                        .HasColumnName("TERMINALID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.Bojdatetime)
                        .HasColumnName("BOJDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Jobno).HasColumnName("JOBNO");

                    entity.Property(e => e.Mfgno)
                        .HasColumnName("MFGNO")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Cardtranno).HasColumnName("CARDTRANNO");

                    entity.Property(e => e.Transtype)
                        .HasColumnName("TRANSTYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Transdatetime)
                        .HasColumnName("TRANSDATETIME")
                        .HasColumnType("datetime");

                    entity.Property(e => e.AddInfoDetail)
                        .HasColumnName("ADD_INFO_DETAIL")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.AddInfoType)
                        .HasColumnName("ADD_INFO_TYPE")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Aftcardbal)
                        .HasColumnName("AFTCARDBAL")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.AppSector)
                        .HasColumnName("APP_SECTOR")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.Batchno).HasColumnName("BATCHNO");

                    entity.Property(e => e.CardIssuer)
                        .HasColumnName("CARD_ISSUER")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.CardNo)
                        .HasColumnName("CARD_NO")
                        .HasMaxLength(18)
                        .IsUnicode(false);

                    entity.Property(e => e.CardType)
                        .HasColumnName("CARD_TYPE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.CorpFlag)
                        .HasColumnName("CORP_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.DateEntered)
                        .HasColumnName("DATE_ENTERED")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.DcFlag)
                        .HasColumnName("DC_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryOperatorid)
                        .HasColumnName("ENTRY_OPERATORID")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.EntrySiteid)
                        .HasColumnName("ENTRY_SITEID")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ErrorCode)
                        .HasColumnName("ERROR_CODE")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ErrorDescription)
                        .HasColumnName("ERROR_DESCRIPTION")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitMachineno)
                        .HasColumnName("EXIT_MACHINENO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitObuno)
                        .HasColumnName("EXIT_OBUNO")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.FreeFormat)
                        .HasColumnName("FREE_FORMAT")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.LrMachinecode)
                        .HasColumnName("LR_MACHINECODE")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.Operdate)
                        .HasColumnName("OPERDATE")
                        .HasColumnType("datetime");

                    entity.Property(e => e.PurseFlag)
                        .HasColumnName("PURSE_FLAG")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.RecordChecksum)
                        .HasColumnName("RECORD_CHECKSUM")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.SignNo)
                        .HasColumnName("SIGN_NO")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    entity.Property(e => e.SignVersion).HasColumnName("SIGN_VERSION");

                    entity.Property(e => e.SourceFilename)
                        .HasColumnName("SOURCE_FILENAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Transamount)
                        .HasColumnName("TRANSAMOUNT")
                        .HasColumnType("decimal(8, 2)");

                    entity.Property(e => e.UserCategory)
                        .HasColumnName("USER_CATEGORY")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<Transaction>(entity =>
                {
                    entity.Property(e => e.TransactionId)
                        .HasColumnName("TransactionID")
                        .HasDefaultValueSql("(newid())");

                    entity.Property(e => e.ApplicationSector)
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ApprCode)
                        .HasColumnName("Appr_Code")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.BatchNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.CardIssuer)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.CardNo)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.CardTransactionNo)
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    entity.Property(e => e.CardType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CardTypeTag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CorporateFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.DrCrFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength()
                        .HasDefaultValueSql("('D')");

                    entity.Property(e => e.EntryLane)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryLocation)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryReaderId)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryTime).HasColumnType("datetime");

                    entity.Property(e => e.ExitLane)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitLocation)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitReaderId)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitTime).HasColumnType("datetime");

                    entity.Property(e => e.Fare).HasDefaultValueSql("((0))");

                    entity.Property(e => e.FareGst)
                        .HasColumnName("FareGST")
                        .HasDefaultValueSql("((0))");

                    entity.Property(e => e.FareSst).HasColumnName("FareSST");

                    entity.Property(e => e.HashPan)
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.IssuerMachineNo)
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.LastRefillMachineCode)
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.ManufacturerNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.Obuno)
                        .HasColumnName("OBUNo")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasComment("Smart Tag ID");

                    entity.Property(e => e.ParkAideUploadStatus)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ParkValidateFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.PurseFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength()
                        .HasDefaultValueSql("('P')");

                    entity.Property(e => e.Rrn)
                        .HasColumnName("RRN")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.Signature)
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    entity.Property(e => e.SignatureVersion)
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    entity.Property(e => e.SiteId).HasColumnName("SiteID");

                    entity.Property(e => e.Spid)
                        .HasColumnName("SPID")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasComment("Service Provider ID");

                    entity.Property(e => e.Stan)
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.SuccessFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.Surcharge).HasDefaultValueSql("((0))");

                    entity.Property(e => e.SurchargeGst)
                        .HasColumnName("SurchargeGST")
                        .HasDefaultValueSql("((0))");

                    entity.Property(e => e.TransactionTime).HasColumnType("datetime");

                    entity.Property(e => e.TransactionType)
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.UploadFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.UserCategory)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.VehicleClass)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();
                });

                modelBuilder.Entity<TransactionFailure>(entity =>
                {
                    entity.HasKey(e => e.TranFailureId)
                        .HasName("PK_TransactionFailure_1");

                    entity.Property(e => e.TranFailureId)
                        .HasColumnName("TranFailureID")
                        .HasDefaultValueSql("(newid())");

                    entity.Property(e => e.BatchNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.FailureCategory)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.FailureCode)
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.Reason)
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                    entity.Property(e => e.UploadFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.HasOne(d => d.Transaction)
                        .WithMany(p => p.TransactionFailure)
                        .HasForeignKey(d => d.TransactionId)
                        .HasConstraintName("FK_TransactionFailure_Transaction1");
                });

                modelBuilder.Entity<TransactionFailureSeasonPass>(entity =>
                {
                    entity.HasKey(e => e.TranFailureId)
                        .HasName("PK_TransactionFailure_SeasonPass_1");

                    entity.ToTable("TransactionFailure_SeasonPass");

                    entity.Property(e => e.TranFailureId)
                        .HasColumnName("TranFailureID")
                        .HasDefaultValueSql("(newid())");

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.FailureCategory)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.FailureCode)
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getutcdate())");

                    entity.Property(e => e.Reason)
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                    entity.HasOne(d => d.Transaction)
                        .WithMany(p => p.TransactionFailureSeasonPass)
                        .HasForeignKey(d => d.TransactionId)
                        .HasConstraintName("FK_TransactionFailure_SeasonPass_Transaction1");
                });

                modelBuilder.Entity<TransactionMonitor>(entity =>
                {
                    entity.HasNoKey();

                    entity.ToView("TransactionMonitor");

                    entity.Property(e => e.EntryLane)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryLocation)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryReaderId)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryTime).HasColumnType("datetime");

                    entity.Property(e => e.ExitLane)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitLocation)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitReaderId)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitTime).HasColumnType("datetime");

                    entity.Property(e => e.LevelCode)
                        .IsRequired()
                        .HasMaxLength(10);

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ManufacturerNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.TransactionTime).HasColumnType("datetime");
                });

                modelBuilder.Entity<TransactionSeasonPass>(entity =>
                {
                    entity.HasKey(e => e.TransactionId)
                        .HasName("PK_Transaction_SeasonPass_1");

                    entity.ToTable("Transaction_SeasonPass");

                    entity.Property(e => e.TransactionId)
                        .HasColumnName("TransactionID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.CardNo)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.CardTransactionNo)
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    entity.Property(e => e.CardType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CreationDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.EntryLane)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryLocation)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryReaderId)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.EntryTime).HasColumnType("datetime");

                    entity.Property(e => e.ExitLane)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitLocation)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitReaderId)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ExitTime).HasColumnType("datetime");

                    entity.Property(e => e.LastEditDate)
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.ManufacturerNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.SuccessFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.TransactionTime).HasColumnType("datetime");
                });

                modelBuilder.Entity<TransactionValidator>(entity =>
                {
                    entity.HasKey(e => e.TransactionValidateId);

                    entity.Property(e => e.TransactionValidateId)
                        .HasColumnName("TransactionValidateID")
                        .ValueGeneratedNever();

                    entity.Property(e => e.CardType)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CheckFlag)
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.CreationDate).HasColumnType("datetime");

                    entity.Property(e => e.EntryTime).HasColumnType("datetime");

                    entity.Property(e => e.ExitTime).HasColumnType("datetime");

                    entity.Property(e => e.HashPan)
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .IsFixedLength();

                    entity.Property(e => e.ManufacturerNo)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                    entity.Property(e => e.TransactionTime).HasColumnType("datetime");
                });

                modelBuilder.Entity<User>(entity =>
                {
                    entity.Property(e => e.Id).HasColumnName("ID");

                    entity.Property(e => e.Email)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.Pwd)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.RoleId).HasColumnName("RoleID");
                });

                modelBuilder.Entity<Users>(entity =>
                {
                    entity.HasKey(e => e.UserId);

                    entity.Property(e => e.UserId)
                        .HasColumnName("UserID")
                        .HasMaxLength(10);

                    entity.Property(e => e.ChangedPasswordDate).HasColumnType("datetime");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.EmailAddress).HasMaxLength(40);

                    entity.Property(e => e.IsActive).HasComment("CheckBox = T/F (True / False)");

                    entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                    entity.Property(e => e.LastLoginIpaddress)
                        .HasColumnName("LastLoginIPAddress")
                        .HasMaxLength(20);

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.Password)
                        .IsRequired()
                        .HasMaxLength(100);

                    entity.Property(e => e.PasswordExpiredDate).HasColumnType("datetime");

                    entity.Property(e => e.PasswordSettingId).HasColumnName("PasswordSettingID");

                    entity.Property(e => e.RoleId).HasColumnName("RoleID");

                    entity.Property(e => e.UserName)
                        .IsRequired()
                        .HasMaxLength(40);

                    entity.HasOne(d => d.Role)
                        .WithMany(p => p.Users)
                        .HasForeignKey(d => d.RoleId)
                        .HasConstraintName("FK_Users_Roles");
                });

                modelBuilder.Entity<VehicleClass>(entity =>
                {
                    entity.Property(e => e.VehicleClassId).HasColumnName("VehicleClassID");

                    entity.Property(e => e.ClassName).HasMaxLength(10);

                    entity.Property(e => e.VehicleType)
                        .HasMaxLength(10)
                        .IsFixedLength();
                });

                modelBuilder.Entity<WeekDay>(entity =>
                {
                    entity.HasKey(e => new { e.WeekDay1, e.ParkingLevelId });

                    entity.Property(e => e.WeekDay1)
                        .HasColumnName("WeekDay")
                        .HasMaxLength(20);

                    entity.Property(e => e.ParkingLevelId).HasColumnName("ParkingLevelID");

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.DayTypeId).HasColumnName("DayTypeID");

                    entity.Property(e => e.LaneCode).HasMaxLength(100);

                    entity.Property(e => e.LocationId)
                        .IsRequired()
                        .HasColumnName("LocationID")
                        .HasMaxLength(5);

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.HasOne(d => d.DayType)
                        .WithMany(p => p.WeekDay)
                        .HasForeignKey(d => d.DayTypeId)
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK_WeekDay_DayType");
                });

                modelBuilder.Entity<Zone>(entity =>
                {
                    entity.HasKey(e => e.ZoneCode)
                        .HasName("PK_Area_1");

                    entity.Property(e => e.ZoneCode).HasMaxLength(3);

                    entity.Property(e => e.CreatedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                    entity.Property(e => e.LastCounterReset)
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.ModifiedBy)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                    entity.Property(e => e.ZoneName)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(e => e.ZonePicture).HasColumnType("image");
                });

                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<tng_cpmsContext>
    {
        public tng_cpmsContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../PCS.CPMS.WebAPI_PWA/appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<tng_cpmsContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new tng_cpmsContext(builder.Options);
        }
    }
}
