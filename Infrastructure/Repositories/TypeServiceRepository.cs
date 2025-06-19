using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class TypeServiceRepository : GenericRepository<TypeService>, ITypeServiceRepository
    {
        protected readonly AutoTallerDbContext _context;

        public TypeServiceRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }
    }
}