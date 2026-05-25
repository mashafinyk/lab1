using BouquetMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Infrastracture.EntityConfigurations
{
    public class OrderBouquetEntityTypeConfiguration : IEntityTypeConfiguration<OrderBouquet>
    {
        public void Configure(EntityTypeBuilder<OrderBouquet> builder)
        {
            builder.ToTable("OrderBouquet");

            builder.HasKey(x => new { x.OrderId, x.BouquetId, x.PackageId });

            builder.Property(x => x.OrderId).HasColumnName("order id");
            builder.Property(x => x.BouquetId).HasColumnName("bouquet id");
            builder.Property(x => x.PackageId).HasColumnName("package id");
            builder.Property(x => x.Quantity).HasColumnName("quantity").IsRequired();

            builder.HasOne(x => x.Order)
                .WithMany()
                .HasForeignKey(x => x.OrderId)
                .HasConstraintName("FK_OrderBouquet_Orders");

            builder.HasOne(x => x.Bouquet)
                .WithMany()
                .HasForeignKey(x => x.BouquetId)
                .HasConstraintName("FK_OrderBouquet_Bouquet");

            builder.HasOne(x => x.Package)
                .WithMany()
                .HasForeignKey(x => x.PackageId)
                .HasConstraintName("FK_OrderBouquet_Package");
        }
    }
}
