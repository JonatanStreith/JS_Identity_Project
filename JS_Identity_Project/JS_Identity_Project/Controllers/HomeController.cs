using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JS_Identity_Project.Models;


namespace JS_Identity_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //StaticData.AddData();


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