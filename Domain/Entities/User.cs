using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        
        public IColletion<Auditory>? Auditories { get; set; } = new HashSet<Auditory>();
        public IColletion<UserRol>? UserRols { get; set; } = new HashSet<UserRol>();
        public IColletion<Diagnostic>? Diagnostics { get; set; } = new HashSet<Diagnostic>();
        public IColletion<UserSpessialization>? UserSpessializations { get; set; } = new HashSet<UserSpessialization>();
    }
}