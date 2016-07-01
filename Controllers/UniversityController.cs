using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityData.Models;

namespace UniversityData.Controllers
{
    public class UniversityController : Controller
    {
        UniversityDataContext _dataContext = new UniversityDataContext();
        //
        // GET: /University/
        public ActionResult Index()
        {
            var universities = from u in _dataContext.Universities
                           select u;
            return View(universities.ToList());
        }

        //
        // GET: /University/Details/5
        public ActionResult Details(string id)
        {
            var university = _dataContext.Universities.FirstOrDefault(u => u.Id.Equals(id));
            return university == null ? View("404") : View(university);
        }

        //
        // GET: /University/Create
        public ActionResult Create()
        {
            var university = new University {};
            return View(university);
        }

        //
        // POST: /University/Create
        [HttpPost]
        public ActionResult Create(University university)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dataContext.Universities.Add(university);
                    _dataContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /University/Edit/5
        public ActionResult Edit(string id)
        {
            var university = _dataContext.Universities.FirstOrDefault(u => u.Id.Equals(id));
            return university == null ? View("404") : View(university);
        }

        //
        // POST: /University/Edit/5
        [HttpPost]
        public ActionResult Edit(University university)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dataContext.Universities.Add(university);
                    _dataContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /University/Delete/5
        public ActionResult Delete(string id)
        {
            var university = _dataContext.Universities.FirstOrDefault(u => u.Id.Equals(id));
            return university == null ? View("404") : View(university);
        }

        //
        // POST: /University/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                var university = _dataContext.Universities.FirstOrDefault(u => u.Id.Equals(id));
                if (university != null)
                {
                    _dataContext.DeleteObject(university);
                    _dataContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
