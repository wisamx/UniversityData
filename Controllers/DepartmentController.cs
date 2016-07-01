using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityData.Models;

namespace UniversityData.Controllers
{
    public class DepartmentController : Controller
    {
        UniversityDataContext _dataContext = new UniversityDataContext();

        //
        // GET: /Department/
        public ActionResult Index()
        {
            var departments = from d in _dataContext.Departments
                           select d;
            return View(departments.ToList());
        }

        //
        // GET: /Department/Details/5
        public ActionResult Details(string id)
        {
            var department = _dataContext.Departments.FirstOrDefault(d => d.Id.Equals(id));
            return department == null ? View("404") : View(department);
        }

        //
        // GET: /Department/Create
        public ActionResult Create()
        {
            ViewBag.CollegesList = new SelectList(_dataContext.Colleges.OrderBy(u => u.Title).ToList(), "Id", "Title");
            return View();
        }

        //
        // POST: /Department/Create
        [HttpPost]
        public ActionResult Create(Department department, FormCollection formData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    department.College = _dataContext.Colleges.FirstOrDefault(c => c.Id == formData["CollegeId"]);

                    _dataContext.Departments.Add(department);
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
        // GET: /Department/Edit/5
        public ActionResult Edit(string id)
        {
            var department = _dataContext.Departments.FirstOrDefault(d => d.Id.Equals(id));
            return department == null ? View("404") : View(department);
        }

        //
        // POST: /Department/Edit/5
        [HttpPost]
        public ActionResult Edit(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dataContext.Departments.Add(department);
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
        // GET: /Department/Delete/5
        public ActionResult Delete(string id)
        {
            var department = _dataContext.Departments.FirstOrDefault(d => d.Id.Equals(id));
            return department == null ? View("404") : View(department);
        }

        //
        // POST: /Department/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                var department = _dataContext.Departments.FirstOrDefault(d => d.Id.Equals(id));
                if (department != null)
                {
                    _dataContext.DeleteObject(department);
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