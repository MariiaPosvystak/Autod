using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Autod.Data
{
    public class AutoDbContext : DbContext
    {
        public DbSet<Owner> Omanik { get; set; }
        public DbSet<Car> Auto { get; set; }
        public DbSet<Service> Teenus { get; set; }
        public DbSet<CarService> Hoolduse_Kirje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Autod_DB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().ToTable("Omanik");
            modelBuilder.Entity<Car>().ToTable("Auto");
            modelBuilder.Entity<Service>().ToTable("Teenus");
            modelBuilder.Entity<CarService>().ToTable("Hoolduse_Kirje");
            modelBuilder.Entity<CarService>().Property(cs => cs.DateOfService).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<CarService>().HasKey(cs => new { cs.CarId, cs.ServiceId });

        }
        public void EnsureCreated()
        {
            this.Database.EnsureCreated();
        }
    }
}
