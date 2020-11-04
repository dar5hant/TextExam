using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Promotion
    {
        public int PromoId { get; set; }
        public Dictionary<string, int> ItemInfo { get; set; }
        public decimal PromoPrice { get; set; }

        public Promotion(int promID, Dictionary<string, int> itemInfo, decimal promoPrice)
        {
            this.PromoId = promID;
            this.ItemInfo = itemInfo;
            this.PromoPrice = promoPrice;
        }
    }
}
