using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestExam.Class
{
    public class CommonMethods
    {
        public static List<Promotion> GetPromotionList()
        {
            Dictionary<String, int> prom1 = new Dictionary<String, int>();
            prom1.Add("A", 3);
            Dictionary<String, int> prom2 = new Dictionary<String, int>();
            prom2.Add("B", 2);
            Dictionary<String, int> prom3 = new Dictionary<String, int>();
            prom3.Add("C", 1);
            prom3.Add("D", 1);

            List<Promotion> promotions = new List<Promotion>() { new Promotion(1, prom1, 130), new Promotion(2, prom2, 45), new Promotion(3, prom3, 30) };
            return promotions;
        }
    }
}