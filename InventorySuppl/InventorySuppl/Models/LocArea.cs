using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class LocArea
    {
        public Int16 ID { get; set; }
        public string AreaName { get; set; }
        public List<LocUnit> LocUnits { get; set; }
    }

    public class LocAreaMap: EntityTypeConfiguration<LocArea>
    {
        public LocAreaMap()
        {
            Property(p => p.AreaName).HasMaxLength(3);
        }
    }

}