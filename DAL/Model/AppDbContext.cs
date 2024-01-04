using System;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;
namespace DAL.Model
{
	public class AppDbContext : DbContext
	{
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Analytic> Analytics { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

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

