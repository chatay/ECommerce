using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.DataAccess
{
    public class EnityFramWorkDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.InsertedDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.UpdatedDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.UserId).HasDefaultValueSql("1");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}