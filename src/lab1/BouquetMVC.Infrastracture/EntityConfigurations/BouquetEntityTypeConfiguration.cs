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
    public class BouquetEntityTypeConfiguration : IEntityTypeConfiguration<Bouquet>
    {
        public void Configure(EntityTypeBuilder<Bouquet> builder)
        {
            builder.ToTable("Bouquet");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500);
            builder.Property(x => x.Price).HasColumnName("price").HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(x => x.PromotionId).HasColumnName("promotion id");

            builder.HasOne<Promotion>()
                .WithMany()
                .HasForeignKey(x => x.PromotionId)
                .HasConstraintName("FK_Bouquet_Promotion");
        }
    }
}
