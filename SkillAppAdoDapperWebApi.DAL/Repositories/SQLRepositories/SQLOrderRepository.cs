

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
    public class SQLOrderRepository : GenericRepository<SQLOrder>, ISQLOrderRepository

    {
        private readonly Context _context;

        public SQLOrderRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SQLOrder>> GetAllDescSQLOrder()
        {
            return await _context.Set<SQLOrder>().OrderByDescending(c => c.Id).ToListAsync();
        }

    }
}
