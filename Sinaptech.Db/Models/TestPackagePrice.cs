using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
    public class TestPackagePrice
    {
        public int TestPackagePriceId { get; set; }
        public int Price { get; set; }
        public int? PriceAfterDiscount { get; set; }

        public DateTime FromDateTime { get; set; }


// Ye TestPackagePrice hatman bayad TestPackage dashte bashe va faghatm yedune dashtebashe va ye TestPackage mitune Price nadashte bashe ya yedune dashte bashe
     
        public virtual TestPackage TestPackage { get; set; }
    }
}
