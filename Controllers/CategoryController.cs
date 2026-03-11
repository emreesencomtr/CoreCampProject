using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
