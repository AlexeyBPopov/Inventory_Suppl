using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Vendor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UID { get; set; }
        public List<Operation> Operations { get; set; }
    }

    public class VendorMap: EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            Property(p => p.UID).HasMaxLength(10);
        }
    }


}