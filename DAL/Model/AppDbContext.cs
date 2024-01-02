using System;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;
namespace DAL.Model
{
	public class AppDbContext : DbContext
	{
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Conversion> Conversions { get; set; }

        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(DataAccessFactory.CONNECTION_STRING); // Replace with your default connection string
            }
        }

    }
}

