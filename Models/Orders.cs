using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public List<Items> Products { get; set; }

        public Orders(int _oid, List<Items> _prods)
        {
            this.OrderID = _oid;
            this.Products = _prods;
        }

    }
}
