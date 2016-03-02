using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class LabTest
    {
        public int LabTestId { get; set; }
        public string NameSci { get; set; }
        public string NameGen { get; set; }
        public string TestDescription { get; set; }

        public virtual ICollection<TestCategory> TestCategories { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }
        public virtual LabTestPrice LabTestPrice { get; set; }



    }
}
