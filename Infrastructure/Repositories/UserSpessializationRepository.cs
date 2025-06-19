using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class UserSpessializationRepository : GenericRepository<UserSpessialization>, IUserSpessializationRepository
    {
        protected readonly AutoTallerDbContext _context;

        public UserSpessializationRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }
    }
}