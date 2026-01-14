using Microsoft.EntityFrameworkCore;

namespace A_Visit_To_Georgia.Models
{
    public class BokningbordDbContext : DbContext
    {
        public BokningbordDbContext(DbContextOptions<BokningbordDbContext> options)
            : base(options) { }

        public DbSet<Bokningbord> Bokningar => Set<Bokningbord>();
        public DbSet<MenuItem> MenuItems => Set<MenuItem>();
    }
  
}





