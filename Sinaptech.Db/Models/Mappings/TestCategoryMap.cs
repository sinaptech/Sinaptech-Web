using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
    public class TestCategoryMap : EntityTypeConfiguration<TestCategory>
    {
        public TestCategoryMap()
        {
            HasKey(d => d.TestCategoryId);
            Property(d => d.CategoryName).HasMaxLength(100).IsRequired().HasColumnType("nvarchar");
         
            Property(d => d.CategoryDescription).IsOptional().IsMaxLength();
        

            HasMany(testcategory => testcategory.LabTests).WithMany(labtest => labtest.TestCategories);
           

        }

    }
}
