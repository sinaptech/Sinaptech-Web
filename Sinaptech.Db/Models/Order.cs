using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class Order
    {
        public int OrderID { get; set; }
        public virtual ApplicationUser Customer { get; set; }
        public DateTime Date { get; set; }
       public bool IsPaid { get; set; }
       public int TotalPrice { get; set; }
       public string Gateway { get; set; }
       public string Status { get; set; }
       public virtual OrderDetails OrderDetails { get; set; }
    }
}
