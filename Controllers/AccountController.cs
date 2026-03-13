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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                HttpContext.Session.SetString("UserRole", user.Role);
                HttpContext.Session.SetString("UserName", user.Name);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid Email or Password";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
        

    }
}
