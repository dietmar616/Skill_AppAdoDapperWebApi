using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
    
        Task<IEnumerable<T>> GetAll(); 

        Task<T> GetById(int id);
     

        Task DeleteById(int id);

     

    }
}
