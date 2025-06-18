using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity { 
      public DateTime createdAt { get; set; } 
      public DateTime? updatedAt { get; set; } 
 } 
}