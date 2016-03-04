using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
    public class TestPackageMap : EntityTypeConfiguration<TestPackage>
    {
        public TestPackageMap()
        {
            HasKey(d => d.TestPackageId);
            Property(d => d.NameGen).HasMaxLength(100).IsRequired().HasColumnType("nvarchar");
            Property(d => d.NameSci).HasMaxLength(100).IsOptional().HasColumnType("nvarchar");
            Property(d => d.Description).IsOptional().IsMaxLength();
            Property(d => d.CurrentPrice).IsOptional();
            Property(d => d.CurrentPriceAfterDiscount).IsOptional();

            HasMany(testpackage => testpackage.LabTests).WithMany(labtest => labtest.TestPackages);
           
            HasMany(testpackage => testpackage.TestPackagePrices).WithRequired(testpackageprice => testpackageprice.TestPackage);

        }

    }
}
