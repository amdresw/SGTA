using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class ServiceOrderConfiguration : IEntityTypeConfiguration<ServiceOrder>
    {
        public void Configure(EntityTypeBuilder<ServiceOrder> builder)
        {
            builder.ToTable("service_order");

            builder.HasKey(so => so.Id);
            builder.Property(so => so.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(so => so.Vehicles_Id)
                .HasColumnName("vehicles_id");

            builder.Property(so => so.TypeService_Id)
                .HasColumnName("type_service_id");

            builder.Property(so => so.Client_Id)
                .HasColumnName("client_id");

            builder.Property(so => so.State_Id)
                .HasColumnName("state_id");

            builder.Property(so => so.EntryDate)
                .IsRequired()
                .HasColumnType("timestamp")
                .HasColumnName("entry_date");

            builder.Property(so => so.ExitDate)
                .HasColumnType("timestamp")
                .HasColumnName("exit_date");

            // Otros campos
            builder.Property(so => so.IsAuthorized)
                .IsRequired()
                .HasDefaultValue(false)
                .HasColumnName("is_authorized");

            builder.Property(so => so.ClientMessage)
                .HasColumnName("client_message");

            builder.HasOne(so => so.Vehicle)
                .WithMany(v => v.ServiceOrders)
                .HasForeignKey(so => so.Vehicles_Id)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(so => so.TypeService)
                .WithMany(ts => ts.ServiceOrders)
                .HasForeignKey(so => so.TypeService_Id)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(so => so.State)
                .WithMany(s => s.ServiceOrders)
                .HasForeignKey(so => so.State_Id)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(so => so.Client)
                .WithMany(c => c.ServiceOrders)
                .HasForeignKey(so => so.Client_Id)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}