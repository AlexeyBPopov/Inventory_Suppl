using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Manufacturer
    {
        public virtual Int16 ID { get; set; }
        public virtual string ManufacturerName { get; set; }
        public virtual string ABBR { get; set; }
        public virtual List<Product> Products { get; set; }

    }

    public class ManufacturerMap: EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerMap()
        {
            Property(p => p.ManufacturerName).HasMaxLength(100).IsRequired();
            Property(p => p.ABBR).HasMaxLength(8);
        }

    }
}