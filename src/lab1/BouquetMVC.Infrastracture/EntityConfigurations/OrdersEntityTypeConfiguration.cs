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
    public class OrdersEntityTypeConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Date).HasColumnName("date").IsRequired();
            builder.Property(x => x.Status).HasColumnName("status").HasMaxLength(50);
            builder.Property(x => x.Price).HasColumnName("price").HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(x => x.UserId).HasColumnName("user id").IsRequired();
            builder.Property(x => x.ShopId).HasColumnName("shop id");

            builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .HasConstraintName("FK_Orders_User");

            builder.HasOne(x => x.Shop)
                .WithMany()
                .HasForeignKey(x => x.ShopId)
                .HasConstraintName("FK_Orders_Shop");
        }
    }
}
