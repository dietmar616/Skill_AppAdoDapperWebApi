using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.ISQLRepositories
{

    public interface ISQLTOYDetRepository : IGenericRepository<SQLTOYDet>
    {
        Task<IEnumerable<SQLTOYDet>> GetAllDescSQLTOYDet();
    }
}
