using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        protected readonly AutoTallerDbContext _context;

        public VehicleRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }        
    }
}