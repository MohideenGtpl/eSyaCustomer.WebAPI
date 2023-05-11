﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HCP.Customer.DL.Entities
{
    public partial class eSyaEnterprise : DbContext
    {
        public static string _connString = "";
        public eSyaEnterprise()
        {
        }

        public eSyaEnterprise(DbContextOptions<eSyaEnterprise> options)
            : base(options)
        {
        }

        public virtual DbSet<GtAddrin> GtAddrin { get; set; }
        public virtual DbSet<GtEacsbl> GtEacsbl { get; set; }
        public virtual DbSet<GtEacscc> GtEacscc { get; set; }
        public virtual DbSet<GtEacscd> GtEacscd { get; set; }
        public virtual DbSet<GtEacssd> GtEacssd { get; set; }
        public virtual DbSet<GtEapcdt> GtEapcdt { get; set; }
        public virtual DbSet<GtEapcms> GtEapcms { get; set; }
        public virtual DbSet<GtEapcrs> GtEapcrs { get; set; }
        public virtual DbSet<GtEapcsp> GtEapcsp { get; set; }
        public virtual DbSet<GtEaptcg> GtEaptcg { get; set; }
        public virtual DbSet<GtEaptcs> GtEaptcs { get; set; }
        public virtual DbSet<GtEcapcd> GtEcapcd { get; set; }
        public virtual DbSet<GtEcbsln> GtEcbsln { get; set; }
        public virtual DbSet<GtEcbssg> GtEcbssg { get; set; }
        public virtual DbSet<GtEccncd> GtEccncd { get; set; }
        public virtual DbSet<GtEccnpl> GtEccnpl { get; set; }
        public virtual DbSet<GtEccnsd> GtEccnsd { get; set; }
        public virtual DbSet<GtEopprr> GtEopprr { get; set; }
        public virtual DbSet<GtEspcdc> GtEspcdc { get; set; }
        public virtual DbSet<GtEspcds> GtEspcds { get; set; }
        public virtual DbSet<GtEsspcd> GtEsspcd { get; set; }
        public virtual DbSet<GtEssrbl> GtEssrbl { get; set; }
        public virtual DbSet<GtEssrcl> GtEssrcl { get; set; }
        public virtual DbSet<GtEssrgr> GtEssrgr { get; set; }
        public virtual DbSet<GtEssrms> GtEssrms { get; set; }
        public virtual DbSet<GtEssrty> GtEssrty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(_connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<GtAddrin>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.AreaCode });

                entity.ToTable("GT_ADDRIN");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Taluk).HasMaxLength(150);
            });

            modelBuilder.Entity<GtEacsbl>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.BusinessKey });

                entity.ToTable("GT_EACSBL");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.GtEacsbl)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_EACSBL_GT_EACSCC");
            });

            modelBuilder.Entity<GtEacscc>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("GT_EACSCC");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreditLimit).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.CustomerOnHold)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEacscd>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerLocationId });

                entity.ToTable("GT_EACSCD");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerLocationId).HasColumnName("CustomerLocationID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerLocation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EMailId)
                    .IsRequired()
                    .HasColumnName("eMailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.RegisteredMobileNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryMobileNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEacssd>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerLocationId, e.StatutoryCode });

                entity.ToTable("GT_EACSSD");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerLocationId).HasColumnName("CustomerLocationID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.StatutoryDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.GtEacssd)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_EACSSD_GT_EACSCC");
            });

            modelBuilder.Entity<GtEapcdt>(entity =>
            {
                entity.HasKey(e => new { e.PatientTypeId, e.PatientCategoryId, e.DocumentId });

                entity.ToTable("GT_EAPCDT");

                entity.Property(e => e.PatientTypeId).HasColumnName("PatientTypeID");

                entity.Property(e => e.PatientCategoryId).HasColumnName("PatientCategoryID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEapcms>(entity =>
            {
                entity.HasKey(e => new { e.PatientTypeId, e.PatientCategoryId });

                entity.ToTable("GT_EAPCMS");

                entity.Property(e => e.PatientTypeId).HasColumnName("PatientTypeID");

                entity.Property(e => e.PatientCategoryId).HasColumnName("PatientCategoryID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ServiceWiseRateType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentAllowedIp).HasColumnName("TreatmentAllowedIP");

                entity.Property(e => e.TreatmentAllowedOp).HasColumnName("TreatmentAllowedOP");
            });

            modelBuilder.Entity<GtEapcrs>(entity =>
            {
                entity.HasKey(e => new { e.PatientTypeId, e.PatientCategoryId, e.ServiceType });

                entity.ToTable("GT_EAPCRS");

                entity.Property(e => e.PatientTypeId).HasColumnName("PatientTypeID");

                entity.Property(e => e.PatientCategoryId).HasColumnName("PatientCategoryID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEapcsp>(entity =>
            {
                entity.HasKey(e => new { e.PatientTypeId, e.PatientCategoryId, e.SpecialtyId });

                entity.ToTable("GT_EAPCSP");

                entity.Property(e => e.PatientTypeId).HasColumnName("PatientTypeID");

                entity.Property(e => e.PatientCategoryId).HasColumnName("PatientCategoryID");

                entity.Property(e => e.SpecialtyId).HasColumnName("SpecialtyID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEaptcg>(entity =>
            {
                entity.HasKey(e => new { e.PatientTypeId, e.PatientCategoryId });

                entity.ToTable("GT_EAPTCG");

                entity.Property(e => e.PatientTypeId).HasColumnName("PatientTypeID");

                entity.Property(e => e.PatientCategoryId).HasColumnName("PatientCategoryID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TreatmentAllowedIp).HasColumnName("TreatmentAllowedIP");

                entity.Property(e => e.TreatmentAllowedOp).HasColumnName("TreatmentAllowedOP");
            });

            modelBuilder.Entity<GtEaptcs>(entity =>
            {
                entity.HasKey(e => new { e.PatientTypeId, e.PatientCategoryId, e.SpecialtyId });

                entity.ToTable("GT_EAPTCS");

                entity.Property(e => e.PatientTypeId).HasColumnName("PatientTypeID");

                entity.Property(e => e.PatientCategoryId).HasColumnName("PatientCategoryID");

                entity.Property(e => e.SpecialtyId).HasColumnName("SpecialtyID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcapcd>(entity =>
            {
                entity.HasKey(e => e.ApplicationCode)
                    .HasName("PK_GT_ECAPCD_1");

                entity.ToTable("GT_ECAPCD");

                entity.Property(e => e.ApplicationCode).ValueGeneratedNever();

                entity.Property(e => e.CodeDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ShortCode).HasMaxLength(15);
            });

            modelBuilder.Entity<GtEcbsln>(entity =>
            {
                entity.HasKey(e => new { e.BusinessId, e.SegmentId, e.LocationId });

                entity.ToTable("GT_ECBSLN");

                entity.HasIndex(e => e.BusinessKey)
                    .HasName("IX_GT_ECBSLN")
                    .IsUnique();

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EActiveUsers)
                    .IsRequired()
                    .HasColumnName("eActiveUsers");

                entity.Property(e => e.EBusinessKey)
                    .IsRequired()
                    .HasColumnName("eBusinessKey");

                entity.Property(e => e.ENoOfBeds).HasColumnName("eNoOfBeds");

                entity.Property(e => e.ESyaLicenseType)
                    .IsRequired()
                    .HasColumnName("eSyaLicenseType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EUserLicenses)
                    .IsRequired()
                    .HasColumnName("eUserLicenses");

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.LocationDescription)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TocurrConversion).HasColumnName("TOCurrConversion");

                entity.Property(e => e.TolocalCurrency)
                    .IsRequired()
                    .HasColumnName("TOLocalCurrency")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TorealCurrency).HasColumnName("TORealCurrency");

                entity.HasOne(d => d.GtEcbssg)
                    .WithMany(p => p.GtEcbsln)
                    .HasForeignKey(d => new { d.BusinessId, d.SegmentId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECBSLN_GT_ECBSSG");
            });

            modelBuilder.Entity<GtEcbssg>(entity =>
            {
                entity.HasKey(e => new { e.BusinessId, e.SegmentId });

                entity.ToTable("GT_ECBSSG");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.OrgnDateFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentDesc)
                    .IsRequired()
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<GtEccncd>(entity =>
            {
                entity.HasKey(e => e.Isdcode);

                entity.ToTable("GT_ECCNCD");

                entity.Property(e => e.Isdcode)
                    .HasColumnName("ISDCode")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.CountryFlag)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.DateFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsPinapplicable).HasColumnName("IsPINApplicable");

                entity.Property(e => e.IsPoboxApplicable).HasColumnName("IsPOBoxApplicable");

                entity.Property(e => e.MobileNumberPattern)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.PincodePattern)
                    .HasColumnName("PINcodePattern")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PoboxPattern)
                    .HasColumnName("POBoxPattern")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDateFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uidlabel)
                    .HasColumnName("UIDLabel")
                    .HasMaxLength(50);

                entity.Property(e => e.Uidpattern)
                    .HasColumnName("UIDPattern")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<GtEccnpl>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.PlaceId });

                entity.ToTable("GT_ECCNPL");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.PlaceName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<GtEccnsd>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.StatutoryCode });

                entity.ToTable("GT_ECCNSD");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.StatPattern)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StatShortCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatutoryDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IsdcodeNavigation)
                    .WithMany(p => p.GtEccnsd)
                    .HasForeignKey(d => d.Isdcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECCNSD_GT_ECCNCD");
            });

            modelBuilder.Entity<GtEopprr>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.Prkey });

                entity.ToTable("GT_EOPPRR");

                entity.Property(e => e.Prkey).HasColumnName("PRKey");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AgeDd).HasColumnName("AgeDD");

                entity.Property(e => e.AgeMm).HasColumnName("AgeMM");

                entity.Property(e => e.AgeYy).HasColumnName("AgeYY");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(150);

                entity.Property(e => e.PatientFirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PatientLastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PatientMiddleName).HasMaxLength(50);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prdate)
                    .HasColumnName("PRDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreExistingHealthCondition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PresentComplaints).HasMaxLength(150);

                entity.Property(e => e.RUhid).HasColumnName("R_UHID");

                entity.Property(e => e.RelationName).HasMaxLength(150);
            });

            modelBuilder.Entity<GtEspcdc>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.PatientCategory, e.ServiceFor, e.ServiceClass });

                entity.ToTable("GT_ESPCDC");

                entity.Property(e => e.ServiceFor)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountPercent).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.DiscountRule)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEspcds>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.PatientCategory, e.ServiceFor, e.ServiceCode });

                entity.ToTable("GT_ESPCDS");

                entity.Property(e => e.ServiceFor)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountPercent).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.DiscountRule)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEsspcd>(entity =>
            {
                entity.HasKey(e => e.SpecialtyId);

                entity.ToTable("GT_ESSPCD");

                entity.Property(e => e.SpecialtyId)
                    .HasColumnName("SpecialtyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlliedServices)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalIcon).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.SpecialtyDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialtyType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEssrbl>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.ServiceId });

                entity.ToTable("GT_ESSRBL");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayPercentage).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.InternalServiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.NightLinePercentage).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ServiceCost).HasColumnType("numeric(18, 6)");
            });

            modelBuilder.Entity<GtEssrcl>(entity =>
            {
                entity.HasKey(e => e.ServiceClassId);

                entity.ToTable("GT_ESSRCL");

                entity.Property(e => e.ServiceClassId)
                    .HasColumnName("ServiceClassID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ServiceClassDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceGroupId).HasColumnName("ServiceGroupID");

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(p => p.GtEssrcl)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ESSRCL_GT_ESSRGR");
            });

            modelBuilder.Entity<GtEssrgr>(entity =>
            {
                entity.HasKey(e => e.ServiceGroupId);

                entity.ToTable("GT_ESSRGR");

                entity.Property(e => e.ServiceGroupId)
                    .HasColumnName("ServiceGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ServiceCriteria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceGroupDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.GtEssrgr)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ESSRGR_GT_ESSRTY");
            });

            modelBuilder.Entity<GtEssrms>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("GT_ESSRMS");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InternalServiceCode).HasMaxLength(15);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ServiceClassId).HasColumnName("ServiceClassID");

                entity.Property(e => e.ServiceCost).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.ServiceDesc)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ServiceShortDesc)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ServiceClass)
                    .WithMany(p => p.GtEssrms)
                    .HasForeignKey(d => d.ServiceClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ESSRMS_GT_ESSRCL");
            });

            modelBuilder.Entity<GtEssrty>(entity =>
            {
                entity.HasKey(e => e.ServiceTypeId);

                entity.ToTable("GT_ESSRTY");

                entity.Property(e => e.ServiceTypeId)
                    .HasColumnName("ServiceTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ServiceTypeDesc)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
