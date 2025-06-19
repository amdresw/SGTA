using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("order_details");

            builder.HasKey(od => od.Id);
            builder.Property(od => od.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(od => od.RequiredPieces)
                .IsRequired()
                .HasColumnName("required_pieces");

            builder.Property(od => od.TotalPrice)
                .HasPrecision(18, 2)
                .IsRequired()
                .HasColumnName("total_price"); 

            builder.Property(od => od.ServiceOrder_Id)
                .HasColumnName("service_order_id");  

            builder.Property(od => od.SparePart_Id)
                .HasColumnName("spare_part_id");

            builder.HasOne(od => od.ServiceOrder)
                .WithMany(so => so.OrderDetails)
                .HasForeignKey(od => od.ServiceOrder_Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(od => od.SpareParts)
                .WithMany(sp => sp.OrderDetails)
                .HasForeignKey(od => od.SparePart_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}