
using Clover_Store.Models;
using Microsoft.EntityFrameworkCore;
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
    }
}
