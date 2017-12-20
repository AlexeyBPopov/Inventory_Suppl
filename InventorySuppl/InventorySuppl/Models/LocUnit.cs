using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class LocUnit
    {
        public int ID { get; set; }
        public int UnitNum { get; set; }
        public List<Location> Locations { get; set; }
    }
}