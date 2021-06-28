using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces.IServices
{
    public interface IVendorServices
    {

        public Task<DTOVendor> GetVendorById(int id); 

        public Task DeleteVendorById(int id);

       
    }
}
