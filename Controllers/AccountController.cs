using Microsoft.AspNetCore.Mvc;
using SteadyFast.Data;
using SteadyFast.Models.Account;
using System.Linq;
    

namespace SteadyFast.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View();
        }


    }
}
