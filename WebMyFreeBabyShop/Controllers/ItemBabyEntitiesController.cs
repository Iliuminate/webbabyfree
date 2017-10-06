using System;
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
    public class ItemBabyEntitiesController : Controller
    {
        private DataModel db = new DataModel();

        // GET: ItemBabyEntities
        public ActionResult Index()
        {
            var itemBabyEntity = db.ItemBabyEntity.Include(i => i.CategoryEntity).Include(i => i.Subcategory1);
            return View(itemBabyEntity.ToList());
        }

        // GET: ItemBabyEntities/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemBabyEntity itemBabyEntity = db.ItemBabyEntity.Find(id);
            if (itemBabyEntity == null)
            {
                return HttpNotFound();
            }
            return View(itemBabyEntity);
        }

        // GET: ItemBabyEntities/Create
        public ActionResult Create()
        {
            ViewBag.id = new SelectList(db.ItemBabyEntity, "id", "itemName");
            ViewBag.subcategory = new SelectList(db.Subcategory, "idSubcategory", "subcategory1");
            return View();
        }

        // POST: ItemBabyEntities/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,itemName,itemDescription,itemSerial,dateAdd,qualify,itemImage,category,subcategory")] ItemBabyEntity itemBabyEntity)
        {
            if (ModelState.IsValid)
            {
                db.ItemBabyEntity.Add(itemBabyEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id = new SelectList(db.ItemBabyEntity, "id", "itemName", itemBabyEntity.id);
            ViewBag.subcategory = new SelectList(db.Subcategory, "idSubcategory", "subcategory1", itemBabyEntity.subcategory);
            return View(itemBabyEntity);
        }

        // GET: ItemBabyEntities/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemBabyEntity itemBabyEntity = db.ItemBabyEntity.Find(id);
            if (itemBabyEntity == null)
            {
                return HttpNotFound();
            }
            ViewBag.id = new SelectList(db.ItemBabyEntity, "id", "itemName", itemBabyEntity.id);
            ViewBag.subcategory = new SelectList(db.Subcategory, "idSubcategory", "subcategory1", itemBabyEntity.subcategory);
            return View(itemBabyEntity);
        }

        // POST: ItemBabyEntities/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,itemName,itemDescription,itemSerial,dateAdd,qualify,itemImage,category,subcategory")] ItemBabyEntity itemBabyEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemBabyEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id = new SelectList(db.ItemBabyEntity, "id", "itemName", itemBabyEntity.id);
            ViewBag.subcategory = new SelectList(db.Subcategory, "idSubcategory", "subcategory1", itemBabyEntity.subcategory);
            return View(itemBabyEntity);
        }

        // GET: ItemBabyEntities/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemBabyEntity itemBabyEntity = db.ItemBabyEntity.Find(id);
            if (itemBabyEntity == null)
            {
                return HttpNotFound();
            }
            return View(itemBabyEntity);
        }

        // POST: ItemBabyEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ItemBabyEntity itemBabyEntity = db.ItemBabyEntity.Find(id);
            db.ItemBabyEntity.Remove(itemBabyEntity);
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
