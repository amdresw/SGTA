using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRolRepository : GenericRepository<UserRol>, IUserRolRepository
    {
        protected readonly AutoTallerDbContext _context;

        public UserRolRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }
    }
}