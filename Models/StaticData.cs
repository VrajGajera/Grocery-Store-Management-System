using System;
using System.Collections.Generic;
using System.Linq;

namespace Grosary_net.Models
{
    public class StaticData
    {
        public static List<User> Users { get; set; } = new List<User>
        {
            new User
            {
                Id = 1,
                Username = "admin",
                Password = "Admin@123",
                Email = "admin@grosary.com",
                FullName = "System Admin",
                Role = UserRole.Admin,
                RegistrationDate = DateTime.Now
            },
            new User
            {
                Id = 2,
                Username = "john",
                Password = "john123",
                Email = "john@email.com",
                FullName = "John Customer",
                Role = UserRole.Customer,
                RegistrationDate = DateTime.Now
            },
            new User
            {
                Id = 3,
                Username = "demo",
                Password = "demo123",
                Email = "demo@email.com",
                FullName = "Demo User",
                Role = UserRole.Customer,
                RegistrationDate = DateTime.Now
            }
        };

        public static List<Product> Products { get; set; } = new List<Product>
        {
            // Fruits
            new Product { Id = 1, Name="Fresh Red Apples", Description="Sweet red apples", Price=4.99m, StockQuantity=50, Category="Fruits", ImageUrl="https://images.pexels.com/photos/102104/pexels-photo-102104.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 2, Name="Organic Bananas", Description="Fresh bananas", Price=3.49m, StockQuantity=100, Category="Fruits", ImageUrl="https://images.pexels.com/photos/1093038/pexels-photo-1093038.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 3, Name="Fresh Strawberries", Description="Juicy strawberries", Price=6.99m, StockQuantity=35, Category="Fruits", ImageUrl="https://images.pexels.com/photos/46174/pexels-photo-46174.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 4, Name="Juicy Oranges", Description="Vitamin C oranges", Price=5.99m, StockQuantity=45, Category="Fruits", ImageUrl="https://images.pexels.com/photos/327098/pexels-photo-327098.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 5, Name="Fresh Mangoes", Description="Sweet mangoes", Price=8.99m, StockQuantity=40, Category="Fruits", ImageUrl="https://images.pexels.com/photos/918643/pexels-photo-918643.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 6, Name="Pineapple", Description="Fresh pineapple", Price=6.49m, StockQuantity=30, Category="Fruits", ImageUrl="https://images.pexels.com/photos/594589/pexels-photo-594589.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 7, Name="Green Grapes", Description="Juicy grapes", Price=4.59m, StockQuantity=40, Category="Fruits", ImageUrl="https://images.pexels.com/photos/708777/pexels-photo-708777.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 8, Name="Watermelon", Description="Summer watermelon", Price=7.49m, StockQuantity=20, Category="Fruits", ImageUrl="https://images.pexels.com/photos/615705/pexels-photo-615705.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 9, Name="Papaya", Description="Healthy papaya", Price=5.29m, StockQuantity=35, Category="Fruits", ImageUrl="https://images.pexels.com/photos/594575/pexels-photo-594575.jpeg", AddedDate=DateTime.Now },

            // Vegetables
            new Product { Id = 10, Name="Fresh Spinach", Description="Organic spinach", Price=2.49m, StockQuantity=20, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/143133/pexels-photo-143133.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 11, Name="Organic Carrots", Description="Crunchy carrots", Price=2.99m, StockQuantity=45, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/65174/pexels-photo-65174.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 12, Name="Fresh Tomatoes", Description="Ripe tomatoes", Price=3.99m, StockQuantity=60, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/533280/pexels-photo-533280.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 13, Name="Green Bell Peppers", Description="Fresh peppers", Price=2.99m, StockQuantity=40, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/461198/pexels-photo-461198.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 14, Name="Fresh Broccoli", Description="Healthy broccoli", Price=3.49m, StockQuantity=35, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/143133/pexels-photo-143133.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 15, Name="Cucumbers", Description="Fresh cucumbers", Price=2.29m, StockQuantity=50, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/2329440/pexels-photo-2329440.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 16, Name="Red Onions", Description="Fresh onions", Price=2.39m, StockQuantity=70, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/175414/pexels-photo-175414.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 17, Name="Potatoes", Description="Farm potatoes", Price=3.19m, StockQuantity=80, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/144248/potatoes-food-vegetables-organic-144248.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 18, Name="Cauliflower", Description="Fresh cauliflower", Price=3.69m, StockQuantity=30, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/46174/cauliflower-vegetable-food-healthy-46174.jpeg", AddedDate=DateTime.Now },

            // Dairy
            new Product { Id = 19, Name="Fresh Milk", Description="Farm milk", Price=2.99m, StockQuantity=30, Category="Dairy", ImageUrl="https://images.pexels.com/photos/236973/pexels-photo-236973.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 20, Name="Farm Fresh Eggs", Description="Protein eggs", Price=5.99m, StockQuantity=40, Category="Dairy", ImageUrl="https://images.pexels.com/photos/162712/egg-white-food-protein-162712.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 21, Name="Cheddar Cheese", Description="Creamy cheese", Price=7.99m, StockQuantity=25, Category="Dairy", ImageUrl="https://images.pexels.com/photos/4109993/pexels-photo-4109993.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 22, Name="Greek Yogurt", Description="Protein yogurt", Price=4.99m, StockQuantity=35, Category="Dairy", ImageUrl="https://images.pexels.com/photos/1435735/pexels-photo-1435735.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 23, Name="Butter", Description="Fresh butter", Price=4.49m, StockQuantity=20, Category="Dairy", ImageUrl="https://images.pexels.com/photos/531334/pexels-photo-531334.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 24, Name="Paneer", Description="Fresh paneer", Price=5.99m, StockQuantity=25, Category="Dairy", ImageUrl="https://images.pexels.com/photos/4198016/pexels-photo-4198016.jpeg", AddedDate=DateTime.Now },

            // Bakery
            new Product { Id = 25, Name="Whole Wheat Bread", Description="Fresh bread", Price=3.99m, StockQuantity=25, Category="Bakery", ImageUrl="https://images.pexels.com/photos/209206/pexels-photo-209206.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 26, Name="Chocolate Croissant", Description="Buttery croissant", Price=2.99m, StockQuantity=15, Category="Bakery", ImageUrl="https://images.pexels.com/photos/239581/pexels-photo-239581.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 27, Name="Butter Cookies", Description="Crunchy cookies", Price=3.49m, StockQuantity=30, Category="Bakery", ImageUrl="https://images.pexels.com/photos/4110541/pexels-photo-4110541.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 28, Name="Blueberry Muffin", Description="Soft muffin", Price=2.79m, StockQuantity=18, Category="Bakery", ImageUrl="https://images.pexels.com/photos/291528/pexels-photo-291528.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 29, Name="Garlic Bread", Description="Garlic bread", Price=3.49m, StockQuantity=22, Category="Bakery", ImageUrl="https://images.pexels.com/photos/209206/pexels-photo-209206.jpeg", AddedDate=DateTime.Now },
            new Product { Id = 30, Name="Donuts", Description="Sweet donuts", Price=4.29m, StockQuantity=28, Category="Bakery", ImageUrl="https://images.pexels.com/photos/357573/pexels-photo-357573.jpeg", AddedDate=DateTime.Now }
        };

        public static List<Order> Orders { get; set; } = new List<Order>();

        public static Dictionary<int, List<CartItem>> UserCarts { get; set; } = new Dictionary<int, List<CartItem>>();

        public static int GetNextUserId()
        {
            return Users.Max(u => u.Id) + 1;
        }

        public static int GetNextProductId()
        {
            return Products.Max(p => p.Id) + 1;
        }

        public static int GetNextOrderId()
        {
            return Orders.Any() ? Orders.Max(o => o.Id) + 1 : 1;
        }
    }
}