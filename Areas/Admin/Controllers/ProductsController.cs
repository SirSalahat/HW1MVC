using Ecommerce_MVC__11.Models;
using Ecommerce_MVC__11.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_MVC__11.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductsController : Controller
    {

        Db_ContextFolder.Db_ContextApplication context = new Db_ContextFolder.Db_ContextApplication();

        public IActionResult Index()
        {
            var products = context.Products.ToList(); // Load products from DB
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product, IFormFile Image)
        {



            var imgservice = new imageService();
            string fileName=imgservice.UploadImage(Image);
            product.Image = fileName;
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {

            var x = context.Products.FirstOrDefault(x => x.Id == id);
            if (x != null)
            {
                var imgservice = new imageService();
                imgservice.DeleteImage(x.Image);
      
                context.Products.Remove(x);
                context.SaveChanges();



            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = context.Categories.ToList();

            var x = context.Products.FirstOrDefault(x => x.Id == id);
            return View(x);
        }
        [HttpPost]
        public IActionResult Edit(Product product, IFormFile Image)
        {



            var imgservice = new imageService();
            var fileName = imgservice.UploadImage(Image);
            product.Image = fileName;
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
