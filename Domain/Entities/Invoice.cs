using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ServiceOrder_Id { get; set; }
        public decimal TotalPrice { get; set; }
        public date Date { get; set; }

        public ICollection<ServiceOrder> ServiceOrder = new HashSet<ServiceOrder>();
    }
}