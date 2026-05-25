using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Infrastracture.EntityConfigurations
{
    public class TypeOfFlowerEntityTypeConfiguration : IEntityTypeConfiguration<TypeOfFlower>
    {
        public void Configure(EntityTypeBuilder<TypeOfFlower> builder)
        {
            builder.ToTable("TypeOfFlower");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Color).HasColumnName("color").HasMaxLength(50);
            builder.Property(x => x.Height).HasColumnName("height");
            builder.Property(x => x.Price).HasColumnName("price").HasColumnType("decimal(10,2)").IsRequired();
        }
    }
}
