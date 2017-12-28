using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Vendor
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string UID { get; set; }
        public virtual List<Operation> Operations { get; set; }
    }

    public class VendorMap: EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            Property(p => p.UID).HasMaxLength(10);
        }
    }


}