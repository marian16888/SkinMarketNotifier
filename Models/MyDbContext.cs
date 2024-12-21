using Microsoft.EntityFrameworkCore;

namespace SkinMarketNotifier.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}