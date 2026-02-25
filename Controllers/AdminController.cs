using Microsoft.AspNetCore.Mvc;

namespace SteadyFast.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
