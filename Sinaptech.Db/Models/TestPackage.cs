using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class TestPackage
    {
       public int TestPackageId { get; set; }
       public string NameSci { get; set; }
       public string NameGen { get; set; }
       public string Description { get; set; }

        // Ye TestPackagePrice hatman bayad TestPackage dashte bashe va faghatm yedune dashtebashe va ye TestPackage mitune Price nadashte bashe ya yedune dashte bashe
        public virtual TestPackagePrice TestPackagePrice { get; set; }

        //ye TestPackage mitune n ta LabTest dashte bashe va ye LabTest mitune ozve n ta TestPackage bashe
       public virtual ICollection<LabTest> LabTests { get; set; }

        public virtual ICollection<OrderDetail> OrderDetailses { get; set; }
    }
}
