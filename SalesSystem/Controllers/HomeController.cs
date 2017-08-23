using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using SalesSystem.Models;
using Newtonsoft.Json;

namespace SalesSystem.Controllers
{
    public class HomeController : Controller
    {
        private SalesDBEntities saleEntitiesDB = new SalesDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public JsonResult AllSalesPersonDetails()
        {
            List<SP_GetAllSalesPersonDetails_Result> salesPersons = saleEntitiesDB.SP_GetAllSalesPersonDetails().ToList();
            return Json(salesPersons);
        }

        [HttpPost]
        public JsonResult SalesPersonCategories()
        {
            var categories = from categry in saleEntitiesDB.SalesPersonCategories
                             select new { categry.ID, categry.Description };
            return Json(categories);
        }

        [HttpPost]
        public JsonResult SalesPersonDetails(int id)
        {
            var details = from salesDetails in saleEntitiesDB.SP_GetAllSalesPersonDetails()
                          where salesDetails.ID == id
                          select salesDetails;
            return Json(details);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
