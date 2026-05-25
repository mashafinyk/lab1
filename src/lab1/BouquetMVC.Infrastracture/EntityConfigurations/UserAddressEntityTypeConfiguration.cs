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
    public class UserAddressEntityTypeConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.ToTable("UserAddress");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.City).HasColumnName("city").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Street).HasColumnName("street").HasMaxLength(100).IsRequired();
            builder.Property(x => x.BuildingNumber).HasColumnName("building number").HasMaxLength(20).IsRequired();
            builder.Property(x => x.UserId).HasColumnName("user id").IsRequired();

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .HasConstraintName("FK_UserAddress_User");
        }
    }
}
