using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View(); // return a new file
        }

        public IActionResult Download()
        {
            return Content("this is a direct message"); 
        }
    }
}
