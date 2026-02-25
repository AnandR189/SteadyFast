using Microsoft.AspNetCore.Mvc;

namespace SteadyFast.Controllers
{
    public class MechanicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
