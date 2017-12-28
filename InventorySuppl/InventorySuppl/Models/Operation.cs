using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Operation
    {
        public virtual Int64 ID { get; set; }
        public virtual byte Type { get; set; }
        public virtual int Qty { get; set; }
        public virtual DateTime OperDate { get; set; }
        public virtual string LOT { get; set; }
        public virtual DateTime ExpirtionDate { get; set; }
        public virtual int ProductID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual short UserID { get; set; }
        public virtual DateTime DateIn { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual UserP UserP { get; set; }
    }
}