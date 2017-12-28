using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Location
    {
        public virtual int ID { get; set; }
        public virtual int UnitID { get; set; }
        public virtual Int16 ShelfNomber { get; set; }
        public virtual List<Operation> Operations { get; set; }
        public virtual LocUnit LocUnit { get; set; }
    }
}