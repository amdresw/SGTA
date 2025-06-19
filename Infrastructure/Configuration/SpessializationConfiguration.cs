using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class SpessializationConfiguration: IEntityTypeConfiguration<Spessialization>
    {
        public void Configure(EntityTypeBuilder<Spessialization> builder)
        {
            builder.ToTable("Spessializations");

            // Clave primaria
            builder.HasKey(s => s.Id);

            // Propiedades
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            // Relaciones
            builder.HasMany(s => s.UserSpessialization)
                   .WithOne(us => us.Spessialization)
                   .HasForeignKey(us => us.Spessialization_Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}