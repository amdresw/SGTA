using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public int Id { get; set; }
        public int ServiceOrder_Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public ICollection<ServiceOrder> ServiceOrder { get; set; }= new HashSet<ServiceOrder>();
    }
}