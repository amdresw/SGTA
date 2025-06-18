using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(i => i.TotalPrice)
                .HasColumnType("decimal")
                .HasColumnName("TotalPrice");

            builder.Property(i => i.Date)
                .IsRequired()
                .HasColumnName("Date");

            builder.HasOne(i => i.ServiceOrder)
                .WithOne(so => so.Invoice)
                .HasForeignKey<Invoice>(i => i.ServiceOrder_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
