using GolfStore.Models.Models;
using GolfStore.DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace GolfStore.DataAccess.DataAccess
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.seed();
        }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Clubtype> Clubtypes { get; set; }

    }
}
