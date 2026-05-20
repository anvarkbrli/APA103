using _27_FrontToBackSqlConnection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace _27_FrontToBackSqlConnection.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Slider> sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }


    }
}
