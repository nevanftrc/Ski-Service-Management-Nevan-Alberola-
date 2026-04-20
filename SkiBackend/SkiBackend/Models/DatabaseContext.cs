using Microsoft.EntityFrameworkCore;

namespace SkiBackend.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<ServiceOrder> ServiceOrder { get; set; } 
    }
}
