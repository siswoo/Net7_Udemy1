using Microsoft.EntityFrameworkCore;
using Udemy1_API.Modelos;

namespace Udemy1_API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
    }
}
