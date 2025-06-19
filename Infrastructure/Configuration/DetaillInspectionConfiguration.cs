using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class DetaillInspectionConfiguration : IEntityTypeConfiguration<DetaillInspection>
    {
        public void Configure(EntityTypeBuilder<DetaillInspection> builder)
        {
            builder.ToTable("detaill_inspection");
            builder.HasKey(di => di.Id);
            builder.Property(di => di.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(di => di.ServiceOrder_Id)
                .HasColumnName("ServiceOrder_id");

            builder.Property(di => di.Inspection_Id)
                .HasColumnName("Inspection_id");

            builder.Property(di => di.Quantity)
                .HasColumnName("Quantity");
                
            builder.HasOne(di => di.ServiceOrder)
                .WithMany(so => so.DetaillInspections)
                .HasForeignKey(di => di.ServiceOrder_Id)
                .OnDelete(DeleteBehavior.Cascade);;

            builder.HasOne(di => di.Inspections)
                .WithMany(i => i.DetaillInspections)
                .HasForeignKey(di => di.Inspection_Id)
                .OnDelete(DeleteBehavior.Cascade);;

        }
    }
}