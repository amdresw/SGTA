using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Diagnostic
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string? Description { get; set; }

        public User? User { get; set; }

        public ICollection<DetailsDiagnostic>? DetailsDiagnostics { get; set; } = new HashSet<DetailsDiagnostic>();
    }
}