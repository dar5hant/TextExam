using InterfaceProj;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationProj
{
    public class PromoCalculator: IPromoCalculator
    {
        public  decimal GetPromByOrders(Orders objOrder, Promotion promApply)
        {
            try
            {
                var Name = promApply.ItemInfo.Select(x => x.Key).FirstOrDefault();
                decimal d = 0M;
                var copp = objOrder.Products
                    .GroupBy(x => x.Id)
                    .Where(grp => promApply.ItemInfo.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                    .Select(grp => grp.Count())
                    .Sum();
                if (copp == 0)
                {
                    copp = objOrder.Products.FindAll(x => x.Id == Name).Count;
                }

                int ppc = promApply.ItemInfo.Sum(kvp => kvp.Value);
                while (copp >= ppc)
                {
                    d += promApply.PromoPrice;
                    copp -= ppc;
                }
                d += copp * GetItemPriceByName(Name);

                return d;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        
        /// <summary>
        /// Get Item price By Name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static decimal GetItemPriceByName(string name)
        {
            if (name == "A")
            {
                return 50;
            }
            else if (name == "B")
            {
                return 30;
            }
            else if (name == "C")
            {
                return 20;
            }
            else if (name == "D")
            {
                return 15;
            }
            else
            {
                return 0;
            }
        } 
    }
}
