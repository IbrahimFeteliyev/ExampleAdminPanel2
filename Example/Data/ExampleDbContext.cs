using Example.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Data
{
    public class ExampleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExampleDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Masthead> Mastheads { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contactme> Contactmes { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

    }
}
