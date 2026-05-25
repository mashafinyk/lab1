using BouquetMVС.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Infrastracture.EntityConfigurations
{
    public class BouquetAndFlowerEntityTypeConfiguration : IEntityTypeConfiguration<BouquetAndFlower>
    {
        public void Configure(EntityTypeBuilder<BouquetAndFlower> builder)
        {
            builder.ToTable("BouquetAndFlower");

            builder.HasKey(x => new { x.BouquetId, x.FlowerId });

            builder.Property(x => x.BouquetId).HasColumnName("bouquet id");
            builder.Property(x => x.FlowerId).HasColumnName("flower id");

            builder.HasOne<Bouquet>()
                .WithMany()
                .HasForeignKey(x => x.BouquetId)
                .HasConstraintName("FK_BouquetAndFlower_Bouquet");

            builder.HasOne<TypeOfFlower>()
                .WithMany()
                .HasForeignKey(x => x.FlowerId)
                .HasConstraintName("FK_BouquetAndFlower_Flower");
        }
    }
}
