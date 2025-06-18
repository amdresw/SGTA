using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Inventory : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<DetaillInventory> DetaillInventory = new HashSet<DetaillInventory>();
    }
}