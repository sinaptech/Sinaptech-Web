using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
    public class TestPackagePriceMap : EntityTypeConfiguration<TestPackagePrice>
    {
        public TestPackagePriceMap()
        {
            HasKey(d => d.TestPackagePriceId);
            Property(d => d.Price).IsRequired();
            Property(d => d.PriceAfterDiscount).IsOptional();
            Property(d => d.FromDateTime).IsRequired();
          
            HasRequired(testpackageprice => testpackageprice.TestPackage).WithMany(testpackage => testpackage.TestPackagePrices);
           

        }

    }
}
