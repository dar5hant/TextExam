using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProj
{
    public interface IPromoCalculator
    {
        decimal GetPromByOrders(Orders objOrder, Promotion promApply);
    }
}
