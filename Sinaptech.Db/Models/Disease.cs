using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class Disease
    {
        //See Mapping/DiseaseMap.cs
        public int DiseaseId { get; set; }
        public string NameSci { get; set; }
        public string NameGen { get; set; }
        public string Description { get; set; }

        //ye Disease mitune hichi ya n ta LabTest dashte bashe va ye LabTest ham mitune be hichi ya n ta Disease mortabet bashe
        public virtual ICollection<LabTest> LabTests { get; set; }

        public virtual string CreatorId { get; set; }

    }
}
