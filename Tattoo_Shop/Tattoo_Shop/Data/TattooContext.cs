
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Models;
using Tattoo_Shop.Areas.Identity.data;

namespace Tattoo_Shop.Data
{
    public class TattooContext : IdentityDbContext<CustomUser>
    {
        public TattooContext(DbContextOptions<TattooContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tattoo> Tattoos { get; set; }
        public DbSet<Artist> Artiesten { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Tattoo");
            modelBuilder.Entity<Product>().ToTable("Product").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Tattoo>().ToTable("Tattoo");
            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<OrderLijn>().ToTable("OrderLijn");
            modelBuilder.Entity<TattooKlant>().ToTable("TattooKlant");
            modelBuilder.Entity<OrderLijn>()
                .HasOne<Product>(ol => ol.Product)
                .WithMany(p => p.Orderlijnen)
                .HasForeignKey(ol => ol.ProductId)
                .IsRequired();
            modelBuilder.Entity<OrderLijn>()
                .HasOne<Order>(ol => ol.Order)
                .WithMany(o => o.Orderlijnen)
                .HasForeignKey(ol => ol.OrderId)
                .IsRequired();
            //modelBuilder.Entity<TattooKlant>()
            //    .HasOne<Klant>(tk => tk.Klant)
            //    .WithMany(p => p.Orderlijnen)
            //    .HasForeignKey(tk => tk.klantId)
            //    .IsRequired();
            modelBuilder.Entity<TattooKlant>()
                .HasOne<Tattoo>(tk => tk.Tattoo)
                .WithMany(t => t.TattooKlanten)
                .HasForeignKey(tk => tk.TattooId)
                .IsRequired();
            modelBuilder.Entity<Tattoo>()
                .HasOne<Artist>(t => t.Artist)
                .WithMany(t => t.Tattoos)
                .HasForeignKey(tk => tk.ArtistId)
                .IsRequired();
        }
    }
}
