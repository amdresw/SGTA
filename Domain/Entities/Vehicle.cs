using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Client_Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Mileage { get; set; }

        public Client? Client { get; set; }
    }
}