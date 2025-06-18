using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class SpacePartConfiguration : IEntityTypeConfiguration<SpacePart>
    {
        public void Configure(EntityTyoeBuilder<SpacePart> builder)
        {
            builder.ToTable("SpacePart");

            builder.HasKey(sp => sp.Id);
            builder.Property(ospd => sp.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(sp => sp.Code)
                .HasMaxLength(20)
                .HasColumnName("Code");

            builder.Property(sp => sp.Description)
                .HasMaxLength(50)
                .HasColumnName("Description");

            builder.Property(sp => sp.Stock)
                .HasColumnName("Stock");

            builder.Property(sp => sp.MiniStock)
                .HasColumnName("MiniStock");

            builder.Property(sp => sp.UnitPrice)
                .HasColumnType("decimal")
                .HasColumnName("UnitPrice");

            builder.Property(sp => sp.Category)
                .HasMaxLength(50)
                .HasColumnName("Category");

        }
    }
}