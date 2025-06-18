using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetaillInventory : BaseEntity
    {
        public int Id { get; set; }
        public int ServiceOrder_Id { get; set; }
        public int Inventory_Id { get; set; }
        public int Quantity { get; set; }

        public ServiceOrder? ServiceOrder { get; set; }
        public Inventory? Inventory { get; set; }
    }
}