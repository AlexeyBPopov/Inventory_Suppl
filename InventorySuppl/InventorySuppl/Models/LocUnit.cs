using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class LocUnit
    {
        public virtual int ID { get; set; }
        public virtual short LocAreaId { get; set; }
        public virtual int UnitNum { get; set; }
        public virtual LocArea LocArea { get; set; }
        public virtual List<Location> Locations { get; set; }
    }
}