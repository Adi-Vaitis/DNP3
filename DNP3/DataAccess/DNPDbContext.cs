using Microsoft.EntityFrameworkCore;
using Models;

namespace DNP3.DataAccess
{
    public class DNPDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Interest> Interests { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DNP3.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interest>().HasKey(interest => interest.IdInterest);
            modelBuilder.Entity<Job>().HasKey(job => job.IdJob);
        }
    }
}