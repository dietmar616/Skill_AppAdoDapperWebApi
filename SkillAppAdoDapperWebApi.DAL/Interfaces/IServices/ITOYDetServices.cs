using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces.IServices
{
    public interface ITOYDetServices
    {

        public Task<DTOTOYDet> GetTOYDetById (int id); 

        public Task DeleteTOYDetById(int id);

       
    }
}
