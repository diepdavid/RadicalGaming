using Microsoft.EntityFrameworkCore;
using RadicalGamingWeb.Models;

namespace RadicalGamingWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Team { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "David", DisplayOrder = 1 },
                new Team { Id = 2, Name = "Charllie", DisplayOrder = 2 },
                new Team { Id = 3, Name = "Albin", DisplayOrder = 3 },
                new Team { Id = 4, Name = "Rick", DisplayOrder = 4 }
            );
        }
    }
}
