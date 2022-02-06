using GSL.Infra.Data.Context;
using GSL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GSL.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GSLContext _context;
        public UnitOfWork(GSLContext context)
        {
            _context = context;
        }
        public async Task<bool> Commit()
        {
            var success = await _context.SaveChangesAsync() > 0;

            return success;
        }
    }
}
