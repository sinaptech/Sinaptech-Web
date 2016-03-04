using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
   public class DiseaseMap:EntityTypeConfiguration<Disease>
    {
       public DiseaseMap()
       {
           HasKey(d => d.DiseaseId);
           Property(d => d.NameGen).HasMaxLength(100).IsRequired().HasColumnType("nvarchar");
            Property(d => d.NameSci).HasMaxLength(100).IsOptional().HasColumnType("nvarchar");
           Property(d => d.Description).IsOptional().IsMaxLength();

           HasMany(disease => disease.LabTests).WithMany(labtest => labtest.Diseases);
       }
    }
}
