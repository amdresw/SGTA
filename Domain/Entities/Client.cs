using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public date Birth { get; set; }
        public string? Identification { get; set; }

        public ICollection<Vehicle>? Vehicles { get; set; } = new HashSet<Vehicle>();
    }
}