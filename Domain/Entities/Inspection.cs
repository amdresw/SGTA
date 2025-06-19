using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Inspection : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<DetaillInspection> DetaillInspections { get; set; } = new HashSet<DetaillInspection>();
    }
}