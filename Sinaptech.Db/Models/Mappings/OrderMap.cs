using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models.Mappings
{
   public class OrderMap : EntityTypeConfiguration<Order>
    {
       public OrderMap()
       {
           HasKey(d => d.OrderId);
           Property(d => d.OrderDateTime).IsRequired();
            Property(d => d.Gateway).HasMaxLength(100).IsOptional().HasColumnType("nvarchar");
           Property(d => d.Status).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
           Property(d => d.IsPaid).IsRequired();
            Property(d => d.TotalPrice).IsRequired();

           HasMany(order => order.OrderDetails).WithRequired(orderdetail => orderdetail.Order);
       }
    }
}
