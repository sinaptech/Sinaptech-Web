namespace Sinaptech.Db.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sinaptech.Db.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Sinaptech.Db.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            #region Add Default Test Category

            var defaultTestCategory = new TestCategory() {
                // Moghe add kardane ye entity(record) Id nabayad vared beshe. asan record ezafe nemishe injoori.
                //TestCategoryId = 1,
                CategoryName = "عمومی"
            };
            context.TestCategories.AddOrUpdate(defaultTestCategory);

            //In method faghat ba dastoore update-database az tooye console package manager ejra mishe;
            //Save Changes ro baraye Method e Seed ehtiaj nist. 
            //context.SaveChanges(); 

            #endregion
        }
    }
}
