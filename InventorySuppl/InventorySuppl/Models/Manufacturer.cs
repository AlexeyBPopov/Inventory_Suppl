using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Manufacturer
    {
        public Int16 ID { get; set; }
        public string ManufacturerName { get; set; }
        public string ABBR { get; set; }
        public List<Product> Products { get; set; }

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