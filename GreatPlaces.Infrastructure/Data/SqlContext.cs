using GreatPlaces.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreatPlaces.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Attractions> Attractions { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Name") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Name").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Name").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}