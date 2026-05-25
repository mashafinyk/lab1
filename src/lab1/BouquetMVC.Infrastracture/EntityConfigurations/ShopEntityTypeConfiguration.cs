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
    public class ShopEntityTypeConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shop");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.PhoneNumber).HasColumnName("phone number").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Address).HasColumnName("address").HasMaxLength(200).IsRequired();
            builder.Property(x => x.OpeningTime).HasColumnName("opening time");
            builder.Property(x => x.ClosingTime).HasColumnName("closing time");
        }
    }
}
