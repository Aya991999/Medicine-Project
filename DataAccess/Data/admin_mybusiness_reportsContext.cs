using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models.DBModels.admin_m_reports_b;

namespace Models.Models;

public partial class admin_mybusiness_reportsContext : DbContext
{
    public admin_mybusiness_reportsContext()
    {
    }

    public admin_mybusiness_reportsContext(DbContextOptions<admin_mybusiness_reportsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<M_Reports_B_Color_Type> M_Reports_B_Color_Types { get; set; }

    public virtual DbSet<M_Reports_B_Filed_Type> M_Reports_B_Filed_Types { get; set; }

    public virtual DbSet<M_Reports_B_Font_Size> M_Reports_B_Font_Sizes { get; set; }

    public virtual DbSet<M_Reports_B_Font_Type> M_Reports_B_Font_Types { get; set; }

    public virtual DbSet<M_Reports_B_Report_Kind> M_Reports_B_Report_Kinds { get; set; }

    public virtual DbSet<M_Reports_B_Report_Layout> M_Reports_B_Report_Layouts { get; set; }

    public virtual DbSet<M_Reports_B_Report_Period> M_Reports_B_Report_Periods { get; set; }

    public virtual DbSet<M_Reports_B_Report_Size> M_Reports_B_Report_Sizes { get; set; }

    public virtual DbSet<M_Reports_B_Report_Type> M_Reports_B_Report_Types { get; set; }

    public virtual DbSet<M_Reports_B_System_Report_Detail> M_Reports_B_System_Report_Details { get; set; }

    public virtual DbSet<M_Reports_B_System_Report_Header> M_Reports_B_System_Report_Headers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=AHMEDPC\\MYBUSINESS;User ID=sa;Password=WaveSoft2022;Database=admin_mybusiness_reports;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<M_Reports_B_Color_Type>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Color_Type_id).HasName("PK__M_Report__934AD19CE1807B9E");

            entity.ToTable("M_Reports_B_Color_Type", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Color_Type_Arabic_name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Color_Type_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Color_Type_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Color_Type_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Color_Type_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Color_Type_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Color_Type_English_name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Color_Type_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Color_Type_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Filed_Type>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Filed_Type_ID).HasName("PK__M_Report__C87FAE53F22B7CA8");

            entity.ToTable("M_Reports_B_Filed_Type", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Filed_Type_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Filed_Type_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Filed_Type_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Filed_Type_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Filed_Type_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Filed_Type_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Filed_Type_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Filed_Type_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Filed_Type_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Font_Size>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Font_Size_ID).HasName("PK__M_Report__629C879B0EB81B46");

            entity.ToTable("M_Reports_B_Font_Size", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Font_Size_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Font_Size_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Size_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Size_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Font_Size_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Size_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Font_Size_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Font_Size_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Size_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Font_Type>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Font_Type_ID).HasName("PK__M_Report__5EB71B99839E938C");

            entity.ToTable("M_Reports_B_Font_Type", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Font_Type_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Font_Type_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Type_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Type_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Font_Type_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Type_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Font_Type_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Font_Type_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Font_Type_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Report_Kind>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Report_Kind_ID).HasName("PK__M_Report__E048283574E5CE15");

            entity.ToTable("M_Reports_B_Report_Kind", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Report_Kind_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Kind_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Kind_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Kind_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Kind_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Kind_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Kind_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Kind_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Kind_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Report_Layout>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Report_Layout_ID).HasName("PK__M_Report__4A0A7C889DD51809");

            entity.ToTable("M_Reports_B_Report_Layout", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Report_Layout_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Layout_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Layout_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Layout_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Layout_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Layout_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Layout_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Layout_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Layout_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Report_Period>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Report_Period_ID).HasName("PK__M_Report__7E9C5CCB32B0A7F5");

            entity.ToTable("M_Reports_B_Report_Period", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Report_Period_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Period_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Period_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Period_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Period_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Period_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Period_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Period_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Period_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Report_Size>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Report_Size_ID).HasName("PK__M_Report__A5D83AA2D81CA924");

            entity.ToTable("M_Reports_B_Report_Size", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Report_Size_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Size_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Size_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Size_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Size_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Size_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Size_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Size_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Size_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_Report_Type>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_Report_Type_ID).HasName("PK__M_Report__C11BCC1046AFEC97");

            entity.ToTable("M_Reports_B_Report_Type", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_Report_Type_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Type_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Type_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Type_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Type_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Type_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_Report_Type_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_Report_Type_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_Report_Type_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_System_Report_Detail>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_System_Report_Details_id).HasName("PK__M_Report__97BAF8FD57A7AB71");

            entity.ToTable("M_Reports_B_System_Report_Details", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_System_Report_Details_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_System_Report_Details_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_System_Report_Details_Filed_id).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Filed_type).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Printed_filed_Arabic_name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Printed_filed_English_name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Details_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Reports_B_System_Report_Header>(entity =>
        {
            entity.HasKey(e => e.M_Reports_B_System_Report_Header_ID).HasName("PK__M_Report__3D0B55948758A0AB");

            entity.ToTable("M_Reports_B_System_Report_Header", "admin_mybusiness");

            entity.Property(e => e.M_Reports_B_System_Report_Header_Arabic_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_System_Report_Header_Arabic_description).HasMaxLength(500);
            entity.Property(e => e.M_Reports_B_System_Report_Header_CEDB_Code_Id).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Header_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Header_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_System_Report_Header_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Header_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_System_Report_Header_English_Name).HasMaxLength(50);
            entity.Property(e => e.M_Reports_B_System_Report_Header_English_description).HasMaxLength(500);
            entity.Property(e => e.M_Reports_B_System_Report_Header_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Reports_B_System_Report_Header_Updated_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Reports_B_System_Report_Header_logo).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
