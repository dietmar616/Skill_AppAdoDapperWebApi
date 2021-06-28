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
    public class SQLToyRepository : GenericRepository<SQLToy>, ISQLToyRepository

    {
        private readonly Context _context;

        public SQLToyRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SQLToy>> GetAllDescSQLToy()
        {
            return await _context.Set<SQLToy>().OrderByDescending(c => c.Id).ToListAsync();
        }

    }
}

