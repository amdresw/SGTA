using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class ServiceOrderRepository : GenericRepository<ServiceOrder>, IServiceOrderRepository
    {
        protected readonly AutoTallerDbContext _context;

        public ServiceOrderRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }
        
    }
}