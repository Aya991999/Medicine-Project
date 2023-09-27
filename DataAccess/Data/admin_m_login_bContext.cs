using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyBusinessAPI.Models;

public partial class admin_m_login_bContext : DbContext
{
    public admin_m_login_bContext()
    {
    }

    public admin_m_login_bContext(DbContextOptions<admin_m_login_bContext> options)
        : base(options)
    {
    }

    public virtual DbSet<m_login_b_Sys_Parm> m_login_b_Sys_Parms { get; set; }

    public virtual DbSet<m_login_b__Field> m_login_b__Fields { get; set; }

    public virtual DbSet<m_login_b__User> m_login_b__Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=198.38.84.196;User ID=admin_m_mybusiness_b;Password=MB_Mocha!1;Database=admin_m_login_b;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("admin_m_mybusiness_b");

        modelBuilder.Entity<m_login_b_Sys_Parm>(entity =>
        {
            entity.HasKey(e => e.m_login_b_Sys_Parm__Prm_Id).HasName("PK__m_login___0766BDAD64F7B14F");

            entity.ToTable("m_login_b_Sys_Parm", "dbo");

            entity.Property(e => e.m_login_b_Sys_Parm__Prm_Id)
                .ValueGeneratedNever()
                .HasComment("m_login_b_Sys_Parm __ Parameter Number");
            entity.Property(e => e.m_login_b_Sys_Parm__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_login_b_Sys_Parm __ Parameter Arabic Name");
            entity.Property(e => e.m_login_b_Sys_Parm__Ar_Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("m_login_b_Sys_Parm __ Parameter Arabic Note");
            entity.Property(e => e.m_login_b_Sys_Parm__Company_Prm).HasComment("m_login_b_Sys_Parm __ Is Parameter for company ONLY");
            entity.Property(e => e.m_login_b_Sys_Parm__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_login_b_Sys_Parm__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_login_b_Sys_Parm__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("m_login_b_Sys_Parm __ Parameter English Name");
            entity.Property(e => e.m_login_b_Sys_Parm__En_Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("m_login_b_Sys_Parm __ Parameter English Note");
            entity.Property(e => e.m_login_b_Sys_Parm__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_login_b_Sys_Parm__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<m_login_b__Field>(entity =>
        {
            entity.HasKey(e => e.m_login_b__Fields__Id).HasName("PK__m_login___8D694BE0D49344CC");

            entity.ToTable("m_login_b__Fields", "dbo");

            entity.Property(e => e.m_login_b__Fields__CEDB)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_login_b__Fields__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_login_b__Fields__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_login_b__Fields__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<m_login_b__User>(entity =>
        {
            entity.HasKey(e => e.m_login_b__Users__User_Id).HasName("PK__m_login___16811EA6338F1C92");

            entity.ToTable("m_login_b__Users", "dbo");

            entity.Property(e => e.m_login_b__Users__User_Id).ValueGeneratedNever();
            entity.Property(e => e.m_login_b__Users__Ar_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.m_login_b__Users__CEDB)
                .HasMaxLength(14)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.m_login_b__Users__Crt_Date)
                .HasDefaultValueSql("('01-01-1900')")
                .HasColumnType("datetime");
            entity.Property(e => e.m_login_b__Users__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.m_login_b__Users__En_Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.m_login_b__Users__Is_Act).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_login_b__Users__Is_Sys).HasDefaultValueSql("((0))");
            entity.Property(e => e.m_login_b__Users__Login_Code)
                .HasMaxLength(21)
                .IsFixedLength();
            entity.Property(e => e.m_login_b__Users__Notes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.m_login_b__Users__Upd_Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
