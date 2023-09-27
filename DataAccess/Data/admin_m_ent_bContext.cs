using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyBusinessAPI.Models;

public partial class admin_m_ent_bContext : DbContext
{
    public admin_m_ent_bContext()
    {
    }

    public admin_m_ent_bContext(DbContextOptions<admin_m_ent_bContext> options)
        : base(options)
    {
    }

    public virtual DbSet<m_ent_b__Brn> m_ent_b__Brns { get; set; }

    public virtual DbSet<m_ent_b__Cst> m_ent_b__Csts { get; set; }

    public virtual DbSet<m_ent_b__DB> m_ent_b__DBs { get; set; }

    public virtual DbSet<m_ent_b__Div> m_ent_b__Divs { get; set; }

    public virtual DbSet<m_ent_b__Ent> m_ent_b__Ents { get; set; }

    public virtual DbSet<m_ent_b__Fld> m_ent_b__Flds { get; set; }

    public virtual DbSet<m_ent_b__Tbl> m_ent_b__Tbls { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=198.38.84.196;User ID=admin_m_mybusiness_b;Password=MB_Mocha!1;Database=admin_m_ent_b;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("admin_m_mybusiness_b");

        modelBuilder.Entity<m_ent_b__Brn>(entity =>
        {
            entity.HasKey(e => e.m_ent_b__Brn__Brn_Id).HasName("PK__m_ent_b___F6F709A670134583");

            entity.ToTable("m_ent_b__Brn", "dbo");

            entity.Property(e => e.m_ent_b__Brn__Brn_Id)
                .ValueGeneratedNever()
                .HasComment("m_ent_b__Brn __ Branch Number");
            entity.Property(e => e.m_ent_b__Brn__Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Branch Address");
            entity.Property(e => e.m_ent_b__Brn__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Arabic Name");
            entity.Property(e => e.m_ent_b__Brn__City)
                .HasDefaultValueSql("((0))")
                .HasComment("m_ent_b__Brn __ City ID");
            entity.Property(e => e.m_ent_b__Brn__Country)
                .HasDefaultValueSql("((0))")
                .HasComment("m_ent_b__Brn __ Countiry ID");
            entity.Property(e => e.m_ent_b__Brn__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Brn__Cst_Id).HasComment("m_ent_b__Brn __ Customer Number");
            entity.Property(e => e.m_ent_b__Brn__Currency)
                .HasDefaultValueSql("((0))")
                .HasComment("m_ent_b__Brn __ Currency ID");
            entity.Property(e => e.m_ent_b__Brn__Div_Id).HasComment("m_ent_b__Brn __ Division Number");
            entity.Property(e => e.m_ent_b__Brn__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Brn__Email_1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Email 1");
            entity.Property(e => e.m_ent_b__Brn__Email_2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Email 2");
            entity.Property(e => e.m_ent_b__Brn__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ English Name");
            entity.Property(e => e.m_ent_b__Brn__Ent_Id).HasComment("m_ent_b__Brn __ Enterprise Number");
            entity.Property(e => e.m_ent_b__Brn__Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ fax");
            entity.Property(e => e.m_ent_b__Brn__Is_Act).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Brn__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Brn__Logo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Logo file path");
            entity.Property(e => e.m_ent_b__Brn__Mobile_1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Mobile 1");
            entity.Property(e => e.m_ent_b__Brn__Mobile_2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Mobile 2");
            entity.Property(e => e.m_ent_b__Brn__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Note");
            entity.Property(e => e.m_ent_b__Brn__Phone_1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Phone 1");
            entity.Property(e => e.m_ent_b__Brn__Phone_2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Phone 2");
            entity.Property(e => e.m_ent_b__Brn__Upd_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Brn__Website)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Brn __ Website");

            entity.HasOne(d => d.m_ent_b__Brn__Div).WithMany(p => p.m_ent_b__Brns)
                .HasForeignKey(d => d.m_ent_b__Brn__Div_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Div_Brn");
        });

        modelBuilder.Entity<m_ent_b__Cst>(entity =>
        {
            entity.HasKey(e => e.m_ent_b__Cst__Cst_Id).HasName("PK__m_ent_b___17D481677B8283C8");

            entity.ToTable("m_ent_b__Cst", "dbo", tb =>
                {
                    tb.HasTrigger("insertCustomer");
                    tb.HasTrigger("updateCustomer");
                });

            entity.Property(e => e.m_ent_b__Cst__Cst_Id)
                .ValueGeneratedNever()
                .HasComment("m_ent_b__Cst __ Customer Number");
            entity.Property(e => e.m_ent_b__Cst__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Cst __ Arabic Name");
            entity.Property(e => e.m_ent_b__Cst__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Cst__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Cst__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Cst __ English Name");
            entity.Property(e => e.m_ent_b__Cst__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Cst__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Cst __ Note");
            entity.Property(e => e.m_ent_b__Cst__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<m_ent_b__DB>(entity =>
        {
            entity.HasKey(e => e.m_ent_b__DBs__DB_Id).HasName("PK__m_ent_b___402C1B8A66E22938");

            entity.ToTable("m_ent_b__DBs", "dbo");

            entity.Property(e => e.m_ent_b__DBs__DB_Id)
                .ValueGeneratedNever()
                .HasComment("m_rpt_b__DBs __ Database Number");
            entity.Property(e => e.m_ent_b__DBs__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_rpt_b__DBs __ Arabic Name");
            entity.Property(e => e.m_ent_b__DBs__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__DBs__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__DBs__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_rpt_b__DBs __ English Name");
            entity.Property(e => e.m_ent_b__DBs__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__DBs__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.m_ent_b__DBs__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<m_ent_b__Div>(entity =>
        {
            entity.HasKey(e => e.m_ent_b__Div__Div_Id).HasName("PK__m_ent_b___03C61D2E83012BA1");

            entity.ToTable("m_ent_b__Div", "dbo");

            entity.Property(e => e.m_ent_b__Div__Div_Id)
                .ValueGeneratedNever()
                .HasComment("m_ent_b__Div __ Division Number");
            entity.Property(e => e.m_ent_b__Div__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Div __ Arabic Name");
            entity.Property(e => e.m_ent_b__Div__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Div__Cst_Id).HasComment("m_ent_b__Div __ Customer Number");
            entity.Property(e => e.m_ent_b__Div__Dld_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Div__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Div __ English Name");
            entity.Property(e => e.m_ent_b__Div__Ent_Id).HasComment("m_ent_b__Div __ Enterprise Number");
            entity.Property(e => e.m_ent_b__Div__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Div__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Div __ Note");
            entity.Property(e => e.m_ent_b__Div__Upd_Date).HasColumnType("datetime");

            entity.HasOne(d => d.m_ent_b__Div__Ent).WithMany(p => p.m_ent_b__Divs)
                .HasForeignKey(d => d.m_ent_b__Div__Ent_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ent_Div");
        });

        modelBuilder.Entity<m_ent_b__Ent>(entity =>
        {
            entity.HasKey(e => e.m_ent_b__Ent__Ent_Id).HasName("PK__m_ent_b___43E36D27B4A4F0B0");

            entity.ToTable("m_ent_b__Ent", "dbo");

            entity.Property(e => e.m_ent_b__Ent__Ent_Id)
                .ValueGeneratedNever()
                .HasComment("m_ent_b__Ent __ Enterprise Number");
            entity.Property(e => e.m_ent_b__Ent__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Ent __ Arabic Name");
            entity.Property(e => e.m_ent_b__Ent__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Ent__Cst_Id).HasComment("m_ent_b__Ent __ Customer Number");
            entity.Property(e => e.m_ent_b__Ent__Dld_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Ent__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Ent __ English Name");
            entity.Property(e => e.m_ent_b__Ent__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Ent__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Ent __ Note");
            entity.Property(e => e.m_ent_b__Ent__Upd_Date).HasColumnType("datetime");

            entity.HasOne(d => d.m_ent_b__Ent__Cst).WithMany(p => p.m_ent_b__Ents)
                .HasForeignKey(d => d.m_ent_b__Ent__Cst_Id)
                .HasConstraintName("FK_Cst_Ent");
        });

        modelBuilder.Entity<m_ent_b__Fld>(entity =>
        {
            entity.HasKey(e => e.m_ent_b__Flds__Fld_Id).HasName("PK__m_ent_b___3E0FDCAF4A92AE73");

            entity.ToTable("m_ent_b__Flds", "dbo");

            entity.Property(e => e.m_ent_b__Flds__Fld_Id)
                .ValueGeneratedNever()
                .HasComment("m_ent_b__Flds __ Filed Number");
            entity.Property(e => e.m_ent_b__Flds__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Flds __ Arabic Name");
            entity.Property(e => e.m_ent_b__Flds__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Flds__DBs_Id).HasComment("m_ent_b__Flds __ Database Number");
            entity.Property(e => e.m_ent_b__Flds__Default)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Flds __ Filed type");
            entity.Property(e => e.m_ent_b__Flds__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Flds__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Flds __ English Name");
            entity.Property(e => e.m_ent_b__Flds__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Flds__Length).HasComment("m_ent_b__Flds __ Filed Length");
            entity.Property(e => e.m_ent_b__Flds__Mandatory)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Flds __ Is filed mandatory");
            entity.Property(e => e.m_ent_b__Flds__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.m_ent_b__Flds__Rpt_Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Flds __ Filed Arabic name to be used for reports");
            entity.Property(e => e.m_ent_b__Flds__Rpt_En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Flds __ Filed English name to be used for reports");
            entity.Property(e => e.m_ent_b__Flds__SQL_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Flds __ Filed name in database");
            entity.Property(e => e.m_ent_b__Flds__Tbl_Id).HasComment("m_ent_b__Flds __ Table Number");
            entity.Property(e => e.m_ent_b__Flds__Upd_Date).HasColumnType("datetime");

            entity.HasOne(d => d.m_ent_b__Flds__Tbl).WithMany(p => p.m_ent_b__Flds)
                .HasForeignKey(d => d.m_ent_b__Flds__Tbl_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbl_Fld");
        });

        modelBuilder.Entity<m_ent_b__Tbl>(entity =>
        {
            entity.HasKey(e => e.m_ent_b__Tbls__Tbl_Id).HasName("PK__m_ent_b___D9BA7CD6AA77DB37");

            entity.ToTable("m_ent_b__Tbls", "dbo");

            entity.Property(e => e.m_ent_b__Tbls__Tbl_Id)
                .ValueGeneratedNever()
                .HasComment("m_ent_b__Tbls __ Table Number");
            entity.Property(e => e.m_ent_b__Tbls__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Tbls __ Arabic Name");
            entity.Property(e => e.m_ent_b__Tbls__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Tbls__DBs_Id).HasComment("m_ent_b__Tbls __ Database Number");
            entity.Property(e => e.m_ent_b__Tbls__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_ent_b__Tbls__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_ent_b__Tbls __ English Name");
            entity.Property(e => e.m_ent_b__Tbls__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_01).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_02).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_03).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_04).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_05).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_06).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_07).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_08).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_09).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Rpt_10).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_01).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_02).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_03).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_04).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_05).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_06).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_07).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_08).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_09).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Scr_10).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_ent_b__Tbls__Upd_Date).HasColumnType("datetime");

            entity.HasOne(d => d.m_ent_b__Tbls__DBs).WithMany(p => p.m_ent_b__Tbls)
                .HasForeignKey(d => d.m_ent_b__Tbls__DBs_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DBs_Tbl");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
