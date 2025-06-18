using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(od => od.Id);
            builder.Property(od => od.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(od => od.RequiredPieces)
                .IsRequired()
                .HasColumnName("required_pieces");

            builder.Property(od => od.TotalPrice)
                .HasColumnType("decimal")
                .IsRequired()
                .HasColumnName("TotalPrice");

            builder.Property(od => od.ServiceOrder_Id)
                .HasColumnName("ServiceOrder_id");

            builder.Property(od => od.SpacePart_Id)
                .HasColumnName("SpacePart_id");

            builder.HasOne(od => od.ServiceOrder)
                .WithMany(so => so.OrderDetails)
                .HasForeignKey(od => od.ServiceOrder_Id);

            builder.HasOne(od => od.SpacePart)
                .WithMany(sp => sp.OrderDetails)
                .HasForeignKey(od => od.SpacePart_Id);
        }
    }
}