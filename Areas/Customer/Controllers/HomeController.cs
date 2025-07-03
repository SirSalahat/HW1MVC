using Ecommerce_MVC__11.Db_ContextFolder;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_MVC__11.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        Db_ContextApplication context = new Db_ContextApplication();

        public IActionResult Index()
        {
            ViewBag.Categories = context.Categories.ToList();
            ViewBag.Products = context.Products.ToList();
            return View();
        }
    }
}
