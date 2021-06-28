using System.Collections.Generic;
using System.Configuration;

using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Interfaces;
using DAL.Interfaces.ISQLRepositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DAL.Repositories.SQLRepositories
{
    public class SQLVendorRepository : GenericRepository<SQLVendor>, ISQLVendorRepository

    {
        private readonly Context _context;

        public SQLVendorRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SQLVendor>> GetAllDescSQLVendor()
        {
            return await _context.Set<SQLVendor>().OrderByDescending(c => c.Id).ToListAsync();
        }

    }
}
