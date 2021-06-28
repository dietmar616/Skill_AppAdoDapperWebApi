
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.ISQLRepositories
{

    public interface IUsersRepository : IGenericRepository<SQLCustomer>
    {
        Task<IEnumerable<SQLCustomer>> GetAllDescUsers();
    }
}
