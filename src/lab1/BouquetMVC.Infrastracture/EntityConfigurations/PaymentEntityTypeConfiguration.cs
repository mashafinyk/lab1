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
    public class PaymentEntityTypeConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Date).HasColumnName("date").IsRequired();
            builder.Property(x => x.Type).HasColumnName("type").HasMaxLength(50);
            builder.Property(x => x.Status).HasColumnName("status").HasMaxLength(50);
            builder.Property(x => x.Amount).HasColumnName("amount").HasMaxLength(50);
            builder.Property(x => x.OrderId).HasColumnName("order id").IsRequired();

            builder.HasIndex(x => x.OrderId).IsUnique();

            builder.HasOne(x => x.Order)
                .WithOne()
                .HasForeignKey<Payment>(x => x.OrderId)
                .HasConstraintName("FK_Payment_Orders");
        }
    }
}
