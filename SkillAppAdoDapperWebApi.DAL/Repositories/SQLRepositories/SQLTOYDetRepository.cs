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
    public class SQLTOYDetRepository : GenericRepository<SQLTOYDet>, ISQLTOYDetRepository

    {
        private readonly Context _context;

        public SQLTOYDetRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SQLTOYDet>> GetAllDescSQLTOYDet()
        {
            return await _context.Set<SQLTOYDet>().OrderByDescending(c => c.Id).ToListAsync();
        }

    }
}

