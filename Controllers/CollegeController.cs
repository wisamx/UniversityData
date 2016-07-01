using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityData.Models;

namespace UniversityData.Controllers
{
    public class CollegeController : Controller
    {
        UniversityDataContext _dataContext = new UniversityDataContext();

        //
        // GET: /College/
        public ActionResult Index()
        {
            var colleges = from c in _dataContext.Colleges
                           select c;
            return View(colleges.ToList());
        }

        //
        // GET: /College/Details/5
        public ActionResult Details(string id)
        {
            var college = _dataContext.Colleges.FirstOrDefault(c => c.Id.Equals(id));
            return college == null ? View("404") : View(college);
        }

        //
        // GET: /College/Create
        public ActionResult Create()
        {
            ViewBag.UniversitiesList = new SelectList(_dataContext.Universities.OrderBy(u => u.Title).ToList(), "Id", "Title");
            return View();
        }

        //
        // POST: /College/Create
        [HttpPost]
        public ActionResult Create(College college, FormCollection formData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    college.University = _dataContext.Universities.FirstOrDefault(u => u.Id == formData["UniversityId"]);
                    
                    _dataContext.Colleges.Add(college);
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
        // GET: /College/Edit/5
        public ActionResult Edit(string id)
        {
            var college = _dataContext.Colleges.FirstOrDefault(c => c.Id.Equals(id));
            return college == null ? View("404") : View(college);
        }

        //
        // POST: /College/Edit/5
        [HttpPost]
        public ActionResult Edit(College college)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dataContext.Colleges.Add(college);
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
        // GET: /College/Delete/5
        public ActionResult Delete(string id)
        {
            var college = _dataContext.Colleges.FirstOrDefault(c => c.Id.Equals(id));
            return college == null ? View("404") : View(college);
        }

        //
        // POST: /College/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                var college = _dataContext.Colleges.FirstOrDefault(c => c.Id.Equals(id));
                if (college != null)
                {
                    _dataContext.DeleteObject(college);
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