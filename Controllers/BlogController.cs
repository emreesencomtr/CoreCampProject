using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
