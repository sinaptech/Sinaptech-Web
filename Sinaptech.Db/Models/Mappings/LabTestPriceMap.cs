using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
    public class LabTestPriceMap : EntityTypeConfiguration<LabTestPrice>
    {
        public LabTestPriceMap()
        {
            HasKey(d => d.LabTestPriceId);
            Property(d => d.Price).IsRequired();
            Property(d => d.PriceAfterDiscount).IsOptional();
            Property(d => d.FromDateTime).IsRequired();
          
            HasRequired(labtestprice => labtestprice.LabTest).WithMany(labtest => labtest.LabTestPrices);
           

        }

    }
}
