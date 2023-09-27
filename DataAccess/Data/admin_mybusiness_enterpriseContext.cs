using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyBusinessAPI.Models;

public partial class admin_mybusiness_enterpriseContext : DbContext
{
    public admin_mybusiness_enterpriseContext()
    {
    }

    public admin_mybusiness_enterpriseContext(DbContextOptions<admin_mybusiness_enterpriseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<M_Enterprise_B_BO_User> M_Enterprise_B_BO_Users { get; set; }

    public virtual DbSet<M_Enterprise_B_Branch> M_Enterprise_B_Branches { get; set; }

    public virtual DbSet<M_Enterprise_B_Branch_print_Format> M_Enterprise_B_Branch_print_Formats { get; set; }

    public virtual DbSet<M_Enterprise_B_Customer> M_Enterprise_B_Customers { get; set; }

    public virtual DbSet<M_Enterprise_B_Customer_1000> M_Enterprise_B_Customer_1000s { get; set; }

   // public virtual DbSet<M_Enterprise_B_Databse> M_Enterprise_B_Databses { get; set; }

    public virtual DbSet<M_Enterprise_B_Division> M_Enterprise_B_Divisions { get; set; }

    public virtual DbSet<M_Enterprise_B_Enterprise> M_Enterprise_B_Enterprises { get; set; }

    //public virtual DbSet<M_Enterprise_B_Field> M_Enterprise_B_Fields { get; set; }

    //public virtual DbSet<M_Enterprise_B_Login_Option> M_Enterprise_B_Login_Options { get; set; }

    //public virtual DbSet<M_Enterprise_B_System_Customer_Module> M_Enterprise_B_System_Customer_Modules { get; set; }

    public virtual DbSet<M_Enterprise_B_System_Function> M_Enterprise_B_System_Functions { get; set; }

    public virtual DbSet<M_Enterprise_B_System_Function_Color_Status> M_Enterprise_B_System_Function_Color_Statuses { get; set; }

    public virtual DbSet<M_Enterprise_B_System_Function_Note_Link> M_Enterprise_B_System_Function_Note_Links { get; set; }

  //  public virtual DbSet<M_Enterprise_B_System_Function_Options_AYA> M_Enterprise_B_System_Function_Options_AYAs { get; set; }

    public virtual DbSet<M_Enterprise_B_System_Function_Remark> M_Enterprise_B_System_Function_Remarks { get; set; }

    public virtual DbSet<M_Enterprise_B_System_Function_Status_Color> M_Enterprise_B_System_Function_Status_Colors { get; set; }

    //public virtual DbSet<M_Enterprise_B_System_Module> M_Enterprise_B_System_Modules { get; set; }

    //public virtual DbSet<M_Enterprise_B_System_Parameter> M_Enterprise_B_System_Parameters { get; set; }

    //public virtual DbSet<M_Enterprise_B_System_Parameters_AYA> M_Enterprise_B_System_Parameters_AYAs { get; set; }

    //public virtual DbSet<M_Enterprise_B_Table> M_Enterprise_B_Tables { get; set; }

    //public virtual DbSet<M_Standard_B_Date_Type> M_Standard_B_Date_Types { get; set; }

    public virtual DbSet<Type_Of_Filed> Type_Of_Fileds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=198.38.84.196;User ID=admin_myshop;Password=WaveSoft2022;Database=admin_mybusiness_enterprise;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("admin_myshop")
            .UseCollation("Arabic_100_CI_AS_WS_SC");

        modelBuilder.Entity<M_Enterprise_B_BO_User>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_BO_Users_Id).HasName("PK__M_Enterp__7B567965F6AD3479");

            entity.ToTable("M_Enterprise_B_BO_Users", "dbo");

