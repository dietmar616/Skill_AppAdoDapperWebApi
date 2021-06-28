using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces.IServices
{
    public interface IVENDORDetServices
    {

        public Task<DTOVENDORDet> GetVENDORDetById(int id); 

        public Task DeleteVENDORDetById(int id);

       
    }
}
