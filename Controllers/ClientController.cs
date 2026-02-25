using Microsoft.AspNetCore.Mvc;

namespace SteadyFast.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
