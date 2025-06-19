using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class SpessializationRepository : GenericRepository<Spessialization>, ISpessializationRepository
    {
        protected readonly AutoTallerDbContext _context;

        public SpessializationRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }
        
    }
}