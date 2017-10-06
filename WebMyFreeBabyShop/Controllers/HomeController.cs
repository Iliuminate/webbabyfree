using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMyFreeBabyShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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


        public ActionResult Search()
        {
            return View();
        }


        //------------------------------------------------------------------------------------
        //---------- CREAR ELEMENTOS ---------------------------------------------------------

        public PartialViewResult _parcialView()
        {
            return PartialView();
        }


        //------------------------------------------------------------------------------------
        //---------- CREAR ELEMENTOS ---------------------------------------------------------

        [HttpPost]
        public ActionResult NewSubcategory(Models.Subcategory subcategory)
        {
            try
            {
                using (var dataModel = new Models.DataModel())
                {
                    var result = dataModel.Subcategory.Add(subcategory);
                    var action = dataModel.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }



        //------------------------------------------------------------------------------------
        //---------- LISTAS ------------------------------------------------------------------

        public ActionResult ListSubcategoryView()
        {
            List<Models.Subcategory> subcategory = new List<Models.Subcategory>();
            using (var dataModel = new Models.DataModel())
            {                
                subcategory = dataModel.Subcategory.ToList();                
            }

            return View(subcategory);
        }

        public ActionResult ListCategoryView()
        {
            List<Models.CategoryEntity> category = new List<Models.CategoryEntity>();
            using (var dataModel = new Models.DataModel())
            {
                category = dataModel.CategoryEntity.ToList();
            }

            return View(category);
        }

        public ActionResult ListItemsBabyView()
        {
            List<Models.ItemBabyEntity> itemsbaby = new List<Models.ItemBabyEntity>();
            using (var dataModel = new Models.DataModel())
            {
                itemsbaby = dataModel.ItemBabyEntity.ToList();
            }

            return View(itemsbaby);
        }

        //------------------------------------------------------------------------------------
        //---------- LISTAS ------------------------------------------------------------------
    }
}