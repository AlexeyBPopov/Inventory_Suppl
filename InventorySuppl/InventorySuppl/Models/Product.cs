using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Product
    {
        public virtual int ID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string UID { get; set; }
        public virtual float Quantity { get; set; }
        public virtual Int16 TypeOfItemsID { get; set; }
        public virtual Int16 ManufacturerID { get; set; }
        public virtual typeOfItems TypeOfItems { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual List<Operation> Operations { get; set; }
    }
}