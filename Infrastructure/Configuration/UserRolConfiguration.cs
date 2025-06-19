using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Configurations
{
    public class UserRolConfiguration : IEntityTypeConfiguration<UserRol>
    {
        public void Configure(EntityTypeBuilder<UserRol> builder)
        {
            builder.ToTable("UserRoles");

            // Clave primaria compuesta
            builder.HasKey(ur => new { ur.User_Id, ur.Rol_Id });

            // Relaciones

            // Muchos UserRol para un User
            builder.HasOne(ur => ur.User)
                   .WithMany(u => u.UserRoles)
                   .HasForeignKey(ur => ur.User_Id)
                   .OnDelete(DeleteBehavior.Cascade);

            // Muchos UserRol para un Rol
            builder.HasOne(ur => ur.Rol)
                   .WithMany(r => r.UserRoles)
                   .HasForeignKey(ur => ur.Rol_Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
