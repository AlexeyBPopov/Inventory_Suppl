using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class UserP
    {
        public Int16 ID { get; set; }
        public string Name { get; set; }
        public List<Operation> Operations { get; set; }
    }

    public class UserPMap: EntityTypeConfiguration<UserP>
    {
        public UserPMap()
        {
            Property(p => p.Name).HasMaxLength(100);
        }
    }
}