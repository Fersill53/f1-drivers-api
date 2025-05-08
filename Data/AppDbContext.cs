using Microsoft.EntityFrameworkCore;
using F1DriversApi.Models;

namespace F1DriversApi.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Driver> Drivers { get; set; }
        }
    }
