
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.ISQLRepositories
{

    public interface ISQLOrderRepository : IGenericRepository<SQLOrder>
    {
        Task<IEnumerable<SQLOrder>> GetAllDescSQLOrder();
    }
}
