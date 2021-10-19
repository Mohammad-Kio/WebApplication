using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op): base(op)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        
    }
}