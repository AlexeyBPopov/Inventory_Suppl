using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class UserP
    {
        public virtual Int16 ID { get; set; }
        public virtual string Name { get; set; }
        public virtual byte TipeOfRightsId { get; set; }
        public virtual List<Operation> Operations { get; set; }
        public virtual TypeOfRight TypeOfRight { get; set; }
    }

    public class UserPMap: EntityTypeConfiguration<UserP>
    {
        public UserPMap()
        {
            Property(p => p.Name).HasMaxLength(100);
        }
    }
}