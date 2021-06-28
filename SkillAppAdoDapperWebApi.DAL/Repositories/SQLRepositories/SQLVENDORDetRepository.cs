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
    public class SQLVENDORDetRepository : GenericRepository<SQLVENDORDet>, ISQLVENDORDetRepository

    {
        private readonly Context _context;

        public SQLVENDORDetRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SQLVENDORDet>> GetAllDescSQLVENDORDet()
        {
            return await _context.Set<SQLVENDORDet>().OrderByDescending(c => c.Id).ToListAsync();
        }

    }
}

