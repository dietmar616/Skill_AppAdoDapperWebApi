
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.ISQLRepositories
{

    public interface ISQLCustomerRepository : IGenericRepository<SQLCustomer>
    {
        Task<IEnumerable<SQLCustomer>> GetAllDescSQLCustomer();
    }
}