            entity.Property(e => e.M_Enterprise_B_BO_Users_Address)
                .HasMaxLength(200)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Created_Date).HasColumnType("smalldatetime");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Deleted_Date).HasColumnType("smalldatetime");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Email_1)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Email_2)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Last_Login_Date_Time).HasColumnType("smalldatetime");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Last_Login_IP)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Mobile_1)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Mobile_2)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Phone_1)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Phone_2)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_Photo)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_User_Arabic_Name)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_BO_Users_User_English_Name)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<M_Enterprise_B_Branch>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_Branch_Branch_Id).HasName("PK__M_Enterp__0F0CF936DF7ED322");

            entity.ToTable("M_Enterprise_B_Branch", "dbo");

            entity.Property(e => e.M_Enterprise_B_Branch_Branch_Id).ValueGeneratedNever();
            entity.Property(e => e.M_Enterprise_B_Branch_Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Ar_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Branch_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Branch_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Branch_Email_1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Email_2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_En_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Branch_Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Logo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Mobile_1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Mobile_2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Phone_1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Phone_2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_Updated_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Branch_Website)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.M_Enterprise_B_Branch_Cus).WithMany(p => p.M_Enterprise_B_Branches)
                .HasForeignKey(d => d.M_Enterprise_B_Branch_Cus_Id)
                .HasConstraintName("FK__M_Enterpr__M_Ent__4999D985");

            entity.HasOne(d => d.M_Enterprise_B_Branch_Div).WithMany(p => p.M_Enterprise_B_Branches)
                .HasForeignKey(d => d.M_Enterprise_B_Branch_Div_Id)
                .HasConstraintName("FK__M_Enterpr__M_Ent__0CFADF99");

            entity.HasOne(d => d.M_Enterprise_B_Branch_Ent).WithMany(p => p.M_Enterprise_B_Branches)
                .HasForeignKey(d => d.M_Enterprise_B_Branch_Ent_Id)
                .HasConstraintName("FK__M_Enterpr__M_Ent__0B129727");
        });

        modelBuilder.Entity<M_Enterprise_B_Branch_print_Format>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_Branch_print_Format_CEDB).HasName("PK__M_Enterp__FC45AAE280DA60B8");

            entity.ToTable("M_Enterprise_B_Branch_print_Format", "dbo");

            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_CEDB).ValueGeneratedNever();
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_External_Report_Footer_1)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_External_Report_Footer_2)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_External_Report_Footer_3)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_External_Report_Header_1)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_External_Report_Header_2)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_External_Report_Header_3)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_Internal_Report_Footer_1)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_Internal_Report_Footer_2)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_Internal_Report_Footer_3)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_Internal_Report_Header_1)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_Internal_Report_Header_2)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_Branch_print_Format_Internal_Report_Header_3)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<M_Enterprise_B_Customer>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_Customer_Id).HasName("PK__M_Enterp__39BD8136DABFA2F9");

            entity.ToTable("M_Enterprise_B_Customer", "dbo");

            entity.Property(e => e.M_Enterprise_B_Customer_Id).ValueGeneratedNever();
            entity.Property(e => e.M_Enterprise_B_Customer_Activation_Code).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Customer_Ar_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Customer_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Customer_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Customer_En_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Customer_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Enterprise_B_Customer_1000>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_Customer_Id).HasName("PK__EI_TEST___39BD8136C5C22A33");

            entity.ToTable("M_Enterprise_B_Customer_1000", "dbo");

            entity.Property(e => e.M_Enterprise_B_Customer_Id).ValueGeneratedNever();
            entity.Property(e => e.M_Enterprise_B_Customer_Arabic_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Customer_CEDB_Code_Id)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_Customer_Created_By)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_Customer_Created_Date).HasColumnType("smalldatetime");
            entity.Property(e => e.M_Enterprise_B_Customer_Deleted_By)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_Customer_Deleted_Date).HasColumnType("smalldatetime");
            entity.Property(e => e.M_Enterprise_B_Customer_English_Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_Customer_Updated_By)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_Customer_Updated_Date).HasColumnType("smalldatetime");
        });

        //modelBuilder.Entity<M_Enterprise_B_Databse>(entity =>
        //{
        //    entity.HasKey(e => e.M_Enterprise_B_Databses_Id).HasName("PK__M_Enterp__6DACCB992EC616EF");

        //    entity.ToTable("M_Enterprise_B_Databse", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_Databses_Arabic_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_Databses_Arabic_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Databses_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Databses_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Databses_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Databses_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Databses_English_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_Databses_English_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Databses_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Databses_Updated_Date).HasColumnType("datetime");
        //});

        modelBuilder.Entity<M_Enterprise_B_Division>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_Division_Id).HasName("PK__M_Enterp__F9DF9AD43B5CAB58");

            entity.ToTable("M_Enterprise_B_Division", "dbo");

            entity.Property(e => e.M_Enterprise_B_Division_Id).ValueGeneratedNever();
            entity.Property(e => e.M_Enterprise_B_Division_Ar_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Division_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Division_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Division_En_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Division_Updated_Date).HasColumnType("datetime");

            entity.HasOne(d => d.M_Enterprise_B_Division_Cus).WithMany(p => p.M_Enterprise_B_Divisions)
                .HasForeignKey(d => d.M_Enterprise_B_Division_Cus_Id)
                .HasConstraintName("FK__M_Enterpr__M_Ent__48A5B54C");

            entity.HasOne(d => d.M_Enterprise_B_Division_Ent).WithMany(p => p.M_Enterprise_B_Divisions)
                .HasForeignKey(d => d.M_Enterprise_B_Division_Ent_Id)
                .HasConstraintName("FK__M_Enterpr__M_Ent__07420643");
        });

        modelBuilder.Entity<M_Enterprise_B_Enterprise>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_Enterprise_Id).HasName("PK__M_Enterp__25FC3CFC44B4D1E2");

            entity.ToTable("M_Enterprise_B_Enterprise", "dbo");

            entity.Property(e => e.M_Enterprise_B_Enterprise_Id).ValueGeneratedNever();
            entity.Property(e => e.M_Enterprise_B_Enterprise_Ar_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Enterprise_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Enterprise_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_Enterprise_En_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_Enterprise_Updated_Date).HasColumnType("datetime");

            entity.HasOne(d => d.M_Enterprise_B_Enterprise_Cus).WithMany(p => p.M_Enterprise_B_Enterprises)
                .HasForeignKey(d => d.M_Enterprise_B_Enterprise_Cus_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__M_Enterpr__M_Ent__47B19113");
        });

        //modelBuilder.Entity<M_Enterprise_B_Field>(entity =>
        //{
        //    entity.HasKey(e => e.M_Enterprise_B_Fields_Filed_Id).HasName("PK__M_Enterp__7CE66B8ECD39D49D");

        //    entity.ToTable("M_Enterprise_B_Fields", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_Fields_Arabic_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_Fields_Arabic_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Fields_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Fields_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Fields_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Fields_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Fields_English_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_Fields_English_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Fields_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Fields_Updated_Date).HasColumnType("datetime");

        //    entity.HasOne(d => d.M_Enterprise_B_Fields_Table).WithMany(p => p.M_Enterprise_B_Fields)
        //        .HasForeignKey(d => d.M_Enterprise_B_Fields_Table_Id)
        //        .HasConstraintName("FK__M_Enterpr__M_Ent__2B155265");
        //});

        //modelBuilder.Entity<M_Enterprise_B_Login_Option>(entity =>
        //{
        //    entity.HasKey(e => e.M_Enterprise_B_Login_Options_Id).HasName("PK__M_Enterp__0563CDE676468675");

        //    entity.ToTable("M_Enterprise_B_Login_Options", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_Login_Options_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Login_Options_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Login_Options_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Login_Options_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Login_Options_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Login_Options_Updated_Date).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<M_Enterprise_B_System_Customer_Module>(entity =>
        //{
        //    entity.HasKey(e => e.M_Enterprise_B_System_Customer_Modules_Id).HasName("PK__M_Enterp__F0EA2E6941BD419D");

        //    entity.ToTable("M_Enterprise_B_System_Customer_Modules", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Arabic_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Arabic_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_CEDB_Id).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_English_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_English_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Customer_Modules_Updated_Date).HasColumnType("datetime");

        //    entity.HasOne(d => d.M_Enterprise_B_System_Customer_Modules_Modules).WithMany(p => p.M_Enterprise_B_System_Customer_Modules)
        //        .HasForeignKey(d => d.M_Enterprise_B_System_Customer_Modules_Modules_Id)
        //        .HasConstraintName("FK__M_Enterpr__M_Ent__33AA9866");
        //});

        modelBuilder.Entity<M_Enterprise_B_System_Function>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_System_Function_Id).HasName("MyPrimaryKey");

            entity.ToTable("M_Enterprise_B_System_Function", "dbo");

            entity.Property(e => e.M_Enterprise_B_System_Function_Arabic_Description).HasMaxLength(500);
            entity.Property(e => e.M_Enterprise_B_System_Function_Arabic_Name).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_System_Function_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_System_Function_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_System_Function_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_System_Function_Deleted_Date).HasColumnType("smalldatetime");
            entity.Property(e => e.M_Enterprise_B_System_Function_English_Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_English_Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_Icon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_System_Function_Updated_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_System_Function_Ver_2012_Link)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_Ver_2017_Link)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_Ver_2020_Link)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_Ver_2023_Link)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_Ver_Html_Link)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.M_Enterprise_B_System_Function_Ver_Other_Link)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<M_Enterprise_B_System_Function_Color_Status>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_System_Function_Color_Status_Id).HasName("PK__M_Enterp__F31D0388A35EF10E");

            entity.ToTable("M_Enterprise_B_System_Function_Color_Status", "dbo");

            entity.Property(e => e.M_Enterprise_B_System_Function_Color_Status_Created_By).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_System_Function_Color_Status_Created_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_System_Function_Color_Status_Deleted_By).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_System_Function_Color_Status_Deleted_Date).HasColumnType("datetime");
            entity.Property(e => e.M_Enterprise_B_System_Function_Color_Status_Updated_By).HasMaxLength(100);
            entity.Property(e => e.M_Enterprise_B_System_Function_Color_Status_Updated_Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<M_Enterprise_B_System_Function_Note_Link>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_System_Function_Note_Link_Id).HasName("PK__MyEnterp__9FB56F8E1BD450AA");

            entity.ToTable("M_Enterprise_B_System_Function_Note_Link", "dbo");

            entity.Property(e => e.M_Enterprise_B_System_Function_Note_Link_Links)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.M_Enterprise_B_System_Function_Note_Link_Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        //modelBuilder.Entity<M_Enterprise_B_System_Function_Options_AYA>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("M_Enterprise_B_System_Function_Options_AYA", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_CEDB_Code_Id).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_Id).ValueGeneratedOnAdd();
        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Function_Options_Updated_Date).HasColumnType("datetime");
        //});

        modelBuilder.Entity<M_Enterprise_B_System_Function_Remark>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_System_Function_Remarks_Id).HasName("PK__MyEnterp__BE43296F3713B1A7");

            entity.ToTable("M_Enterprise_B_System_Function_Remarks", "dbo");

            entity.Property(e => e.M_Enterprise_B_System_Function_Remarks_Remark)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<M_Enterprise_B_System_Function_Status_Color>(entity =>
        {
            entity.HasKey(e => e.M_Enterprise_B_System_Function_Status_Color_Id).HasName("PK__MyEnterp__F7BA985EE4EF8127");

            entity.ToTable("M_Enterprise_B_System_Function_Status_Color", "dbo");

            entity.Property(e => e.M_Enterprise_B_System_Function_Status_Color_Colors)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        //modelBuilder.Entity<M_Enterprise_B_System_Module>(entity =>
        //{
        //    entity.HasKey(e => e.M_Enterprise_B_System_Modules_Id).HasName("PK__M_Enterp__90D8DBE4B1D74872");

        //    entity.ToTable("M_Enterprise_B_System_Modules", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_System_Modules_Arabic_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_System_Modules_Arabic_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Modules_English_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_System_Modules_English_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Updated_Date).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<M_Enterprise_B_System_Parameter>(entity =>
        //{
        //    entity.HasKey(e => e.M_Enterprise_B_System_Parameters_Id).HasName("PK__M_Enterp__32C894FC98EFC527");

        //    entity.ToTable("M_Enterprise_B_System_Parameters", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_CEDB_Id)
        //        .HasMaxLength(15)
        //        .IsUnicode(false);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Cloud_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Currency_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Decimal_Point_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Expiration_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_OnPremises_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_One_Branch_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Updated_Date).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<M_Enterprise_B_System_Parameters_AYA>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("M_Enterprise_B_System_Parameters_AYA", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Cloud_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Currency_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Decimal_Point_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Expiration_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Id).ValueGeneratedOnAdd();
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_OnPremises_Desc).HasMaxLength(200);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_System_Parameters_Updated_Date).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<M_Enterprise_B_Table>(entity =>
        //{
        //    entity.HasKey(e => e.M_Enterprise_B_Tables_Table_Id).HasName("PK__M_Enterp__46859ABB08C7FA2F");

        //    entity.ToTable("M_Enterprise_B_Tables", "admin_mybusiness");

        //    entity.Property(e => e.M_Enterprise_B_Tables_Arabic_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_Tables_Arabic_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Tables_Created_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Tables_Created_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Tables_Deleted_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Tables_Deleted_Date).HasColumnType("datetime");
        //    entity.Property(e => e.M_Enterprise_B_Tables_English_Desc).HasMaxLength(500);
        //    entity.Property(e => e.M_Enterprise_B_Tables_English_Name).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Tables_Updated_By).HasMaxLength(100);
        //    entity.Property(e => e.M_Enterprise_B_Tables_Updated_Date).HasColumnType("datetime");

        //    entity.HasOne(d => d.M_Enterprise_B_Tables_Databse).WithMany(p => p.M_Enterprise_B_Tables)
        //        .HasForeignKey(d => d.M_Enterprise_B_Tables_Databse_Id)
        //        .HasConstraintName("FK__M_Enterpr__M_Ent__255C790F");
        //});

        //modelBuilder.Entity<M_Standard_B_Date_Type>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("M_Standard_B_Date_Type", "admin_mybusiness");

        //    entity.Property(e => e.M_Standard_B_Date_Type_BINARY)
        //        .HasMaxLength(50)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_CHAR_10)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_CHAR_20)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_CHAR_30)
        //        .HasMaxLength(30)
        //        .IsUnicode(false)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_CHAR_40)
        //        .HasMaxLength(40)
        //        .IsUnicode(false)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_CHAR_50)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_DATE).HasColumnType("date");
        //    entity.Property(e => e.M_Standard_B_Date_Type_DATE_TIME).HasColumnType("datetime");
        //    entity.Property(e => e.M_Standard_B_Date_Type_DECIMAL).HasColumnType("decimal(18, 3)");
        //    entity.Property(e => e.M_Standard_B_Date_Type_IMAGE).HasColumnType("image");
        //    entity.Property(e => e.M_Standard_B_Date_Type_MONEY).HasColumnType("money");
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_10)
        //        .HasMaxLength(10)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_100)
        //        .HasMaxLength(100)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_20)
        //        .HasMaxLength(20)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_200)
        //        .HasMaxLength(200)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_30)
        //        .HasMaxLength(30)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_300)
        //        .HasMaxLength(300)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_40)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_400)
        //        .HasMaxLength(400)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_50)
        //        .HasMaxLength(50)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_500)
        //        .HasMaxLength(500)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_60)
        //        .HasMaxLength(60)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_70)
        //        .HasMaxLength(70)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_80)
        //        .HasMaxLength(80)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NCHAR_90)
        //        .HasMaxLength(90)
        //        .IsFixedLength();
        //    entity.Property(e => e.M_Standard_B_Date_Type_NUMIREC).HasColumnType("numeric(18, 3)");
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_100).HasMaxLength(100);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_200).HasMaxLength(200);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_300).HasMaxLength(300);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_400).HasMaxLength(400);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_50).HasMaxLength(50);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_500).HasMaxLength(500);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_60).HasMaxLength(60);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_70).HasMaxLength(70);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_80).HasMaxLength(80);
        //    entity.Property(e => e.M_Standard_B_Date_Type_NVARCHAR_90).HasMaxLength(90);
        //    entity.Property(e => e.M_Standard_B_Date_Type_SMALLDATETIME).HasColumnType("smalldatetime");
        //    entity.Property(e => e.M_Standard_B_Date_Type_SMALLMONEY).HasColumnType("smallmoney");
        //    entity.Property(e => e.M_Standard_B_Date_Type_SQL_VARIANT).HasColumnType("sql_variant");
        //    entity.Property(e => e.M_Standard_B_Date_Type_TIMESTAMP)
        //        .IsRowVersion()
        //        .IsConcurrencyToken();
        //    entity.Property(e => e.M_Standard_B_Date_Type_XML).HasColumnType("xml");
        //    entity.Property(e => e.M_Standard_B_Date_Type_varbinary).HasMaxLength(50);
        //    entity.Property(e => e.M_Standard_B_Date_Type_varchar_100)
        //        .HasMaxLength(100)
        //        .IsUnicode(false);
        //    entity.Property(e => e.M_Standard_B_Date_Type_varchar_200)
        //        .HasMaxLength(200)
        //        .IsUnicode(false);
        //    entity.Property(e => e.M_Standard_B_Date_Type_varchar_300)
        //        .HasMaxLength(300)
        //        .IsUnicode(false);
        //    entity.Property(e => e.M_Standard_B_Date_Type_varchar_400)
        //        .HasMaxLength(400)
        //        .IsUnicode(false);
        //    entity.Property(e => e.M_Standard_B_Date_Type_varchar_50)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.M_Standard_B_Date_Type_varchar_500)
        //        .HasMaxLength(500)
        //        .IsUnicode(false);
        //    entity.Property(e => e.M_Standard_B_Date_Type_varchar_MAX).IsUnicode(false);
        //    entity.Property(e => e._M_Standard_B_Date_Type_SMALLINNT).HasColumnName("[M_Standard_B_Date_Type_SMALLINNT");
        //});

        modelBuilder.Entity<Type_Of_Filed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Type_Of_Fileds", "admin_mybusiness");

            entity.Property(e => e.q01)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.q03)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.q05).HasColumnType("date");
            entity.Property(e => e.q06).HasColumnType("datetime");
            entity.Property(e => e.q09).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.q14).HasColumnType("image");
            entity.Property(e => e.q16).HasColumnType("money");
            entity.Property(e => e.q18).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.q19).HasMaxLength(50);
            entity.Property(e => e.q22).HasColumnType("smalldatetime");
            entity.Property(e => e.q24).HasColumnType("smallmoney");
            entity.Property(e => e.q25).HasColumnType("sql_variant");
            entity.Property(e => e.q28)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.q31).HasMaxLength(50);
            entity.Property(e => e.q33)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.q34).IsUnicode(false);
            entity.Property(e => e.q35).HasColumnType("xml");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
