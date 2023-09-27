using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.DBModels;

#nullable disable

namespace MyBusiness.Models
{
    public partial class admin_m_log_bContext : DbContext
    {
        public admin_m_log_bContext()
        {
        }

        public admin_m_log_bContext(DbContextOptions<admin_m_log_bContext> options)
            : base(options)
        {
        }

        public virtual DbSet<M_Log_B_M_Ecommerce_B> M_Log_B_M_Ecommerce_Bs { get; set; }
        public virtual DbSet<M_Log_B_M_Enterprise_B> M_Log_B_M_Enterprise_Bs { get; set; }
        public virtual DbSet<M_Log_B_M_General_Configuration_B> M_Log_B_M_General_Configuration_Bs { get; set; }
        public virtual DbSet<M_Log_B_M_HR_B> M_Log_B_M_HR_Bs { get; set; }
        public virtual DbSet<M_Log_B_M_Hospital_B> M_Log_B_M_Hospital_Bs { get; set; }
        public virtual DbSet<M_Log_B_M_POS_B> M_Log_B_M_POS_Bs { get; set; }
        public virtual DbSet<M_Log_B_M_Trading_B> M_Log_B_M_Trading_Bs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=198.38.84.196;User ID=admin_myshop;Password=WaveSoft2022;Database=admin_m_log_b; Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<M_Log_B_M_Ecommerce_B>(entity =>
            {
                entity.HasKey(e => e.M_Log_B_M_Ecommerce_B_ID)
                    .HasName("PK__M_Log_B___5748C1522982FE4C");

                entity.ToTable("M_Log_B_M_Ecommerce_B", "admin_mybusiness");

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Created_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Created_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Customer_CEDB_Code_Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Date_time).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Deleted_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Deleted_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_IP_Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Updated_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Ecommerce_B_Updated_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<M_Log_B_M_Enterprise_B>(entity =>
            {
                entity.HasKey(e => e.M_Log_B_M_Enterprise_B_ID)
                    .HasName("PK__M_Log_B___FF885AA747B2E6E9");

                entity.ToTable("M_Log_B_M_Enterprise_B", "admin_mybusiness");

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Created_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Created_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Customer_CEDB_Code_Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Date_time).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Deleted_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Deleted_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Enterprise_B_IP_Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Updated_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Enterprise_B_Updated_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<M_Log_B_M_General_Configuration_B>(entity =>
            {
                entity.HasKey(e => e.M_Log_B_M_General_Configuration_B_ID)
                    .HasName("PK__M_Log_B___68930DED69EF38A5");

                entity.ToTable("M_Log_B_M_General_Configuration_B", "admin_mybusiness");

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Created_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Created_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Customer_CEDB_Code_Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Date_time).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Deleted_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Deleted_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_IP_Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Updated_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_General_Configuration_B_Updated_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<M_Log_B_M_HR_B>(entity =>
            {
                entity.HasKey(e => e.M_Log_B_M_HR_B_ID)
                    .HasName("PK__M_Log_B___40D6334841933A8F");

                entity.ToTable("M_Log_B_M_HR_B", "admin_mybusiness");

                entity.Property(e => e.M_Log_B_M_HR_B_Created_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_HR_B_Created_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_HR_B_Customer_CEDB_Code_Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_HR_B_Date_time).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_HR_B_Deleted_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_HR_B_Deleted_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_HR_B_Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_HR_B_IP_Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_HR_B_Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_HR_B_Updated_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_HR_B_Updated_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<M_Log_B_M_Hospital_B>(entity =>
            {
                entity.HasKey(e => e.M_Log_B_M_Hospital_B_ID)
                    .HasName("PK__M_Log_B___80AE308DC3D3227E");

                entity.ToTable("M_Log_B_M_Hospital_B", "admin_mybusiness");

                entity.Property(e => e.M_Log_B_M_Hospital_B_Created_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Hospital_B_Created_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Hospital_B_Customer_CEDB_Code_Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Hospital_B_Date_time).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Hospital_B_Deleted_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Hospital_B_Deleted_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Hospital_B_Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Hospital_B_IP_Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Hospital_B_Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Hospital_B_Updated_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Hospital_B_Updated_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<M_Log_B_M_POS_B>(entity =>
            {
                entity.HasKey(e => e.M_Log_B_M_POS_B_ID)
                    .HasName("PK__M_Log_B___7E86CA7B15CC3BDD");

                entity.ToTable("M_Log_B_M_POS_B", "admin_mybusiness");

                entity.Property(e => e.M_Log_B_M_POS_B_Created_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_POS_B_Created_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_POS_B_Customer_CEDB_Code_Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_POS_B_Date_time).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_POS_B_Deleted_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_POS_B_Deleted_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_POS_B_Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_POS_B_IP_Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_POS_B_Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_POS_B_Updated_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_POS_B_Updated_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<M_Log_B_M_Trading_B>(entity =>
            {
                entity.HasKey(e => e.M_Log_B_M_Trading_B_ID)
                    .HasName("PK__M_Log_B___2A38CD69A0763337");

                entity.ToTable("M_Log_B_M_Trading_B", "admin_mybusiness");

                entity.Property(e => e.M_Log_B_M_Trading_B_Created_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Trading_B_Created_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Trading_B_Customer_CEDB_Code_Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Trading_B_Date_time).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Trading_B_Deleted_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Trading_B_Deleted_Date).HasColumnType("datetime");

                entity.Property(e => e.M_Log_B_M_Trading_B_Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Trading_B_IP_Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Trading_B_Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Trading_B_Updated_By)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M_Log_B_M_Trading_B_Updated_Date).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
