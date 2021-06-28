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
    public class SQLCustomerRepository : GenericRepository<SQLCustomer>, ISQLCustomerRepository

    {
        private readonly Context _context;

        public SQLCustomerRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SQLCustomer>> GetAllDescSQLCustomer()
        {
            return await _context.Set<SQLCustomer>().OrderByDescending(c => c.Id).ToListAsync();
        }

    }
}