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
    public class ResponseEntityTypeConfiguration : IEntityTypeConfiguration<Response>
    {
        public void Configure(EntityTypeBuilder<Response> builder)
        {
            builder.ToTable("Response");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Rating).HasColumnName("rating");
            builder.Property(x => x.Comment).HasColumnName("comment").HasMaxLength(500);
            builder.Property(x => x.Date).HasColumnName("date").IsRequired();
            builder.Property(x => x.OrderId).HasColumnName("order id").IsRequired();

            builder.HasIndex(x => x.OrderId).IsUnique();

            builder.HasOne(x => x.Order)
                .WithOne()
                .HasForeignKey<Response>(x => x.OrderId)
                .HasConstraintName("FK_Response_Orders");
        }
    }
}
