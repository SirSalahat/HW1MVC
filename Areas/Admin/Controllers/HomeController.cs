using Ecommerce_MVC__11.Db_ContextFolder;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_MVC__11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        Db_ContextApplication context = new Db_ContextApplication();
        public IActionResult Index()
        {
            return View();
        }
    }
}
