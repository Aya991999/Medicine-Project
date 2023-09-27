using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyBusinessAPI.Models;

public partial class admin_m_gen_b_devContext : DbContext
{
    public admin_m_gen_b_devContext()
    {
    }

    public admin_m_gen_b_devContext(DbContextOptions<admin_m_gen_b_devContext> options)
        : base(options)
    {
    }

    public virtual DbSet<m_gen_b__File_Path> m_gen_b__File_Paths { get; set; }

    public virtual DbSet<m_gen_b__Note> m_gen_b__Notes { get; set; }

    public virtual DbSet<m_gen_b__Unique_Code> m_gen_b__Unique_Codes { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=198.38.84.196;User ID=admin_m_mybusiness_b;Password=MB_Mocha!1;Database=admin_m_gen_b_dev;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("admin_m_mybusiness_b");

        modelBuilder.Entity<m_gen_b__File_Path>(entity =>
        {
            entity.HasKey(e => e.m_gen_b__File_Path__Id).HasName("PK__m_gen_b___B32F696C553D479C");

            entity.ToTable("m_gen_b__File_Path", "dbo");

            entity.Property(e => e.m_gen_b__File_Path__Path).HasMaxLength(200);
        });

        modelBuilder.Entity<m_gen_b__Note>(entity =>
        {
            entity.HasKey(e => e.m_gen_b__Notes__Id).HasName("PK__m_gen_b___6F60285C92F4B93E");

            entity.ToTable("m_gen_b__Notes", "dbo");

            entity.Property(e => e.m_gen_b__Notes__Note).HasMaxLength(200);
        });

        modelBuilder.Entity<m_gen_b__Unique_Code>(entity =>
        {
            entity.HasKey(e => e.m_gen_b__Unique_Code__Id).HasName("PK__m_gen_b___373056B38BE1DB48");

            entity.ToTable("m_gen_b__Unique_Code", "dbo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
