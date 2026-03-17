using Microsoft.EntityFrameworkCore;
using Grosary_net.Models;
using System;

namespace Grosary_net.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tables
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fix decimal warning
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(10, 2);

            // Admin user seed
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "123",
                    Email = "admin@gmail.com",
                    FullName = "Admin",
                    Role = UserRole.Admin
                }
            );

            // Product seed data
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 70,
                    Name = "Chicken Breast",
                    Description = "Fresh boneless chicken breast perfect for grilling and cooking.",
                    Price = 8.99m,
                    StockQuantity = 35,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/616353/pexels-photo-616353.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product
                {
                    Id = 71,
                    Name = "Mutton",
                    Description = "Fresh goat meat ideal for curries and traditional dishes.",
                    Price = 12.99m,
                    StockQuantity = 25,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product
                {
                    Id = 72,
                    Name = "Beef Steak",
                    Description = "Premium beef steak perfect for grilling and roasting.",
                    Price = 14.99m,
                    StockQuantity = 20,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product
                {
                    Id = 73,
                    Name = "Chicken Drumsticks",
                    Description = "Fresh chicken drumsticks perfect for frying and BBQ.",
                    Price = 7.49m,
                    StockQuantity = 30,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/65175/pexels-photo-65175.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product
                {
                    Id = 74,
                    Name = "Minced Meat",
                    Description = "Fresh minced meat ideal for burgers and meatballs.",
                    Price = 9.49m,
                    StockQuantity = 28,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/361184/asparagus-steak-veal-chop-361184.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product
                {
                    Id = 75,
                    Name = "Turkey Meat",
                    Description = "Lean turkey meat rich in protein and low in fat.",
                    Price = 10.99m,
                    StockQuantity = 18,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product
                {
                    Id = 76,
                    Name = "Lamb Chops",
                    Description = "Tender lamb chops perfect for grilling and roasting.",
                    Price = 13.99m,
                    StockQuantity = 16,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product
                {
                    Id = 77,
                    Name = "Sausages",
                    Description = "Juicy sausages perfect for breakfast and grilling.",
                    Price = 6.99m,
                    StockQuantity = 40,
                    Category = "Meat",
                    ImageUrl = "https://images.pexels.com/photos/65175/pexels-photo-65175.jpeg",
                    AddedDate = new DateTime(2024, 1, 1)
                },

                new Product { Id = 101, Name="Red Apples", Description="Fresh sweet red apples.", Price=4.99m, StockQuantity=50, Category="Fruits", ImageUrl="https://images.pexels.com/photos/102104/pexels-photo-102104.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 102, Name="Bananas", Description="Organic bananas rich in potassium.", Price=3.49m, StockQuantity=60, Category="Fruits", ImageUrl="https://images.pexels.com/photos/1093038/pexels-photo-1093038.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 103, Name="Strawberries", Description="Sweet fresh strawberries.", Price=6.99m, StockQuantity=30, Category="Fruits", ImageUrl="https://images.pexels.com/photos/89778/strawberries-frisch-ripe-sweet-89778.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 104, Name="Oranges", Description="Juicy oranges rich in vitamin C.", Price=5.99m, StockQuantity=40, Category="Fruits", ImageUrl="https://images.pexels.com/photos/327098/pexels-photo-327098.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 105, Name="Mango", Description="Sweet tropical mango.", Price=7.49m, StockQuantity=35, Category="Fruits", ImageUrl="https://images.pexels.com/photos/918643/pexels-photo-918643.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 106, Name="Pineapple", Description="Fresh pineapple.", Price=6.49m, StockQuantity=20, Category="Fruits", ImageUrl="https://images.pexels.com/photos/594589/pexels-photo-594589.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 107, Name="Green Grapes", Description="Juicy green grapes.", Price=4.59m, StockQuantity=30, Category="Fruits", ImageUrl="https://images.pexels.com/photos/708777/pexels-photo-708777.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 108, Name="Watermelon", Description="Refreshing watermelon.", Price=7.49m, StockQuantity=25, Category="Fruits", ImageUrl="https://images.pexels.com/photos/615705/pexels-photo-615705.jpeg", AddedDate=new DateTime(2024,1,1)},

new Product { Id = 120, Name="Potato Chips", Description="Crunchy salted chips.", Price=2.99m, StockQuantity=50, Category="Snacks", ImageUrl="https://images.pexels.com/photos/568805/pexels-photo-568805.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 121, Name="Chocolate Bar", Description="Sweet milk chocolate.", Price=1.99m, StockQuantity=60, Category="Snacks", ImageUrl="https://images.pexels.com/photos/65882/chocolate-dark-coffee-confiserie-65882.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 122, Name="Biscuits", Description="Crunchy tea biscuits.", Price=2.49m, StockQuantity=40, Category="Snacks", ImageUrl="https://images.pexels.com/photos/230325/pexels-photo-230325.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 123, Name="Popcorn", Description="Salted popcorn snack.", Price=2.99m, StockQuantity=30, Category="Snacks", ImageUrl="https://images.pexels.com/photos/33129/popcorn-movie-party-entertainment.jpg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 124, Name="Nachos", Description="Crunchy nachos snack.", Price=3.49m, StockQuantity=35, Category="Snacks", ImageUrl="https://images.pexels.com/photos/461198/pexels-photo-461198.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 125, Name="Cupcake", Description="Sweet cupcake dessert.", Price=2.79m, StockQuantity=20, Category="Snacks", ImageUrl="https://images.pexels.com/photos/357573/pexels-photo-357573.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 126, Name="Cookies", Description="Fresh baked cookies.", Price=3.49m, StockQuantity=30, Category="Snacks", ImageUrl="https://images.pexels.com/photos/4110541/pexels-photo-4110541.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 127, Name="Granola Bar", Description="Healthy granola snack.", Price=2.19m, StockQuantity=25, Category="Snacks", ImageUrl="https://images.pexels.com/photos/1128678/pexels-photo-1128678.jpeg", AddedDate=new DateTime(2024,1,1)},

new Product { Id = 110, Name="Spinach", Description="Fresh green spinach.", Price=2.49m, StockQuantity=20, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/143133/pexels-photo-143133.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 111, Name="Carrots", Description="Organic crunchy carrots.", Price=2.99m, StockQuantity=40, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/65174/pexels-photo-65174.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 112, Name="Tomatoes", Description="Fresh red tomatoes.", Price=3.99m, StockQuantity=50, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/533280/pexels-photo-533280.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 113, Name="Bell Peppers", Description="Fresh green bell peppers.", Price=2.99m, StockQuantity=30, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/128420/pexels-photo-128420.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 114, Name="Broccoli", Description="Healthy broccoli.", Price=3.49m, StockQuantity=35, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/143133/pexels-photo-143133.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 115, Name="Cucumber", Description="Fresh cucumber.", Price=2.29m, StockQuantity=30, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/2329440/pexels-photo-2329440.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 116, Name="Onions", Description="Fresh red onions.", Price=2.39m, StockQuantity=40, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/175414/pexels-photo-175414.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 117, Name="Potatoes", Description="Farm fresh potatoes.", Price=3.19m, StockQuantity=50, Category="Vegetables", ImageUrl="https://images.pexels.com/photos/144248/potatoes-food-vegetables-organic-144248.jpeg", AddedDate=new DateTime(2024,1,1)},

new Product { Id = 130, Name="Orange Juice", Description="Fresh orange juice.", Price=3.99m, StockQuantity=30, Category="Beverages", ImageUrl="https://images.pexels.com/photos/96974/pexels-photo-96974.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 131, Name="Apple Juice", Description="Natural apple juice.", Price=3.49m, StockQuantity=35, Category="Beverages", ImageUrl="https://images.pexels.com/photos/96974/pexels-photo-96974.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 132, Name="Cola Drink", Description="Cold cola beverage.", Price=2.49m, StockQuantity=50, Category="Beverages", ImageUrl="https://images.pexels.com/photos/2983101/pexels-photo-2983101.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 133, Name="Energy Drink", Description="Refreshing energy drink.", Price=3.99m, StockQuantity=40, Category="Beverages", ImageUrl="https://images.pexels.com/photos/2775860/pexels-photo-2775860.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 134, Name="Cold Coffee", Description="Iced coffee drink.", Price=4.49m, StockQuantity=20, Category="Beverages", ImageUrl="https://images.pexels.com/photos/302899/pexels-photo-302899.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 135, Name="Green Tea", Description="Healthy green tea.", Price=3.19m, StockQuantity=30, Category="Beverages", ImageUrl="https://images.pexels.com/photos/1417945/pexels-photo-1417945.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 136, Name="Milkshake", Description="Sweet milkshake drink.", Price=4.29m, StockQuantity=25, Category="Beverages", ImageUrl="https://images.pexels.com/photos/1435735/pexels-photo-1435735.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 137, Name="Mineral Water", Description="Pure drinking water.", Price=1.49m, StockQuantity=100, Category="Beverages", ImageUrl="https://images.pexels.com/photos/327090/pexels-photo-327090.jpeg", AddedDate=new DateTime(2024,1,1)},

new Product { Id = 140, Name="Salmon Fish", Description="Fresh salmon fish.", Price=12.99m, StockQuantity=20, Category="Seafood", ImageUrl="https://images.pexels.com/photos/725991/pexels-photo-725991.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 141, Name="Tuna Fish", Description="Premium tuna fish.", Price=11.49m, StockQuantity=18, Category="Seafood", ImageUrl="https://images.pexels.com/photos/3296277/pexels-photo-3296277.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 142, Name="Shrimp", Description="Fresh shrimp seafood.", Price=13.99m, StockQuantity=25, Category="Seafood", ImageUrl="https://images.pexels.com/photos/566345/pexels-photo-566345.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 143, Name="Crab", Description="Fresh sea crab.", Price=14.49m, StockQuantity=15, Category="Seafood", ImageUrl="https://images.pexels.com/photos/3296390/pexels-photo-3296390.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 144, Name="Lobster", Description="Premium lobster seafood.", Price=19.99m, StockQuantity=10, Category="Seafood", ImageUrl="https://images.pexels.com/photos/566345/pexels-photo-566345.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 145, Name="Sardines", Description="Fresh sardine fish.", Price=8.49m, StockQuantity=30, Category="Seafood", ImageUrl="https://images.pexels.com/photos/3296390/pexels-photo-3296390.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 146, Name="Tilapia", Description="Fresh tilapia fish.", Price=9.99m, StockQuantity=22, Category="Seafood", ImageUrl="https://images.pexels.com/photos/725991/pexels-photo-725991.jpeg", AddedDate=new DateTime(2024,1,1)},
new Product { Id = 147, Name="Prawns", Description="Fresh prawns seafood.", Price=12.49m, StockQuantity=28, Category="Seafood", ImageUrl="https://images.pexels.com/photos/566345/pexels-photo-566345.jpeg", AddedDate=new DateTime(2024,1,1)}
            );
        }
    }
}