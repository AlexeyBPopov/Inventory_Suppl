using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySuppl.Models
{
    public class TypeOfRight
    {
        public byte ID { get; set; }
        public string TypeName { get; set; }
        public List<UserP> UserPs { get; set; }
    }
}