using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserSpessialization
    {
        public int UserId { get; set; }
        public int SpessializationId { get; set; }

        public User? User { get; set; }
        public Spessialization? Spessialization { get; set; }
    }
}