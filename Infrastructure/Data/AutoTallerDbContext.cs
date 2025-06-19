using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AutoTallerDbContext : DbContext
    {
        public AutoTallerDbContext(DbContextOptions<AutoTallerDbContext> options) : base(options) { }

        public DbSet<Auditory> Auditory { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<DetaillInspection> DetaillInspection { get; set; }
        public DbSet<Diagnostic> Diagnostic { get; set; }
        public DbSet<Inspection> Inspection { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<ServiceOrder> ServiceOrder { get; set; }
        public DbSet<SparePart> SparePart { get; set; }
        public DbSet<Spessialization> Spessialization { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<TypeService> TyperService { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRol> UserRole { get; set; }
        public DbSet<UserSpessialization> UserSpessialization { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}