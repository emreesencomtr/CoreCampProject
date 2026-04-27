using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
