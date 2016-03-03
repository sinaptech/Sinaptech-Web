using Microsoft.AspNet.Identity.EntityFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Sinaptech.Db.Models;
using Sinaptech.Db.Models.Mappings;

namespace Sinaptech.Db
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("SinaptechContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<TestCategory> TestCategories { get; set; }
        public DbSet<LabTest> LabTests { get; set; }
        public DbSet<LabTestPrice> LabTestPrices { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<TestPackage> TestPackages { get; set; }
        public DbSet<TestPackagePrice> TestPackagePrices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("Users");
            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
           // modelBuilder.Entity<LabTest>().HasMany(c => c.TestCategories).WithMany(i => i.LabTests).Map(t => t.MapLeftKey("LabtTestId").MapRightKey("TestCategoryId").ToTable("LabTestTestCategory"));
            modelBuilder.Entity<LabTest>().HasOptional(s => s.LabTestPrice).WithRequired(d => d.LabTest);


            #region Mappings

            modelBuilder.Configurations.Add(new DiseaseMap());

            #endregion
        }

        
    }
}
