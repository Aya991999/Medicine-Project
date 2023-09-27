using DBMedicine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MVCFinalProject.Views;

namespace MVCFinalProject.Models
{
    public class Context:DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions options):base(options)
        {

        }
       

        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Second_Row> Second_Rows { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentMaterials> StudentMaterials { get; set; }
        public virtual DbSet<StudentSecondeRowMaterial> StudentSecondeRowMaterials { get; set; }
        public virtual DbSet<StudentSummerMaterial> StudentSummerMaterials { get; set; }
        public virtual DbSet<Summer> Summers { get; set; }
        public virtual DbSet<User> Users { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<StudentMaterials>().HasKey(p => new { p.Std_ID ,p.Matrial_Code });
            //modelBuilder.Entity<StudentMaterials>().HasIndex(p => new { p.Std_National_ID, p.Matrial_Code }).IsUnique();
            modelBuilder.Entity<StudentSummerMaterial>().HasIndex(p => new { p.Std_National_ID, p.Material_Code,p.Summer_ID }).IsUnique();
            modelBuilder.Entity<StudentSecondeRowMaterial>().HasIndex(p => new { p.Std_National_ID, p.Material_Code,p.Second_Row_ID }).IsUnique();

        }
    }
}
