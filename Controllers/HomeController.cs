using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityData.Models;

namespace UniversityData.Controllers
{
    public class HomeController : Controller
    {
        UniversityDataContext _dataContext = new UniversityDataContext();

        public ActionResult Index()
        {
            ViewBag.myUniversitiesList = new SelectList(_dataContext.Universities.OrderBy(u => u.Title).ToList(), "Id", "Title");
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
        public ActionResult SPARQL()
        {
            return View();
        }

    }
}