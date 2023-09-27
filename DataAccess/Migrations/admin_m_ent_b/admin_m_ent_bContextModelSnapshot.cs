﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBusinessAPI.Models;

#nullable disable

namespace DataAccess.Migrations.admin_m_ent_b
{
    [DbContext(typeof(admin_m_ent_bContext))]
    partial class admin_m_ent_bContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("admin_m_mybusiness_b")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Brn", b =>
                {
                    b.Property<int>("m_ent_b__Brn__Brn_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Brn __ Branch Number");

                    b.Property<string>("m_ent_b__Brn__Address")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Branch Address");

                    b.Property<string>("m_ent_b__Brn__Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Arabic Name");

                    b.Property<int?>("m_ent_b__Brn__City")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))")
                        .HasComment("m_ent_b__Brn __ City ID");

                    b.Property<int?>("m_ent_b__Brn__Country")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))")
                        .HasComment("m_ent_b__Brn __ Countiry ID");

                    b.Property<int>("m_ent_b__Brn__Crt_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("m_ent_b__Brn__Crt_Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('01-01-1900')");

                    b.Property<int>("m_ent_b__Brn__Cst_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Brn __ Customer Number");

                    b.Property<int?>("m_ent_b__Brn__Currency")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))")
                        .HasComment("m_ent_b__Brn __ Currency ID");

                    b.Property<int>("m_ent_b__Brn__Div_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Brn __ Division Number");

                    b.Property<int?>("m_ent_b__Brn__Dlt_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Brn__Dlt_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("m_ent_b__Brn__Email_1")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Email 1");

                    b.Property<string>("m_ent_b__Brn__Email_2")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Email 2");

                    b.Property<string>("m_ent_b__Brn__En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ English Name");

                    b.Property<int>("m_ent_b__Brn__Ent_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Brn __ Enterprise Number");

                    b.Property<string>("m_ent_b__Brn__Fax")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ fax");

                    b.Property<bool?>("m_ent_b__Brn__Is_Act")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool>("m_ent_b__Brn__Is_Dlt")
                        .HasColumnType("bit");

                    b.Property<bool?>("m_ent_b__Brn__Is_Sys")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("m_ent_b__Brn__Logo")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Logo file path");

                    b.Property<string>("m_ent_b__Brn__Mobile_1")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Mobile 1");

                    b.Property<string>("m_ent_b__Brn__Mobile_2")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Mobile 2");

                    b.Property<string>("m_ent_b__Brn__Notes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Note");

                    b.Property<string>("m_ent_b__Brn__Phone_1")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Phone 1");

                    b.Property<string>("m_ent_b__Brn__Phone_2")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Phone 2");

                    b.Property<long?>("m_ent_b__Brn__Unique_Code")
                        .HasColumnType("bigint");

                    b.Property<int?>("m_ent_b__Brn__Upd_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Brn__Upd_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("m_ent_b__Brn__Website")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Brn __ Website");

                    b.HasKey("m_ent_b__Brn__Brn_Id")
                        .HasName("PK__m_ent_b___F6F709A670134583");

                    b.HasIndex("m_ent_b__Brn__Div_Id");

                    b.ToTable("m_ent_b__Brn", "dbo");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Cst", b =>
                {
                    b.Property<int>("m_ent_b__Cst__Cst_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Cst __ Customer Number");

                    b.Property<string>("m_ent_b__Cst__Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Cst __ Arabic Name");

                    b.Property<int>("m_ent_b__Cst__Crt_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("m_ent_b__Cst__Crt_Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('01-01-1900')");

                    b.Property<int?>("m_ent_b__Cst__Dlt_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Cst__Dlt_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("m_ent_b__Cst__En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Cst __ English Name");

                    b.Property<bool>("m_ent_b__Cst__Is_Act")
                        .HasColumnType("bit");

                    b.Property<bool>("m_ent_b__Cst__Is_Dlt")
                        .HasColumnType("bit");

                    b.Property<bool?>("m_ent_b__Cst__Is_Sys")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("m_ent_b__Cst__Notes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Cst __ Note");

                    b.Property<long?>("m_ent_b__Cst__Unique_Code")
                        .HasColumnType("bigint");

                    b.Property<int?>("m_ent_b__Cst__Upd_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Cst__Upd_Date")
                        .HasColumnType("datetime");

                    b.HasKey("m_ent_b__Cst__Cst_Id")
                        .HasName("PK__m_ent_b___17D481677B8283C8");

                    b.ToTable("m_ent_b__Cst", "dbo", t =>
                        {
                            t.HasTrigger("insertCustomer");

                            t.HasTrigger("updateCustomer");
                        });
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__DB", b =>
                {
                    b.Property<int>("m_ent_b__DBs__DB_Id")
                        .HasColumnType("int")
                        .HasComment("m_rpt_b__DBs __ Database Number");

                    b.Property<string>("m_ent_b__DBs__Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_rpt_b__DBs __ Arabic Name");

                    b.Property<int>("m_ent_b__DBs__Crt_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("m_ent_b__DBs__Crt_Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('01-01-1900')");

                    b.Property<int?>("m_ent_b__DBs__Dlt_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__DBs__Dlt_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("m_ent_b__DBs__En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_rpt_b__DBs __ English Name");

                    b.Property<bool>("m_ent_b__DBs__Is_Act")
                        .HasColumnType("bit");

                    b.Property<bool>("m_ent_b__DBs__Is_Dlt")
                        .HasColumnType("bit");

                    b.Property<bool?>("m_ent_b__DBs__Is_Sys")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("m_ent_b__DBs__Notes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValueSql("('')");

                    b.Property<DateTime?>("m_ent_b__DBs__Upd_Date")
                        .HasColumnType("datetime");

                    b.Property<int?>("m_rpt_b__DBs__Upd_By")
                        .HasColumnType("int");

                    b.HasKey("m_ent_b__DBs__DB_Id")
                        .HasName("PK__m_ent_b___402C1B8A66E22938");

                    b.ToTable("m_ent_b__DBs", "dbo");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Div", b =>
                {
                    b.Property<int>("m_ent_b__Div__Div_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Div __ Division Number");

                    b.Property<string>("m_ent_b__Div__Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Div __ Arabic Name");

                    b.Property<int>("m_ent_b__Div__Crt_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("m_ent_b__Div__Crt_Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('01-01-1900')");

                    b.Property<int>("m_ent_b__Div__Cst_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Div __ Customer Number");

                    b.Property<DateTime?>("m_ent_b__Div__Dld_Date")
                        .HasColumnType("datetime");

                    b.Property<int?>("m_ent_b__Div__Dlt_By")
                        .HasColumnType("int");

                    b.Property<string>("m_ent_b__Div__En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Div __ English Name");

                    b.Property<int>("m_ent_b__Div__Ent_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Div __ Enterprise Number");

                    b.Property<bool>("m_ent_b__Div__Is_Act")
                        .HasColumnType("bit");

                    b.Property<bool>("m_ent_b__Div__Is_Dlt")
                        .HasColumnType("bit");

                    b.Property<bool?>("m_ent_b__Div__Is_Sys")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("m_ent_b__Div__Notes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Div __ Note");

                    b.Property<long?>("m_ent_b__Div__Unique_Code")
                        .HasColumnType("bigint");

                    b.Property<int?>("m_ent_b__Div__Upd_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Div__Upd_Date")
                        .HasColumnType("datetime");

                    b.HasKey("m_ent_b__Div__Div_Id")
                        .HasName("PK__m_ent_b___03C61D2E83012BA1");

                    b.HasIndex("m_ent_b__Div__Ent_Id");

                    b.ToTable("m_ent_b__Div", "dbo");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Ent", b =>
                {
                    b.Property<int>("m_ent_b__Ent__Ent_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Ent __ Enterprise Number");

                    b.Property<string>("m_ent_b__Ent__Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Ent __ Arabic Name");

                    b.Property<int>("m_ent_b__Ent__Crt_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("m_ent_b__Ent__Crt_Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('01-01-1900')");

                    b.Property<int?>("m_ent_b__Ent__Cst_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Ent __ Customer Number");

                    b.Property<DateTime?>("m_ent_b__Ent__Dld_Date")
                        .HasColumnType("datetime");

                    b.Property<int?>("m_ent_b__Ent__Dlt_By")
                        .HasColumnType("int");

                    b.Property<string>("m_ent_b__Ent__En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Ent __ English Name");

                    b.Property<bool>("m_ent_b__Ent__Is_Act")
                        .HasColumnType("bit");

                    b.Property<bool>("m_ent_b__Ent__Is_Dlt")
                        .HasColumnType("bit");

                    b.Property<bool?>("m_ent_b__Ent__Is_Sys")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("m_ent_b__Ent__Notes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Ent __ Note");

                    b.Property<long?>("m_ent_b__Ent__Unique_Code")
                        .HasColumnType("bigint");

                    b.Property<int?>("m_ent_b__Ent__Upd_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Ent__Upd_Date")
                        .HasColumnType("datetime");

                    b.HasKey("m_ent_b__Ent__Ent_Id")
                        .HasName("PK__m_ent_b___43E36D27B4A4F0B0");

                    b.HasIndex("m_ent_b__Ent__Cst_Id");

                    b.ToTable("m_ent_b__Ent", "dbo");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Fld", b =>
                {
                    b.Property<int>("m_ent_b__Flds__Fld_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Flds __ Filed Number");

                    b.Property<string>("m_ent_b__Flds__Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Flds __ Arabic Name");

                    b.Property<int>("m_ent_b__Flds__Crt_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("m_ent_b__Flds__Crt_Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('01-01-1900')");

                    b.Property<int>("m_ent_b__Flds__DBs_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Flds __ Database Number");

                    b.Property<string>("m_ent_b__Flds__Default")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Flds __ Filed type");

                    b.Property<int?>("m_ent_b__Flds__Dlt_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Flds__Dlt_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("m_ent_b__Flds__En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Flds __ English Name");

                    b.Property<bool>("m_ent_b__Flds__Is_Act")
                        .HasColumnType("bit");

                    b.Property<bool>("m_ent_b__Flds__Is_Dlt")
                        .HasColumnType("bit");

                    b.Property<bool?>("m_ent_b__Flds__Is_Sys")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("m_ent_b__Flds__Length")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Flds __ Filed Length");

                    b.Property<string>("m_ent_b__Flds__Mandatory")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Flds __ Is filed mandatory");

                    b.Property<string>("m_ent_b__Flds__Notes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("m_ent_b__Flds__Rpt_Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Flds __ Filed Arabic name to be used for reports");

                    b.Property<string>("m_ent_b__Flds__Rpt_En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Flds __ Filed English name to be used for reports");

                    b.Property<string>("m_ent_b__Flds__SQL_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Flds __ Filed name in database");

                    b.Property<int>("m_ent_b__Flds__Tbl_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Flds __ Table Number");

                    b.Property<int?>("m_ent_b__Flds__Upd_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Flds__Upd_Date")
                        .HasColumnType("datetime");

                    b.HasKey("m_ent_b__Flds__Fld_Id")
                        .HasName("PK__m_ent_b___3E0FDCAF4A92AE73");

                    b.HasIndex("m_ent_b__Flds__Tbl_Id");

                    b.ToTable("m_ent_b__Flds", "dbo");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Tbl", b =>
                {
                    b.Property<int>("m_ent_b__Tbls__Tbl_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Tbls __ Table Number");

                    b.Property<string>("m_ent_b__Tbls__Ar_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Tbls __ Arabic Name");

                    b.Property<int>("m_ent_b__Tbls__Crt_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("m_ent_b__Tbls__Crt_Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('01-01-1900')");

                    b.Property<int>("m_ent_b__Tbls__DBs_Id")
                        .HasColumnType("int")
                        .HasComment("m_ent_b__Tbls __ Database Number");

                    b.Property<int?>("m_ent_b__Tbls__Dlt_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Tbls__Dlt_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("m_ent_b__Tbls__En_Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasComment("m_ent_b__Tbls __ English Name");

                    b.Property<bool>("m_ent_b__Tbls__Is_Act")
                        .HasColumnType("bit");

                    b.Property<bool>("m_ent_b__Tbls__Is_Dlt")
                        .HasColumnType("bit");

                    b.Property<bool?>("m_ent_b__Tbls__Is_Sys")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("m_ent_b__Tbls__Notes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValueSql("('')");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_01")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_02")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_03")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_04")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_05")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_06")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_07")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_08")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_09")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Rpt_10")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_01")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_02")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_03")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_04")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_05")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_06")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_07")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_08")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_09")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("m_ent_b__Tbls__Scr_10")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("m_ent_b__Tbls__Upd_By")
                        .HasColumnType("int");

                    b.Property<DateTime?>("m_ent_b__Tbls__Upd_Date")
                        .HasColumnType("datetime");

                    b.HasKey("m_ent_b__Tbls__Tbl_Id")
                        .HasName("PK__m_ent_b___D9BA7CD6AA77DB37");

                    b.HasIndex("m_ent_b__Tbls__DBs_Id");

                    b.ToTable("m_ent_b__Tbls", "dbo");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Brn", b =>
                {
                    b.HasOne("MyBusinessAPI.Models.m_ent_b__Div", "m_ent_b__Brn__Div")
                        .WithMany("m_ent_b__Brns")
                        .HasForeignKey("m_ent_b__Brn__Div_Id")
                        .IsRequired()
                        .HasConstraintName("FK_Div_Brn");

                    b.Navigation("m_ent_b__Brn__Div");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Div", b =>
                {
                    b.HasOne("MyBusinessAPI.Models.m_ent_b__Ent", "m_ent_b__Div__Ent")
                        .WithMany("m_ent_b__Divs")
                        .HasForeignKey("m_ent_b__Div__Ent_Id")
                        .IsRequired()
                        .HasConstraintName("FK_Ent_Div");

                    b.Navigation("m_ent_b__Div__Ent");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Ent", b =>
                {
                    b.HasOne("MyBusinessAPI.Models.m_ent_b__Cst", "m_ent_b__Ent__Cst")
                        .WithMany("m_ent_b__Ents")
                        .HasForeignKey("m_ent_b__Ent__Cst_Id")
                        .HasConstraintName("FK_Cst_Ent");

                    b.Navigation("m_ent_b__Ent__Cst");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Fld", b =>
                {
                    b.HasOne("MyBusinessAPI.Models.m_ent_b__Tbl", "m_ent_b__Flds__Tbl")
                        .WithMany("m_ent_b__Flds")
                        .HasForeignKey("m_ent_b__Flds__Tbl_Id")
                        .IsRequired()
                        .HasConstraintName("FK_Tbl_Fld");

                    b.Navigation("m_ent_b__Flds__Tbl");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Tbl", b =>
                {
                    b.HasOne("MyBusinessAPI.Models.m_ent_b__DB", "m_ent_b__Tbls__DBs")
                        .WithMany("m_ent_b__Tbls")
                        .HasForeignKey("m_ent_b__Tbls__DBs_Id")
                        .IsRequired()
                        .HasConstraintName("FK_DBs_Tbl");

                    b.Navigation("m_ent_b__Tbls__DBs");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Cst", b =>
                {
                    b.Navigation("m_ent_b__Ents");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__DB", b =>
                {
                    b.Navigation("m_ent_b__Tbls");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Div", b =>
                {
                    b.Navigation("m_ent_b__Brns");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Ent", b =>
                {
                    b.Navigation("m_ent_b__Divs");
                });

            modelBuilder.Entity("MyBusinessAPI.Models.m_ent_b__Tbl", b =>
                {
                    b.Navigation("m_ent_b__Flds");
                });
#pragma warning restore 612, 618
        }
    }
}
