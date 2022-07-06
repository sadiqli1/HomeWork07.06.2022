using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Service> Services { get; set; }
    }
}
