using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventory");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumn("id");

            builder.Property(i => i.Name)
                .HasColumnName("Name")
                .HasMaxLength(20);
        }
    }
}