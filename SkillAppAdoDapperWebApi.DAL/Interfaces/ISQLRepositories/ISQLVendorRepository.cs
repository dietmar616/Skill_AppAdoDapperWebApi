using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.ISQLRepositories
{

    public interface ISQLVendorRepository : IGenericRepository<SQLVendor>
    {
        Task<IEnumerable<SQLVendor>> GetAllDescSQLVendor();
    }
}
