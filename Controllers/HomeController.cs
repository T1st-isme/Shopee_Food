using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopee_Food.Models;

namespace Shopee_Food.Controllers
{
    public class HomeController : Controller
    {
        DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        public ActionResult Index()
        {
            var getShop = db.Shops.ToList();
            ViewBag.ShopSize = getShop.Count();
            //ViewBag.Shop = getShop;
            Console.WriteLine(getShop.Count());
            return View(getShop);
        }

        public ActionResult DetailShop()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}