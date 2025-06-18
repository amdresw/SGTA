using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class TypeService : IEntityTypeConfiguration<TypeService>
    {
        public void Configure(EntityTypeBuilder<TypeService> builder)
        {
            builder.ToTable("TypeService");

            builder.HasKey(ts => ts.Id);
            builder.Property(ts => ts.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(ts => ts.Name)
                .HasMaxLength(40)
                .HasColumnName("Name");

            builder.Property(ts => ts.Duration)
                .HasColumnName("Duration");

            builder.Property(ts => ts.Price)
                .HasColumnType("decimal")
                .HasColumnName("Price");
        }
    }
}