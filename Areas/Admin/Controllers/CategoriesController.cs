using Ecommerce_MVC__11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_MVC__11.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        Db_ContextFolder.Db_ContextApplication context = new Db_ContextFolder.Db_ContextApplication();

        [Area("Admin")]
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();

            return View(categories);
        }

        [Area("Admin")]

        public IActionResult Delete(int id)
        {

            var x = context.Categories.FirstOrDefault(x => x.Id == id);
            if (x != null ) {
              
                    context.Categories.Remove(x);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                
                        
                        
                        }
            return RedirectToAction("Index");


        }

        [Area("Admin")]

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [Area("Admin")]

        [HttpPost]
        public IActionResult Create(Category model)
        {
          
                if (ModelState.IsValid)
            {
              
                    context.Categories.Add(model);
                    context.SaveChanges();
                    return RedirectToAction("Index");

                
            }

            return View(model);
        }



    }
}
