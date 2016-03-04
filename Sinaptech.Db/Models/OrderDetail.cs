using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class OrderDetail
    {
       
       public int OrderDetailId { get; set; }
    
       public virtual Order Order { get; set; }
       public virtual TestPackage   TestPackage { get; set; }
       public virtual LabTest   LabTest { get; set; }
       public int Price { get; set; }



    }
}
