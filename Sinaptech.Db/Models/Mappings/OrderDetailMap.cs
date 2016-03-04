using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
   public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
       public OrderDetailMap()
       {
           HasKey(d => d.OrderDetailId);
           Property(d => d.Price).IsRequired();
          

            HasOptional(orderdetails => orderdetails.LabTest).WithMany(labtest => labtest.OrderDetailses);
            HasOptional(orderdetails => orderdetails.TestPackage).WithMany(testpackage => testpackage.OrderDetails);
           HasRequired(orderdetail => orderdetail.Order).WithMany(order => order.OrderDetails);
       }
    }
}
