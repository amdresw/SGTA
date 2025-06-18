using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class DetaillInventoryConfiguration : IEntityTypeConfiguration<DetaillInventory>
    {
        public void Configure(EntityTypeBuilder<DetaillInventory> builder)
        {
            builder.ToTable("DetaillInventory");
            builder.HasKey(di => di.Id);
            builder.Property(di => di.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(di => di.ServiceOrder_Id)
                .HasColumnName("ServiceOrder_id");

            builder.Property(di => di.Inventory_Id)
                .HasColumnName("Inventory_id");

            builder.HasOne(di => di.ServiceOrder)
                .WithMany(so => so.DetaillInventory)
                .HasForeignKey(di => di.ServiceOrder_Id);

            builder.HasOne(di => di.Inventory)
                .WithMany(i => i.DetaillInventory)
                .HasForeignKey(di => di.Inventory_Id);

            builder.Property(di => di.Quantity)
                .HasColumnName("Quantity");
        }
    }
}