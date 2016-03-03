using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class Disease
    {
        public int DiseaseId { get; set; }
        public string NameSci { get; set; }
        public string NameGen { get; set; }
        public string Description { get; set; }

     //   public virtual ICollection<LabTest> LabTests { get; set; }
    }
}
