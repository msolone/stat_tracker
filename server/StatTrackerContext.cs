using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace server
{
    public partial class StatTrackerContext : DbContext
    {
        public StatTrackerContext()
        {
        }

        public StatTrackerContext(DbContextOptions<StatTrackerContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("server=localhost;database=stattracker");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
        public DbSet<PlayerStats> PlayerStat {get; set;}
    }
}
