﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMyFreeBabyShop.Models;

namespace WebMyFreeBabyShop.Controllers
{
    public class CategoryEntitiesController : Controller
    {
        private DataModel db = new DataModel();

        // GET: CategoryEntities
        public ActionResult Index()
        {
            return View(db.CategoryEntity.ToList());
        }

        // GET: CategoryEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryEntity categoryEntity = db.CategoryEntity.Find(id);
            if (categoryEntity == null)
            {
                return HttpNotFound();
            }
            return View(categoryEntity);
        }

        // GET: CategoryEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryEntities/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCategory,categoryName")] CategoryEntity categoryEntity)
        {
            if (ModelState.IsValid)
            {
                db.CategoryEntity.Add(categoryEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryEntity);
        }

        // GET: CategoryEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryEntity categoryEntity = db.CategoryEntity.Find(id);
            if (categoryEntity == null)
            {
                return HttpNotFound();
            }
            return View(categoryEntity);
        }

        // POST: CategoryEntities/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCategory,categoryName")] CategoryEntity categoryEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryEntity);
        }

        // GET: CategoryEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryEntity categoryEntity = db.CategoryEntity.Find(id);
            if (categoryEntity == null)
            {
                return HttpNotFound();
            }
            return View(categoryEntity);
        }

        // POST: CategoryEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoryEntity categoryEntity = db.CategoryEntity.Find(id);
            db.CategoryEntity.Remove(categoryEntity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
