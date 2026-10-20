using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Raceway.Models;

namespace Raceway.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events => Set<Event>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Enrolment> Enrolments => Set<Enrolment>();
        public DbSet<Result> Results => Set<Result>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .Property(u => u.Gender)
                .HasConversion<string>()
                .HasMaxLength(20);

            modelBuilder.Entity<Event>()
                .Property(e => e.DistanceKm)
                .HasPrecision(18, 2);
        }
    }
}