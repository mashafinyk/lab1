using BouquetMVC.Domain.Entities;
using BouquetMVC.Infrastracture.EntityConfigurations;
using BouquetMVС.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Infrastracture
{
    public class BouquetContext : DbContext
    {
        public BouquetContext(DbContextOptions<BouquetContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<ActiveCart> ActiveCarts { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<TypeOfFlower> TypeOfFlowers { get; set; }
        public DbSet<BouquetAndFlower> BouquetAndFlowers { get; set; }
        public DbSet<OrderBouquet> OrderBouquets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserAddressEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ActiveCartEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ResponseEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ShopEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BouquetEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PackageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TypeOfFlowerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BouquetAndFlowerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderBouquetEntityTypeConfiguration());
        }
    }
}
