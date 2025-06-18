using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Auditory : BaseEntity
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string? Entity { get; set; }
        public date Date { get; set; }
        public enum TypeAction
        {
            Create,
            Update,
            Delete
        }

        public User? User { get; set; }
    }
}