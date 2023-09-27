using System;
using System.Reflection;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Models.DBModels;
using Utilities;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
      => optionsBuilder.UseSqlServer(CommonUtility.SQLConnectionLogin);

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public static int _userId { get; set; }
        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in added)
            {
                setAddedValue(entity);
            }

            var modified = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Modified)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in modified)
            {
                setUpdatedValue(entity);
            }
            return base.SaveChanges();
        }
        public void setAddedValue(object entity)
        {
            PropertyInfo[] PropertyInfos = entity.GetType().GetProperties();
            foreach (PropertyInfo pInfo in PropertyInfos)
            {

                if (pInfo.Name == "CreatedDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "CreatedBy")
                    pInfo.SetValue(entity, _userId);//ToDo 
                else if (pInfo.Name == "UpdateDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "UpdatedBy")
                    pInfo.SetValue(entity, _userId);//ToDo 
                else if (pInfo.Name == "IsActive")
                    pInfo.SetValue(entity, true);//ToDo 
                else if (pInfo.Name == "IsDeleted")
                    pInfo.SetValue(entity, false);//ToDo 
                else if (pInfo.Name == "IsSystem")
                    pInfo.SetValue(entity, false);//ToDo 
           
            }
        }
        public void setUpdatedValue(object entity)
        {
            PropertyInfo[] PropertyInfos;
            PropertyInfos = entity.GetType().GetProperties();
            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "UpdateDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "UpdatedBy")
                    pInfo.SetValue(entity, _userId);
    

           
            }
        }
    }
}
