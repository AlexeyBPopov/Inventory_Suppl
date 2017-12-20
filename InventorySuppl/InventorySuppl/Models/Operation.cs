using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class Operation
    {
        public Int64 ID { get; set; }
        public byte Type { get; set; }
        public int Qty { get; set; }
        public DateTime OperDate { get; set; }
        public string LOT { get; set; }
        public DateTime ExpirtionDate { get; set; }
        public DateTime DateIn { get; set; }
    }
}