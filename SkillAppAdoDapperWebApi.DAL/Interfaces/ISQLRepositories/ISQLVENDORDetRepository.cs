using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.ISQLRepositories
{

    public interface ISQLVENDORDetRepository : IGenericRepository<SQLVENDORDet>
    {
        Task<IEnumerable<SQLVENDORDet>> GetAllDescSQLVENDORDet();
    }
}
