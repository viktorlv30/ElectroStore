using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ElectroStore.Models;

namespace ElectroStore.Controllers
{
    public class HomeController : Controller
    {
        //create context of datas
        GoodContex db = new GoodContex();

        public ActionResult Index()
        {
            //get from DB all cabels
            IEnumerable<Cabel> cabels = db.Cabels;

            //pass all cabels to dynamic property ViewBag
            ViewBag.Cabels = cabels;
            
            //return View
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.GoodId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DatePurchase = DateTime.Now;
            //add info about purchase to DB
            db.Purchases.Add(purchase);
            //save all changes
            db.SaveChanges();
            return "Спасибо, " + purchase.Person + ", за покупку!";
        }
    }
}