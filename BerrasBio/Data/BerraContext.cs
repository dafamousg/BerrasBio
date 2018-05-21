using BerrasBio.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasBio.Data
{
    public class BerraContext : DbContext
    {
        public BerraContext(DbContextOptions<BerraContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Showing> Showings { get; set; }
        public DbSet<Salon> Salons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Booking>().ToTable("Bookings");
            modelBuilder.Entity<Showing>().ToTable("Showings");
            modelBuilder.Entity<Salon>().ToTable("Salons");

            modelBuilder.Entity<Booking>().HasOne(t => t.Showing).WithMany(sh => sh.Bookings).HasForeignKey(t => t.ShowingID);
            modelBuilder.Entity<Salon>().HasMany(s => s.Showings).WithOne(sh => sh.Salon).HasForeignKey(sh => sh.SalonID);
            modelBuilder.Entity<Movie>().HasMany(m => m.Showings).WithOne(sh => sh.Movie).HasForeignKey(s => s.MovieID);
        }
    }
}
