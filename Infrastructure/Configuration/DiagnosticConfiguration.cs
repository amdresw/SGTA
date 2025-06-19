using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class DiagnosticConfiguration : IEntityTypeConfiguration<Diagnostic>
    {
        public void Configure(EntityTypeBuilder<Diagnostic> builder)
        {
            builder.ToTable("Diagnostics");

            // Clave primaria
            builder.HasKey(d => d.Id);

            // Propiedades
            builder.Property(d => d.Description)
                   .HasMaxLength(400); // Ajusta según lo que necesites

            builder.Property(d => d.User_Id)
                   .IsRequired()
                   .HasColumnName("UserId");

            // Relaciones

            // Uno a muchos: Diagnostic -> DetailsDiagnostics
            builder.HasMany(d => d.DetailsDiagnostics)
                   .WithOne(dd => dd.Diagnostic)
                   .HasForeignKey(dd => dd.Diagnostic_Id)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.User)
                    .WithMany(u => u.Diagnostics)
                    .HasForeignKey(d => d.User_Id)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
