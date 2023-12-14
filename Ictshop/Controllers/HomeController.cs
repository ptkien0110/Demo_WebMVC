using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class HomeController : Controller
    {
        Qlbanhang db = new Qlbanhang();
        public ActionResult Index()
        {
       
            return View();

        }

        public ActionResult Checkout()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }


    }
}