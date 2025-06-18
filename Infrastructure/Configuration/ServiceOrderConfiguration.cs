using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class ServiceOrderConfiguration : IEntityTypeConfiguration<ServiceOrder>
    {
        public void Configure(EntityTypeBuilder<ServiceOrder> builder)
        {
            builder.ToTable("ServiceOrder");

            builder.HasKey(so => so.Id);
            builder.Property(so => so.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("id");

            builder.Property(so => so.Vehicles_Id)
                .HasColumnName("Vehicles_id");

            builder.Property(so => so.TypeService_Id)
                .HasColumnName("TypeService_id");

            builder.Property(so => so.Client_Id)
                .HasColumnName("Client_id");

            builder.Property(so => so.State_Id)
                .HasColumnName("State_id");
            
             builder.Property(so => so.EntryDate)
                   .IsRequired()
                   .HasColumnName("EntryDate");

            builder.Property(so => so.ExitDate)
                   .IsRequired()
                   .HasColumnName("ExitDate");

            builder.Property(so => so.IsAuthorized)
                   .IsRequired()
                   .HasColumnName("IsAuthorized");

            builder.Property(so => so.ClientMessage)
                   .HasMaxLength(1000)
                   .HasColumnName("ClientMessage");

            builder.HasOne(so => so.State)
                  .WithMany()
                  .HasForeignKey(so => so.State_Id);

            builder.HasOne(so => so.TypeService)
                   .WithMany()
                   .HasForeignKey(so => so.TypeService_Id);

                   
            builder.HasOne(so => so.Vehicle)
                .WithMany()
                .HasForeignKey(so => so.Vehicles_Id);

            builder.HasOne(so => so.Client)
                .WithMany()
                .HasForeignKey(so => so.Client_Id);

        }
    }
}