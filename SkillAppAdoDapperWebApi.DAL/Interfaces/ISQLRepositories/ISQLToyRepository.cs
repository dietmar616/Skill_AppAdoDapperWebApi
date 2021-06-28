using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.ISQLRepositories
{

    public interface ISQLToyRepository : IGenericRepository<SQLToy>
    {
        Task<IEnumerable<SQLToy>> GetAllDescSQLToy();
    }
}
