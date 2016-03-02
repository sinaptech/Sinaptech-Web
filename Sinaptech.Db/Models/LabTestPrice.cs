using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class LabTestPrice
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int PriceAfterDiscount { get; set; }

        public DateTime FromDateTime { get; set; }

        [ForeignKey("LabTest")]
        public int LabTestId { get; set; }

        public virtual LabTest LabTest { get; set; }

    }
}
