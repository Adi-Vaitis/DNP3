using DNP3.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DNP3.DataAccess
{
    public class DNPDbContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\vaiti\Documents\GitHub\DNP3\DNP3\DNP3.db");
        }
    }
}