using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// This Model will use for pass data from UI
    /// </summary>
    public class OrderDetails
    { 
        public string Item { get; set; }
        public int Qty { get; set; }
    }
}
