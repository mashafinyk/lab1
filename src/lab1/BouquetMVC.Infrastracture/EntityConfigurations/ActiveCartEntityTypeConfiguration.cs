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
    public class ActiveCartEntityTypeConfiguration : IEntityTypeConfiguration<ActiveCart>
    {
        public void Configure(EntityTypeBuilder<ActiveCart> builder)
        {
            builder.ToTable("ActiveCart");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.CreationDate).HasColumnName("creation date").IsRequired();
            builder.Property(x => x.Status).HasColumnName("status").HasMaxLength(50);
            builder.Property(x => x.UserId).HasColumnName("user id").IsRequired();

            builder.HasIndex(x => x.UserId).IsUnique();

            builder.HasOne<User>()
                .WithOne()
                .HasForeignKey<ActiveCart>(x => x.UserId)
                .HasConstraintName("FK_ActiveCart_User");
        }
    }
}
