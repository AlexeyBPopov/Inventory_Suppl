using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Location
    {
        public int ID { get; set; }
        public Int16 ShelfNomber { get; set; }
        public List<Operation> Operations { get; set; }
    }
}