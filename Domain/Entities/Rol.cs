using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rol
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public ICollection<UserRol>? UserRols { get; set; } = new HashSet<UserRol>();
    }
}