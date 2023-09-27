using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyBusinessAPI.Models;

public partial class admin_m_standard_bContext : DbContext
{
    public admin_m_standard_bContext()
    {
    }

    public admin_m_standard_bContext(DbContextOptions<admin_m_standard_bContext> options)
        : base(options)
    {
    }

    public virtual DbSet<M_Standard_B_Data_Type> M_Standard_B_Data_Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=admin_m_standard_b;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<M_Standard_B_Data_Type>(entity =>
        {
            entity.HasKey(e => e.M_Standard_B_Data_Type_INT).HasName("PK__M_Standa__29D4DF13D2397FDF");

            entity.ToTable("M_Standard_B_Data_Type");

            entity.Property(e => e.M_Standard_B_Data_Type_Ar_Desc).HasMaxLength(500);
            entity.Property(e => e.M_Standard_B_Data_Type_Ar_Name).HasMaxLength(100);
            entity.Property(e => e.M_Standard_B_Data_Type_BINARY)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.M_Standard_B_Data_Type_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Standard_B_Data_Type_DATE).HasColumnType("date");
            entity.Property(e => e.M_Standard_B_Data_Type_DATE_TIME).HasColumnType("datetime");
            entity.Property(e => e.M_Standard_B_Data_Type_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Standard_B_Data_Type_En_Desc).HasMaxLength(500);
            entity.Property(e => e.M_Standard_B_Data_Type_En_Name).HasMaxLength(100);
            entity.Property(e => e.M_Standard_B_Data_Type_IMAGE).HasColumnType("image");
            entity.Property(e => e.M_Standard_B_Data_Type_MONEY).HasColumnType("money");
            entity.Property(e => e.M_Standard_B_Data_Type_NUMIREC).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_05).HasMaxLength(5);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_10).HasMaxLength(10);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_100).HasMaxLength(100);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_15).HasMaxLength(15);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_20).HasMaxLength(20);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_200).HasMaxLength(200);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_25).HasMaxLength(25);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_30).HasMaxLength(30);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_300).HasMaxLength(300);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_40).HasMaxLength(40);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_400).HasMaxLength(400);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_50).HasMaxLength(50);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_500).HasMaxLength(500);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_60).HasMaxLength(60);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_70).HasMaxLength(70);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_80).HasMaxLength(80);
            entity.Property(e => e.M_Standard_B_Data_Type_NVARCHAR_90).HasMaxLength(90);
            entity.Property(e => e.M_Standard_B_Data_Type_Updated_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Standard_B_Data_Type_varbinary).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
