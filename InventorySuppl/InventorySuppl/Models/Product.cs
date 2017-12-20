using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string UID { get; set; }
        public float Quantity { get; set; }
        public List<Operation> Operations { get; set; }
    }
}