using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}