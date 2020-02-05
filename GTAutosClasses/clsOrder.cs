using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsOrder
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string ServiceID { get; set; }
        public double OrderPrice { get; set; }
        public string OrderStatus { get; set; }
        public bool Completed { get; set; }
    }
}