using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Grosary_net.Models;
using Grosary_net.Data;
using System;
using System.Linq;

namespace Grosary_net.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        private int GetCurrentUserId()
        {
            var userId = HttpContext.Session.GetString("UserId");
            return userId != null ? int.Parse(userId) : 0;
        }

        private bool IsCustomer()
        {
            return HttpContext.Session.GetString("UserRole") == UserRole.Customer.ToString();
        }

        // ================= PRODUCT LIST =================
        public IActionResult ProductList()
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var products = _context.Products.ToList();
            return View(products);
        }

        // ================= CART =================
        public IActionResult Cart()
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var userId = GetCurrentUserId();

            var cart = _context.CartItems
                .Where(c => c.UserId == userId)
                .ToList();

            return View(cart);
        }

        // ================= ADD TO CART =================
        public IActionResult AddToCart(int productId, int quantity = 1)
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var userId = GetCurrentUserId();

            var product = _context.Products.FirstOrDefault(p => p.Id == productId);

            if (product == null) return NotFound();

            if (quantity > product.StockQuantity)
            {
                TempData["Error"] = $"Only {product.StockQuantity} items available in stock.";
                return RedirectToAction("ProductList");
            }

            var existingItem = _context.CartItems
                .FirstOrDefault(c => c.UserId == userId && c.ProductId == productId);

            if (existingItem != null)
            {
                if (existingItem.Quantity + quantity > product.StockQuantity)
                {
                    TempData["Error"] = "Stock limit reached!";
                    return RedirectToAction("ProductList");
                }

                existingItem.Quantity += quantity;
            }
            else
            {
                var cartItem = new CartItem
                {
                    UserId = userId,
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Price = product.Price,
                    Quantity = quantity,
                    ImageUrl = product.ImageUrl
                };

                _context.CartItems.Add(cartItem);
            }

            _context.SaveChanges();

            return RedirectToAction("ProductList");
        }

        // ================= REMOVE FROM CART =================
        public IActionResult RemoveFromCart(int productId)
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var userId = GetCurrentUserId();

            var item = _context.CartItems
                .FirstOrDefault(c => c.UserId == userId && c.ProductId == productId);

            if (item != null)
            {
                _context.CartItems.Remove(item);
                _context.SaveChanges();
            }

            return RedirectToAction("Cart");
        }

        // ================= UPDATE CART QUANTITY =================
        public IActionResult UpdateCartQuantity(int productId, int quantity)
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var userId = GetCurrentUserId();

            var item = _context.CartItems
                .FirstOrDefault(c => c.UserId == userId && c.ProductId == productId);

            var product = _context.Products.FirstOrDefault(p => p.Id == productId);

            if (item != null && product != null)
            {
                if (quantity <= 0)
                {
                    _context.CartItems.Remove(item);
                }
                else if (quantity <= product.StockQuantity)
                {
                    item.Quantity = quantity;
                }

                _context.SaveChanges();
            }

            return RedirectToAction("Cart");
        }

        // ================= CHECKOUT =================
        [HttpGet]
        public IActionResult Checkout()
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var userId = GetCurrentUserId();

            var cart = _context.CartItems
                .Where(c => c.UserId == userId)
                .ToList();

            if (!cart.Any())
                return RedirectToAction("ProductList");

            ViewBag.Total = cart.Sum(i => i.Subtotal);

            return View(cart);
        }

        // ================= PLACE ORDER =================
        [HttpPost]
        public IActionResult PlaceOrder(string shippingAddress, string paymentMethod)
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var userId = GetCurrentUserId();

            var cart = _context.CartItems
                .Where(c => c.UserId == userId)
                .ToList();

            if (!cart.Any())
                return RedirectToAction("ProductList");

            foreach (var item in cart)
            {
                var product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId);

                if (product == null || item.Quantity > product.StockQuantity)
                {
                    TempData["Error"] = $"Only {product.StockQuantity} items available for {product.Name}";
                    return RedirectToAction("Cart");
                }
            }

            var user = _context.Users.FirstOrDefault(u => u.Id == userId);

            var order = new Order
            {
                UserId = userId,
                UserName = user?.FullName ?? "Unknown",
                OrderDate = DateTime.Now,
                TotalAmount = cart.Sum(i => i.Subtotal),
                Status = OrderStatus.Pending,
                ShippingAddress = shippingAddress,
                PaymentMethod = paymentMethod
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            foreach (var item in cart)
            {
                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ImageUrl = item.ImageUrl
                };

                _context.Set<OrderItem>().Add(orderItem);

                var product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId);
                if (product != null)
                {
                    product.StockQuantity -= item.Quantity;
                }
            }

            _context.CartItems.RemoveRange(cart);
            _context.SaveChanges();

            return RedirectToAction("OrderHistory");
        }

        // ================= INCREASE QUANTITY =================
public IActionResult IncreaseQuantity(int productId)
{
    if (!IsCustomer()) return RedirectToAction("Login", "Account");

    var userId = GetCurrentUserId();

    var item = _context.CartItems
        .FirstOrDefault(c => c.UserId == userId && c.ProductId == productId);

    var product = _context.Products.FirstOrDefault(p => p.Id == productId);

    if (item != null && product != null)
    {
        if (item.Quantity < product.StockQuantity)
        {
            item.Quantity++;
            _context.SaveChanges();
        }
    }

    return RedirectToAction("Cart");
}
[HttpPost]
public IActionResult CancelOrder(int orderId)
{
    var order = _context.Orders.FirstOrDefault(o => o.Id == orderId);

    if (order != null && order.Status == OrderStatus.Pending)
    {
        order.Status = OrderStatus.Cancelled;
        _context.SaveChanges();
    }

    return RedirectToAction("OrderHistory");
}
[HttpPost]
// ================= DECREASE QUANTITY =================
public IActionResult DecreaseQuantity(int productId)
{
    if (!IsCustomer()) return RedirectToAction("Login", "Account");

    var userId = GetCurrentUserId();

    var item = _context.CartItems
        .FirstOrDefault(c => c.UserId == userId && c.ProductId == productId);

    if (item != null)
    {
        if (item.Quantity > 1)
        {
            item.Quantity--;
        }
        else
        {
            _context.CartItems.Remove(item);
        }

        _context.SaveChanges();
    }

    return RedirectToAction("Cart");
}
        // ================= ORDER HISTORY =================
        public IActionResult OrderHistory()
        {
            if (!IsCustomer()) return RedirectToAction("Login", "Account");

            var userId = GetCurrentUserId();

            var orders = _context.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.OrderDate)
                .ToList();

            return View(orders);
        }
        
    }
}