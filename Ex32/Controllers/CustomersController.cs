﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ex32.Models;
using Ex32.DAL;

namespace Ex32.Controllers
{
    public class CustomersController : Controller
    {
        //private SampleDBEntities db = new SampleDBEntities();
        private ICustomerRepository respository;


        public CustomersController(ICustomerRepository repo)
        {
            respository = repo;
        }


        // GET: Customers
        public ActionResult Index()
        {
            return View(respository.GetCustomers());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View(respository.GetCustomerByID(id));

        }

        //// GET: Customers/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Customers/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customers customers)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Customers.Add(customers);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(customers);
        //}

        //// GET: Customers/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Customers customers = db.Customers.Find(id);
        //    if (customers == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customers);
        //}

        //// POST: Customers/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customers customers)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(customers).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(customers);
        //}

        //// GET: Customers/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Customers customers = db.Customers.Find(id);
        //    if (customers == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customers);
        //}

        //// POST: Customers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    Customers customers = db.Customers.Find(id);
        //    db.Customers.Remove(customers);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
