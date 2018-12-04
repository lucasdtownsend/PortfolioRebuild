using PortfolioRebuild.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioRebuild.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var db = new ProjectContext();
            var model = db.Projects;

            return View(model);
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