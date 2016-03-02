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
        public int PriceAfterDiscount { get; set; }

        public DateTime FromDateTime { get; set; }

        [ForeignKey("TestPackage")]
        public int TestPackageId { get; set; }

        public virtual TestPackage TestPackage { get; set; }
    }
}
