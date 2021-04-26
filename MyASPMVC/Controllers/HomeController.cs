using MyASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Mymodols thu1 = new Mymodols();
            Mymanaged thu2 = new Mymanaged();
            thu1.Name1 = "ten1";
            thu1.Phone = "1234";
            thu2.id = "ten2";
            thu2.ten = "ten 33";
            ViewBag.Message = "Your application description page.";

            return View(thu1);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}