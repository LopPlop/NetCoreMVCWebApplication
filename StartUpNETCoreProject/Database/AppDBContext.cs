using Microsoft.EntityFrameworkCore;
using StartUpNETCoreProject.Database.Tables;

namespace StartUpNETCoreProject.Database
{
    public class AppDBContext : DbContext
    {
        public DbSet<Logging> Loggings { get; set; }

        public AppDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Logging>().HasData(new Logging {
                Id = 1,
                Login = "Admin",
                Password = "Admin"
            });
        }
    }
}
