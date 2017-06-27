using MarieCurie.WebMvc.Repositories;
using MarieCurie.WebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarieCurie.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            List<MyHelperService> centers = repo.getCenters();
            return View(centers);
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