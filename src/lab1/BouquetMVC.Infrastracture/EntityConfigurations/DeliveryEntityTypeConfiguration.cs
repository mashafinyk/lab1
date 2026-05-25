using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Infrastracture.EntityConfigurations
{
    public class DeliveryEntityTypeConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("Delivery");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Date).HasColumnName("date").IsRequired();
            builder.Property(x => x.Type).HasColumnName("type").HasMaxLength(50);
            builder.Property(x => x.Status).HasColumnName("status").HasMaxLength(50);
            builder.Property(x => x.ShopId).HasColumnName("shop id").IsRequired();

            builder.HasOne<Shop>()
                .WithMany()
                .HasForeignKey(x => x.ShopId)
                .HasConstraintName("FK_Delivery_Shop");
        }
    }
}
