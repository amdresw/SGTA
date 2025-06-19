using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Configuration
{
    public class UserSpessializationConfiguration: IEntityTypeConfiguration<UserSpessialization>
    {
        public void Configure(EntityTypeBuilder<UserSpessialization> builder)
        {
            builder.ToTable("UserSpessializations");

            // Clave primaria compuesta
            builder.HasKey(us => new { us.Spessialization_Id, us.User_Id });

            // Relaciones

            // Muchos UserSpessialization para un User
            builder.HasOne(us => us.User)
                   .WithMany(u => u.UserSpessialization)
                   .HasForeignKey(us => us.User_Id)
                   .OnDelete(DeleteBehavior.Cascade);

            // Muchos UserSpessialization para una Spessialization
            builder.HasOne(us => us.Spessialization)
                   .WithMany(s => s.UserSpessialization)
                   .HasForeignKey(us => us.Spessialization_Id)
                   .OnDelete(DeleteBehavior.Cascade);
        } 
    }
}