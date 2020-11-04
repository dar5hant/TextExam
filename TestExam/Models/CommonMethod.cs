using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestExam.Models
{
    public static class CommonMethod
    {
        public static List<Promotion> GetPromoList()
        {
            Dictionary<String, int> promCal1 = new Dictionary<String, int>();
            promCal1.Add("A", 3);
            Dictionary<String, int> promCal2 = new Dictionary<String, int>();
            promCal2.Add("B", 2);
            Dictionary<String, int> promCal3 = new Dictionary<String, int>();
            promCal3.Add("C", 1);
            promCal3.Add("D", 1);

            List<Promotion> promotions = new List<Promotion>() { new Promotion(1, promCal1, 130), new Promotion(2, promCal2, 45), new Promotion(3, promCal3, 30) };
            return promotions;
        }
    }
}