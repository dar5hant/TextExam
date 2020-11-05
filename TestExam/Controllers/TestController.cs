using ImplementationProj;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TestExam.Class;
 

namespace TestExam.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string values)
        {
            try
            {
                List<OrderDetails> objOrdDetail = new JavaScriptSerializer().Deserialize<List<OrderDetails>>(values);
                Orders objOrder = new Orders(1, GetItemByQty(objOrdDetail));
                PromoCalculator objPromoCal = new PromoCalculator();

                List<decimal> promoprices = CommonMethods.GetPromotionList()
                     .Select(promo => objPromoCal.GetPromByOrders(objOrder, promo))
                     .ToList();

                decimal priceAfterPromotion = promoprices.Sum();

                ViewBag.Total = priceAfterPromotion;
            }
            catch (Exception ex)
            {
                ViewBag.Total = "Something went wrong! Please check you have entred correct values. ";
            }
            return View();
        }

        private List<Items> GetItemByQty(List<OrderDetails> objOrdDetail)
        {
            List<Items> objItemDetails = new List<Items>();
            for (int i = 0; i < objOrdDetail.Count; i++)
            {
                for (int j = 0; j < objOrdDetail[i].Qty; j++)
                {
                    objItemDetails.Add(new Items() { Id = objOrdDetail[i].Item });
                }
            }
            return objItemDetails;
        }
    }
}