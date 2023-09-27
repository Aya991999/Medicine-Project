using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyBusinessAPI.Models;

public partial class admin_client_setupContext : DbContext
{
    public admin_client_setupContext()
    {
    }

    public admin_client_setupContext(DbContextOptions<admin_client_setupContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client_Setup_GEN__Blood_Type> Client_Setup_GEN__Blood_Types { get; set; }

    public virtual DbSet<Client_Setup_GEN__City> Client_Setup_GEN__Cities { get; set; }

    public virtual DbSet<Client_Setup_GEN__Country> Client_Setup_GEN__Countries { get; set; }

    public virtual DbSet<Client_Setup_GEN__Degree> Client_Setup_GEN__Degrees { get; set; }

    public virtual DbSet<Client_Setup_GEN__Grade> Client_Setup_GEN__Grades { get; set; }

    public virtual DbSet<Client_Setup_GEN__Language> Client_Setup_GEN__Languages { get; set; }

    public virtual DbSet<Client_Setup_GEN__Military_Status> Client_Setup_GEN__Military_Statuses { get; set; }

    public virtual DbSet<Client_Setup_GEN__Nationality> Client_Setup_GEN__Nationalities { get; set; }

    public virtual DbSet<Client_Setup_GEN__Realign> Client_Setup_GEN__Realigns { get; set; }

    public virtual DbSet<Client_Setup_GEN__Relative> Client_Setup_GEN__Relatives { get; set; }

    public virtual DbSet<Client_Setup_GEN__Social> Client_Setup_GEN__Socials { get; set; }

    public virtual DbSet<Client_Setup_GEN__University> Client_Setup_GEN__Universities { get; set; }

    public virtual DbSet<Client_Setup__Login_Field> Client_Setup__Login_Fields { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=198.38.84.196;User ID=admin_m_mybusiness_b;Password=MB_Mocha!1;Database=admin_client_setup;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("admin_m_mybusiness_b");

        modelBuilder.Entity<Client_Setup_GEN__Blood_Type>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Blood_Type__Id).HasName("PK__Client_S__3F62308FA2D3DE90");

            entity.ToTable("Client_Setup_GEN__Blood_Type", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Blood_Type__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Blood_Type__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Blood_Type__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Blood_Type__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Blood_Type__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__City>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__City_Id).HasName("PK__Client_S__C31E009680069FCD");

            entity.ToTable("Client_Setup_GEN__City", "dbo");

            entity.Property(e => e.Client_Setup_GEN__City__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__City__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__City__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__City__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__City__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Country>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Country__Id).HasName("PK__Client_S__BBF96D0885BB66E3");

            entity.ToTable("Client_Setup_GEN__Country", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Country__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Country__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Country__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Country__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Country__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Degree>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Degree__Id).HasName("PK__Client_S__AD2598562C02910B");

            entity.ToTable("Client_Setup_GEN__Degree", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Degree__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Degree__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Degree__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Degree__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Degree__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Grade>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Grade__Id).HasName("PK__Client_S__68E6A916EC522D25");

            entity.ToTable("Client_Setup_GEN__Grade", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Grade__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Grade__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Grade__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Grade__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Grade__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Language>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Language__Id).HasName("PK__Client_S__616A9EF5150D5A17");

            entity.ToTable("Client_Setup_GEN__Language", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Language__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Language__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Language__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Language__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Language__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Military_Status>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Military_Status__Id).HasName("PK__Client_S__D71DE6420D81867A");

            entity.ToTable("Client_Setup_GEN__Military_Status", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Military_Status__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Military_Status__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Military_Status__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Military_Status__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Military_Status__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Nationality>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Nationality__Id).HasName("PK__Client_S__3D9BE15279F832A9");

            entity.ToTable("Client_Setup_GEN__Nationality", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Nationality__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Nationality__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Nationality__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Nationality__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Nationality__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Realign>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Realign__Id).HasName("PK__Client_S__70BD99FD0282C5F2");

            entity.ToTable("Client_Setup_GEN__Realign", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Realign__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Realign__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Realign__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Realign__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Realign__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Relative>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Relative__Id).HasName("PK__Client_S__477BFDA74965F7AC");

            entity.ToTable("Client_Setup_GEN__Relative", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Relative__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Relative__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Relative__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Relative__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Relative__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__Social>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__Social__Id).HasName("PK__Client_S__C82345A4E33ACBAA");

            entity.ToTable("Client_Setup_GEN__Social", "dbo");

            entity.Property(e => e.Client_Setup_GEN__Social__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Social__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Social__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__Social__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__Social__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup_GEN__University>(entity =>
        {
            entity.HasKey(e => e.Client_Setup_GEN__University__Id).HasName("PK__Client_S__E02E181CBA037CBA");

            entity.ToTable("Client_Setup_GEN__University", "dbo");

            entity.Property(e => e.Client_Setup_GEN__University__Ar_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__University__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__University__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup_GEN__University__En_Name).HasMaxLength(50);
            entity.Property(e => e.Client_Setup_GEN__University__Upd_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Client_Setup__Login_Field>(entity =>
        {
            entity.HasKey(e => e.Client_Setup__Login_Fields__Id).HasName("PK__Client_S__A44348B0D58B77F9");

            entity.ToTable("Client_Setup__Login_Fields", "dbo");

            entity.Property(e => e.Client_Setup__Login_Fields__CEDB)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.Client_Setup__Login_Fields__Crt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup__Login_Fields__Dlt_Date).HasColumnType("datetime");
            entity.Property(e => e.Client_Setup__Login_Fields__Upd_Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
