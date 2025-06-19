using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class StateRepository : GenericRepository<State>, IStateRepository
    {
        protected readonly AutoTallerDbContext _context;

        public StateRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }
    }
}