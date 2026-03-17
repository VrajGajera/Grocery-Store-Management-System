using Microsoft.AspNetCore.Mvc;
using Grosary_net.Models;
using Grosary_net.Data;

namespace Grosary_net.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // LOGIN
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            try
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    HttpContext.Session.SetString("UserId", user.Id.ToString());
                    HttpContext.Session.SetString("Username", user.Username);
                    HttpContext.Session.SetString("UserRole", user.Role.ToString());
                    HttpContext.Session.SetString("FullName", user.FullName);

                    if (user.Role == UserRole.Admin)
                        return RedirectToAction("Dashboard", "Admin");
                    else
                        return RedirectToAction("ProductList", "User");
                }

                ViewBag.Error = "Invalid username or password";
                return View("SignIn");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error: " + ex.Message;
                return View("SignIn");
            }
        }

        // REGISTER PAGE
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // REGISTER SAVE DATABASE
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Username check
                if (_context.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", "Username already exists");
                    return View(user);
                }

                // Email check
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already registered");
                    return View(user);
                }

                user.Role = UserRole.Customer;
                user.RegistrationDate = DateTime.Now;

                _context.Users.Add(user);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Registration successful! Please sign in.";

                return RedirectToAction("SignIn");
            }

            return View(user);
        }

        // ADMIN LOGIN PAGE
        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        // ADMIN LOGIN
        [HttpPost]
        public IActionResult AdminLogin(string username, string password)
        {
            if (username == "admin" && password == "Admin@123")
            {
                var admin = _context.Users.FirstOrDefault(u => u.Username == "admin");

                if (admin == null)
                {
                    admin = new User
                    {
                        Username = "admin",
                        Password = "Admin@123",
                        Email = "admin@grosary.com",
                        FullName = "System Admin",
                        Role = UserRole.Admin,
                        RegistrationDate = DateTime.Now
                    };

                    _context.Users.Add(admin);
                    _context.SaveChanges();
                }

                HttpContext.Session.SetString("UserId", admin.Id.ToString());
                HttpContext.Session.SetString("Username", admin.Username);
                HttpContext.Session.SetString("UserRole", UserRole.Admin.ToString());
                HttpContext.Session.SetString("FullName", admin.FullName);

                return RedirectToAction("Dashboard", "Admin");
            }

            ViewBag.Error = "Invalid admin credentials";
            return View();
        }

        // LOGOUT
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        // TEST
        [HttpGet]
        public IActionResult Test()
        {
            return Content("Account controller is working!");
        }
    }
}