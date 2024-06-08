

using Clover_Store.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace Clover_Store.Data{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<attributes> attributes { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Customer> Cutomer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Reviwe> Reviwe { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<wishList> wishList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Categorys>().HasData(
            //    new Categorys { Id = 1, Name = "pants", Details = "" },
            //    new Categorys { Id = 2, Name = "sport", Details = "" },
            //    new Categorys { Id = 3, Name = "dress", Details = "" },
            //    new Categorys { Id = 4, Name = "skirt", Details = "" },
            //    new Categorys { Id = 5, Name = "shirt", Details = "" },
            //    new Categorys { Id = 6, Name = "sweat", Details = "" },
            //    new Categorys { Id = 7, Name = "Tunic", Details = "" },
            //    new Categorys { Id = 8, Name = "Coat", Details = "" }

            //    );
            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        Id = 1,
            //        Title = "Polo Yaka Kısa Kollu Pike Erkek Tişört",
            //        Material= "100% Cotton",
            //        Brand_name = "LCW",
            //        CategoryID = 1,
            //        Type = "Male",
            //        Total_quantity = 13,
            //        Description = "Made from waffle fabric, this t-shirt offers a stylish and modern look with its polo collar design.\r\n" +
            //        " With its soft and comfortable texture,\r\n" +
            //        " it can be preferred both in daily life and on special occasions.",

            //    },
            //    new Product
            //    {
            //        Id = 2,

            //        Title = "Regular Fit Men's Short Sleeve Shirt",
            //        Material = "100% Cotton",
            //        Brand_name = "adidas",
            //        CategoryID = 5,
            //        Type = "Male",
            //        Total_quantity = 13,
            //        Description = "It is made of durable and easy-care polyester fabric.\r\n" +
            //        " Its short sleeve design keeps you cool and comfortable even in hot weather conditions."
            //    },
            //    new Product
            //    {
            //        Id = 3,
            //        Title = "Crew Neck Plain Short Sleeve Oversize Women's Tunic",
            //        Material = "100% Cotton",
            //        Brand_name = "ZARA",
            //        CategoryID = 7,
            //        Type = "Male",
            //        Total_quantity = 13,
            //        Description = "Round neck, straight short sleeve oversize tunic, made of single jersey fabric. It provides coolness in summer with its light and breathable structure. \r\n" +
            //        "Its oversize cut provides freedom of movement and is designed in hip-length length so that you can move comfortably."
            //    }

            //    );
            //modelBuilder.Entity<Colors>().HasData(
            //  new Colors { Id = 1, Name = "Green", Red = 37,Green=67,Blue=54 }, 
            //  new Colors { Id = 2, Name = "Sage", Red = 181, Green = 193, Blue = 142 },
            //  new Colors { Id = 3, Name = "Brown", Red = 199, Green = 183, Blue = 163 },
            //  new Colors { Id = 4, Name = "Maroon", Red = 169, Green = 29, Blue = 58 },
            //  new Colors { Id = 5, Name = "Ecru", Red = 185, Green = 169, Blue = 124 },
            //  new Colors { Id = 6, Name = "Khaki", Red = 91, Green = 86, Blue = 65 }
            //  //new Colors { Id = 7, Name = "Tunic", Red = 37, Green = 67, Blue = 54 },
            //  //new Colors { Id = 8, Name = "Coat", Red = 37, Green = 67, Blue = 54 }

            //  );
            //modelBuilder.Entity<Sizes>().HasData(
            //  new Sizes { Id = 1, Name = "XS", Details = "" },
            //  new Sizes { Id = 2, Name = "S", Details = "" },
            //  new Sizes { Id = 3, Name = "M", Details = "" },
            //  new Sizes { Id = 4, Name = "L", Details = "" },
            //  new Sizes { Id = 5, Name = "XL", Details = "" },
            //  new Sizes { Id = 6, Name = "2XL", Details = "" },
            //  new Sizes { Id = 7, Name = "3XL", Details = "" },
            //  new Sizes { Id = 8, Name = "26", Details = "" },
            //  new Sizes { Id = 9, Name = "27", Details = "" },
            //  new Sizes { Id = 10, Name = "28", Details = "" },
            //  new Sizes { Id = 11, Name = "29", Details = "" },
            //  new Sizes { Id = 12, Name = "30", Details = "" },
            //  new Sizes { Id = 13, Name = "30-31", Details = "" },
            //  new Sizes { Id = 14, Name = "30-32", Details = "" },
            //  new Sizes { Id = 15, Name = "31", Details = "" },
            //  new Sizes { Id = 16, Name = "32", Details = "" },
            //  new Sizes { Id = 17, Name = "32-31", Details = "" },
            //  new Sizes { Id = 18, Name = "36", Details = "" }

            //  );
            //modelBuilder.Entity<attributes>().HasData(
            //   new attributes { Id = 1,ProductID = 1,ColorID = 2,SizeID=2,Quantity=10,Price=699.99m },
            //   new attributes { Id = 2, ProductID = 1, ColorID = 4, SizeID = 3, Quantity = 10, Price = 699.99m },
            //   new attributes { Id = 3, ProductID = 1, ColorID = 4, SizeID = 4, Quantity = 10, Price = 799.99m },
            //   new attributes { Id = 4, ProductID = 2, ColorID = 2, SizeID = 3, Quantity = 10, Price = 675.00m },
            //   new attributes { Id = 5, ProductID = 2, ColorID = 2, SizeID = 6, Quantity = 8, Price = 975.00m },
            //   new attributes { Id = 6, ProductID = 2, ColorID = 6, SizeID = 3, Quantity = 14, Price = 975.00m },
            //   new attributes { Id = 7, ProductID = 2, ColorID = 6, SizeID = 5, Quantity = 10, Price = 899.99m },
            //   new attributes { Id = 8, ProductID = 3, ColorID = 2, SizeID = 2, Quantity = 15, Price = 899.99m }

            //   );
             modelBuilder.Entity<Image>().HasData(
               new Image { Id = 1,Image_url= "~/Images/product/Screenshot 2024-06-06 160542.png",attributId=1 },
               new Image { Id = 2,Image_url= "~/Images/product/Screenshot 2024-06-06 161345.png", attributId=2 },
               new Image { Id = 3,Image_url= "~/Images/product/Screenshot 2024-06-06 160542.png",attributId=3 },
               new Image { Id = 4,Image_url= "~/Images/product/Screenshot 2024-06-06 160542.png",attributId=4 },
               new Image { Id = 5,Image_url= "~/Images/product/Screenshot 2024-06-06 160542.png",attributId=5 },
               new Image { Id = 6,Image_url= "~/Images/product/Screenshot 2024-06-06 160542.png",attributId=6 }
               );


        }
    }
}
