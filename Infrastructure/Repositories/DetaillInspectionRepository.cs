using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DetaillInspectionRepository : GenericRepository<DetaillInspection>, IDetaillInspectionRepository
    {
        public readonly AutoTallerDbContext _context;

        public DetaillInspectionRepository(AutoTallerDbContext context) : base(context)
        {
            _context = context;
        }
    }
}