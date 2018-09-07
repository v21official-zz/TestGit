using Pr_mini.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pr_mini.Controllers
{
    public class HomeController : Controller
    {
        Connection cnn = new Connection();

        public ActionResult Index()
        {
            List<Area> listArea = cnn.Area.ToList();
            ViewBag.listArea = listArea;
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