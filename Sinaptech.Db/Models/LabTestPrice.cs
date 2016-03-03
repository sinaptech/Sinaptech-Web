using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class LabTestPrice
    {
        [Key]
        public int LabTestPriceId { get; set; }
        public int Price { get; set; }
        public int PriceAfterDiscount { get; set; }

        public DateTime FromDateTime { get; set; }

      
       public virtual LabTest LabTest { get; set; }

    }
}
