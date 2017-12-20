using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class typeOfItems
    {
        public Int16 ID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }

    public class typeOfItemsMap: EntityTypeConfiguration<typeOfItems>
    {
        public typeOfItemsMap()
        {
            Property(p => p.Name).HasMaxLength(15);
        }
    }
}