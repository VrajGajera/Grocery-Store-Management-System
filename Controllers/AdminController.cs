using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Grosary_net.Models;
using Grosary_net.Data;
using System;
using System.Linq;

namespace Grosary_net.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Admin authorization check
        private bool IsAdmin()
        {
            return HttpContext.Session.GetString("UserRole") == UserRole.Admin.ToString();
        }

        // ================= DASHBOARD =================
        public IActionResult Dashboard()
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");

            ViewBag.TotalProducts = _context.Products.Count();
            ViewBag.TotalOrders = _context.Orders.Count();
            ViewBag.TotalCustomers = _context.Users.Count(u => u.Role == UserRole.Customer);

            ViewBag.LowStock = _context.Products.Count(p => p.StockQuantity < 5);

            // Load recent orders with items
            ViewBag.RecentOrders = _context.Orders
                .Include(o => o.Items)
                .OrderByDescending(o => o.OrderDate)
                .Take(5)
                .ToList();

            return View();
        }

        // ================= PRODUCT LIST =================
        public IActionResult ProductList()
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");

            var products = _context.Products.ToList();
            return View(products);
        }

        // ================= ADD PRODUCT =================
        [HttpGet]
        public IActionResult AddProduct()
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");

            if (ModelState.IsValid)
            {
                product.AddedDate = DateTime.Now;

                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("ProductList");
            }

            return View(product);
        }

        // ================= EDIT PRODUCT =================
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");

            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");

            if (ModelState.IsValid)
            {
                var existingProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);

                if (existingProduct != null)
                {
                    existingProduct.Name = product.Name;
                    existingProduct.Description = product.Description;
                    existingProduct.Price = product.Price;
                    existingProduct.StockQuantity = product.StockQuantity;
                    existingProduct.Category = product.Category;
                    existingProduct.ImageUrl = product.ImageUrl;

                    _context.SaveChanges();
                }

                return RedirectToAction("ProductList");
            }

            return View(product);
        }

        // ================= DELETE PRODUCT =================
        public IActionResult DeleteProduct(int id)
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");

            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

            return RedirectToAction("ProductList");
        }

        // ================= ORDER LIST =================
        public IActionResult OrderList()
        {
            if (!IsAdmin()) return RedirectToAction("AdminLogin", "Account");

            var orders = _context.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .OrderByDescending(o => o.OrderDate)
                .ToList();

            return View(orders);
        }

        // ================= UPDATE ORDER STATUS =================
        [HttpPost]
        public IActionResult UpdateOrderStatus(int id, string status)
        {
            if (!IsAdmin())
                return RedirectToAction("AdminLogin", "Account");

            var order = _context.Orders.FirstOrDefault(o => o.Id == id);

            if (order != null)
            {
                order.Status = Enum.Parse<OrderStatus>(status);
                _context.SaveChanges();
            }

            return RedirectToAction("OrderList");
        }
    }
}