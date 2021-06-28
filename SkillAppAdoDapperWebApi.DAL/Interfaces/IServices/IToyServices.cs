using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces.IServices
{
    public interface IToyServices
    {

        public Task<DTOToy> GetToyById(int id); 

        public Task DeleteToyById(int id);

       
    }
}
