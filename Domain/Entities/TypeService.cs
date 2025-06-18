using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TypeService
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }

        public ICollection<ServiceOrder> ServiceOrder = new HashSet<ServiceOrder>();
    }
}