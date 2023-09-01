using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NetCore_Model.Models;

public partial class PimvContext : DbContext
{
    public PimvContext()
    {
    }

    public PimvContext(DbContextOptions<PimvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChecksheetDetail> ChecksheetDetails { get; set; }

    public virtual DbSet<ChecksheetDevice> ChecksheetDevices { get; set; }

    public virtual DbSet<ChecksheetMaster> ChecksheetMasters { get; set; }

    public virtual DbSet<MeAutoRecipeHistory> MeAutoRecipeHistories { get; set; }

    public virtual DbSet<MeAutoRecipeMaster> MeAutoRecipeMasters { get; set; }

    public virtual DbSet<MeAutoRecipeProgram> MeAutoRecipePrograms { get; set; }

    public virtual DbSet<MesCpMeter> MesCpMeters { get; set; }

    public virtual DbSet<MesCpParameter> MesCpParameters { get; set; }

    public virtual DbSet<MesCpParameterMonitoring> MesCpParameterMonitorings { get; set; }

    public virtual DbSet<MesMappingParameterHeaderName> MesMappingParameterHeaderNames { get; set; }

    public virtual DbSet<MesMasterMapping> MesMasterMappings { get; set; }

    public virtual DbSet<MmcvBuyoffProcess> MmcvBuyoffProcesses { get; set; }

    public virtual DbSet<MmcvBuyoffProcessDetail> MmcvBuyoffProcessDetails { get; set; }

    public virtual DbSet<MmcvBuyoffQualitySpecCriterion> MmcvBuyoffQualitySpecCriteria { get; set; }

    public virtual DbSet<MmcvBuyoffReport> MmcvBuyoffReports { get; set; }

    public virtual DbSet<MmcvBuyoffToolJigSetup> MmcvBuyoffToolJigSetups { get; set; }

    public virtual DbSet<Mmcvuser> Mmcvusers { get; set; }

    public virtual DbSet<MmcvuserGroup> MmcvuserGroups { get; set; }

    public virtual DbSet<MmcvwebMenu> MmcvwebMenus { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{

    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChecksheetDetail>(entity =>
        {
            entity.HasKey(e => e.SerialId).HasName("PK__Checkshe__5E5B3EC4E2D6FA29");

            entity.ToTable("Checksheet_Details");

            entity.Property(e => e.SerialId).HasColumnName("SerialID");
            entity.Property(e => e.Check).HasMaxLength(20);
            entity.Property(e => e.Confirm).HasMaxLength(20);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .HasColumnName("DeviceID");
            entity.Property(e => e.EnterTime).HasColumnType("datetime");
            entity.Property(e => e.MasterName).HasMaxLength(50);
            entity.Property(e => e.Result).HasMaxLength(20);
            entity.Property(e => e.UserUpdate)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChecksheetDevice>(entity =>
        {
            entity.HasKey(e => e.DeviceId).HasName("PK__Checkshe__49E12331D4289098");

            entity.ToTable("Checksheet_Device");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DeviceID");
            entity.Property(e => e.EnterTime).HasColumnType("datetime");
            entity.Property(e => e.Line)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MasterName).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.SerialId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SerialID");
            entity.Property(e => e.UserUpdate)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChecksheetMaster>(entity =>
        {
            entity.HasKey(e => e.MasterId).HasName("PK__Checkshe__F6B782C4DEC92EE8");

            entity.ToTable("Checksheet_Master");

            entity.Property(e => e.MasterId).HasColumnName("MasterID");
            entity.Property(e => e.Criteria).HasMaxLength(300);
            entity.Property(e => e.EnterTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frequency).HasMaxLength(200);
            entity.Property(e => e.MasterName).HasMaxLength(50);
            entity.Property(e => e.MasterStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.Method).HasMaxLength(200);
            entity.Property(e => e.StyleValue).HasMaxLength(50);
            entity.Property(e => e.TestContents).HasMaxLength(200);
            entity.Property(e => e.UserUpdate)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MeAutoRecipeHistory>(entity =>
        {
            entity.ToTable("ME_AutoRecipe_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acceptance).HasMaxLength(150);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateChange).HasMaxLength(50);
            entity.Property(e => e.IsStatus).HasColumnName("Is_Status");
            entity.Property(e => e.MachineChange).HasMaxLength(50);
            entity.Property(e => e.ParameterChange).HasMaxLength(250);
            entity.Property(e => e.ParameterId).HasColumnName("ParameterID");
            entity.Property(e => e.ProductChange).HasMaxLength(50);
            entity.Property(e => e.ProgramChange).HasMaxLength(250);
            entity.Property(e => e.ValueChange).HasMaxLength(250);
        });

        modelBuilder.Entity<MeAutoRecipeMaster>(entity =>
        {
            entity.ToTable("ME_AutoRecipe_Master");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MachineModel).HasMaxLength(50);
            entity.Property(e => e.ParameterName).HasMaxLength(250);
            entity.Property(e => e.ProductModel).HasMaxLength(50);
            entity.Property(e => e.ProgramName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasMaxLength(250);
        });

        modelBuilder.Entity<MeAutoRecipeProgram>(entity =>
        {
            entity.ToTable("ME_AutoRecipe_Program");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProgramName).HasMaxLength(250);
        });

        modelBuilder.Entity<MesCpMeter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MES_CP_M__3214EC07DFF61F3E");

            entity.ToTable("MES_CP_Meter");

            entity.HasIndex(e => new { e.Area, e.ParameterName, e.EnterTime }, "NonClusteredIndex-20230512-085354");

            entity.HasIndex(e => e.RouteId, "NonClusteredIndex-20230512-085829");

            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DeviceId).HasMaxLength(50);
            entity.Property(e => e.EnterTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ItemModel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LineId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LotNo).HasMaxLength(20);
            entity.Property(e => e.Lsl).HasColumnName("LSL");
            entity.Property(e => e.LslAlarm).HasColumnName("LSL_Alarm");
            entity.Property(e => e.Model)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Mpn)
                .HasMaxLength(20)
                .HasColumnName("MPN");
            entity.Property(e => e.ParameterId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ParameterID");
            entity.Property(e => e.ParameterName).HasMaxLength(50);
            entity.Property(e => e.PcsBarcode).HasMaxLength(50);
            entity.Property(e => e.RouteId)
                .HasMaxLength(100)
                .HasColumnName("RouteID");
            entity.Property(e => e.ShtBarcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(12)
                .HasColumnName("UserID");
            entity.Property(e => e.Usl).HasColumnName("USL");
            entity.Property(e => e.UslAlarm).HasColumnName("USL_Alarm");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MesCpParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MES_CP_P__3214EC07D14B778B");

            entity.ToTable("MES_CP_Parameter");

            entity.HasIndex(e => new { e.Model, e.ParameterName }, "NonClusteredIndex-20230512-085318");

            entity.Property(e => e.Active).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataCollection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Data_Collection");
            entity.Property(e => e.DeviceId).HasMaxLength(100);
            entity.Property(e => e.EBuyoff).HasColumnName("E_Buyoff");
            entity.Property(e => e.FrequencyCollection)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Frequency_Collection");
            entity.Property(e => e.ItemModel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LineId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lsl).HasColumnName("LSL");
            entity.Property(e => e.LslAlarm).HasColumnName("LSL_Alarm");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParameterId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ParameterMonitoring).HasDefaultValueSql("((1))");
            entity.Property(e => e.ParameterName).HasMaxLength(200);
            entity.Property(e => e.RouteId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Usl).HasColumnName("USL");
            entity.Property(e => e.UslAlarm).HasColumnName("USL_Alarm");
        });

        modelBuilder.Entity<MesCpParameterMonitoring>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Parameter_OutputCalculation");

            entity.ToTable("MES_CP_Parameter_Monitoring");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("created_time");
            entity.Property(e => e.EnterDate)
                .HasColumnType("date")
                .HasColumnName("enter_date");
            entity.Property(e => e.IsDelete).HasColumnName("is_delete");
            entity.Property(e => e.LineId)
                .HasMaxLength(50)
                .HasColumnName("line_id");
            entity.Property(e => e.RouteId)
                .HasMaxLength(50)
                .HasColumnName("route_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TimeZone).HasColumnName("time_zone");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updated_time");
        });

        modelBuilder.Entity<MesMappingParameterHeaderName>(entity =>
        {
            entity.ToTable("MES_Mapping_Parameter_HeaderName");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HeaderName).HasMaxLength(100);
            entity.Property(e => e.Marking)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ParameterName).HasMaxLength(100);
        });

        modelBuilder.Entity<MesMasterMapping>(entity =>
        {
            entity.ToTable("MES_MasterMapping");

            entity.Property(e => e.Area).HasMaxLength(20);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DeviceName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EnterTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ItemModel).HasMaxLength(50);
            entity.Property(e => e.LineId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NokId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ProcessName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RouteId).HasMaxLength(20);
            entity.Property(e => e.Vendor)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MmcvBuyoffProcess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MMCV_Buy__3214EC2707DFAAEF");

            entity.ToTable("MMCV_Buyoff_Process");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MachineId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessName).HasMaxLength(50);
            entity.Property(e => e.ReportId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Result)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MmcvBuyoffProcessDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MMCV_Buy__3214EC276D4114E7");

            entity.ToTable("MMCV_Buyoff_Process_Detail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.MachineId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Result)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MmcvBuyoffQualitySpecCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MMCV_Buy__3214EC27A18D3B9B");

            entity.ToTable("MMCV_Buyoff_Quality_SpecCriteria");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasColumnType("text");
            entity.Property(e => e.ProcessId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SpecName).HasMaxLength(200);
            entity.Property(e => e.SpecNameEn).HasMaxLength(200);
        });

        modelBuilder.Entity<MmcvBuyoffReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MMCV_Buy__3214EC27666CC23C");

            entity.ToTable("MMCV_Buyoff_Report");

            entity.HasIndex(e => e.ReportId, "UQ__MMCV_Buy__D5BD4804EF55CF80").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Line)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Lot)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mpn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MPN");
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Result)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SubmitBy).HasMaxLength(50);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MmcvBuyoffToolJigSetup>(entity =>
        {
            entity.ToTable("MMCV_Buyoff_ToolJig_Setup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProcessId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProcessName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Mmcvuser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("MMCVUsers");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.DateCreate).HasColumnType("datetime");
            entity.Property(e => e.DateUpdate).HasColumnType("datetime");
            entity.Property(e => e.GroupIds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GroupIDs");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MmcvuserGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("MMCVUserGroups");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.DateCreate).HasColumnType("datetime");
            entity.Property(e => e.DateUpdate).HasColumnType("datetime");
            entity.Property(e => e.Descriptions).HasMaxLength(50);
            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProgramID");
        });

        modelBuilder.Entity<MmcvwebMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("MMCVWebMenus");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Create_date");
            entity.Property(e => e.Descriptions).HasMaxLength(150);
            entity.Property(e => e.IconClass).HasMaxLength(50);
            entity.Property(e => e.IsPublic).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");
            entity.Property(e => e.MenuName).HasMaxLength(100);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.UrlLink)
                .HasMaxLength(250)
                .HasColumnName("URL_Link");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
