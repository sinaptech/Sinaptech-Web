using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
    public class LabTestMap : EntityTypeConfiguration<LabTest>
    {
        public LabTestMap()
        {
            HasKey(d => d.LabTestId);
            Property(d => d.NameGen).HasMaxLength(100).IsRequired().HasColumnType("nvarchar");
            Property(d => d.NameSci).HasMaxLength(100).IsOptional().HasColumnType("nvarchar");
            Property(d => d.TestDescription).IsOptional().IsMaxLength();
            Property(d => d.CurrentPrice).IsOptional();
            Property(d => d.CurrentPriceAfterDiscount).IsOptional();

            HasMany(labtest => labtest.Diseases).WithMany(disease => disease.LabTests);
            HasMany(labtest => labtest.Diseases).WithMany(disease => disease.LabTests);
            HasMany(labtest => labtest.LabTestPrices).WithRequired(labtestprice => labtestprice.LabTest);

        }

    }
}
