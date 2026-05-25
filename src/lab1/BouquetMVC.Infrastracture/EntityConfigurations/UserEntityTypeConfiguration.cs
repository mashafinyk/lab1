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
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(100).IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnName("phone number").HasMaxLength(20);
            builder.Property(x => x.Login).HasColumnName("login").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasColumnName("password").HasMaxLength(100).IsRequired();

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Login).IsUnique();
        }
    }
}
