using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopSmartPhone.Controllers
{
    public class ShopSmartPhoneController : Controller
    {
        // GET: ShopSmartPhone
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShopSmartPhone/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShopSmartPhone/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopSmartPhone/Create
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

        // GET: ShopSmartPhone/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopSmartPhone/Edit/5
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

        // GET: ShopSmartPhone/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopSmartPhone/Delete/5
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
