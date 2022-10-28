using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.Data
{
    public class TattooContext : DbContext
    {
        public TattooContext(DbContextOptions<TattooContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tattoo> Tattoos { get; set; }
        public DbSet<Artist> Artiesten { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>().ToTable("Product").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            }
        }
}
