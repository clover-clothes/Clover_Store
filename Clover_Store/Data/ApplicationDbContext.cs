
using Clover_Store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace Clover_Store.Data{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Attributes> attributes { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Cutomer> Cutomer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Reviwe> Reviwe { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<wishList> wishList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          /*  modelBuilder.Entity<Categorys>().HasData(
                new Categorys { Id = 1,Name="short",Details="" }

                );
            modelBuilder.Entity<Product>().HasData(
                new Product {Id=1,Title="sweatsheart" ,Brand_name="nike",CategoryID=1,Gender="Male",Total_quantity=13,Description="guzel"},
                 new Product { Id = 2, Title = "sweat", Brand_name = "nike", CategoryID = 1, Gender = "Male", Total_quantity = 13, Description = "guzel" },
                  new Product { Id = 3, Title = "man style", Brand_name = "adedas", CategoryID = 1, Gender = "Male", Total_quantity = 10, Description = "guzel" }

                );*/

        }
    }
}
